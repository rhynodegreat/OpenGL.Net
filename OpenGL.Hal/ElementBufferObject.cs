
// Copyright (C) 2009-2015 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Element buffer object.
	/// </summary>
	public class ElementBufferObject : ArrayBufferObjectBase, ArrayBufferObjectBase.IArraySection
	{
		#region Constructors

		/// <summary>
		/// Construct an ElementBufferObject, implictly used with <see cref="BufferObjectHint.StaticCpuDraw"/>.
		/// </summary>
		/// <param name="elementType">
		/// The <see cref="DrawElementsType"/> that specify how vertices are interpreted.
		/// </param>
		public ElementBufferObject(DrawElementsType elementType) :
			this(elementType, BufferObjectHint.StaticCpuDraw)
		{

		}

		/// <summary>
		/// Construct an ElementBufferObject.
		/// </summary>
		/// <param name="elementType">
		/// The <see cref="DrawElementsType"/> that specify how vertices are interpreted.
		/// </param>
		/// <param name="hint">
		/// An <see cref="BufferObjectHint"/> that specify the data buffer usage hints.
		/// </param>
		public ElementBufferObject(DrawElementsType elementType, BufferObjectHint hint)
			: base(BufferTargetARB.ElementArrayBuffer, hint)
		{
			try {
				// Determine ElementsType and default RestartIndexKey
				ElementsType = elementType;
				switch (elementType) {
					case DrawElementsType.UnsignedByte:
						ItemSize = 1;
						RestartIndexKey = 0x000000FF;
						break;
					case DrawElementsType.UnsignedShort:
						ItemSize = 2;
						RestartIndexKey = 0x0000FFFF;
						break;
					case DrawElementsType.UnsignedInt:
						ItemSize = 4;
						RestartIndexKey = 0xFFFFFFFF;
						break;
					default:
						throw new ArgumentException("type not supported", "elementType");
				}
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		/// <summary>
		/// Construct an ElementBufferObject.
		/// </summary>
		/// <param name="elementType">
		/// 
		/// </param>
		/// <param name="hint">
		/// An <see cref="BufferObjectHint"/> that specify the data buffer usage hints.
		/// </param>
		protected ElementBufferObject(Type elementType, BufferObjectHint hint)
			: base(BufferTargetARB.ElementArrayBuffer, hint)
		{
			try {
				// Determine ElementsType and default RestartIndexKey
				switch (Type.GetTypeCode(elementType)) {
					case TypeCode.Byte:
						ElementsType = DrawElementsType.UnsignedByte;
						ItemSize = 1;
						RestartIndexKey = 0x000000FF;
						break;
					case TypeCode.UInt16:
						ElementsType = DrawElementsType.UnsignedShort;
						ItemSize = 2;
						RestartIndexKey = 0x0000FFFF;
						break;
					case TypeCode.UInt32:
						ElementsType = DrawElementsType.UnsignedInt;
						ItemSize = 4;
						RestartIndexKey = 0xFFFFFFFF;
						break;
					default:
						throw new ArgumentException("type not supported", "elementType");
				}
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		#endregion

		#region Elements Type

		/// <summary>
		/// The type of the array elements.
		/// </summary>
		internal readonly DrawElementsType ElementsType;

		/// <summary>
		/// Get the <see cref="ArrayBufferItemType"/> corresponding to <see cref="ElementsType"/>.
		/// </summary>
		private ArrayBufferItemType ArrayType
		{
			get
			{
				switch (ElementsType) {
					case DrawElementsType.UnsignedByte:
						return (ArrayBufferItemType.UByte);
					case DrawElementsType.UnsignedShort:
						return (ArrayBufferItemType.UShort);
					case DrawElementsType.UnsignedInt:
						return (ArrayBufferItemType.UInt);
					default:
						throw new NotSupportedException();
				}
			}
		}

		#endregion
		
		#region Primitive Restart
		
		/// <summary>
		/// The restart index enabled.
		/// </summary>
		public bool RestartIndexEnabled;

		/// <summary>
		/// The restart index value (fixed).
		/// </summary>
		public readonly uint RestartIndexKey;

		/// <summary>
		/// Utility routine for extracting 
		/// </summary>
		/// <param name="count">
		/// 
		/// </param>
		/// <returns>
		/// 
		/// </returns>
		private int[] GetRestartIndices(out IntPtr[] count)
		{
			Map();
			try {
				switch (ElementsType) {
					case DrawElementsType.UnsignedByte:
						return (GetRestartIndices_UnsignedByte(out count));
					case DrawElementsType.UnsignedShort:
						return (GetRestartIndices_UnsignedShort(out count));
					case DrawElementsType.UnsignedInt:
						return (GetRestartIndices_UnsignedInt(out count));
					default:
						throw new NotSupportedException();
				}
			} finally {
				Unmap();
			}
		}

		private int[] GetRestartIndices_UnsignedByte(out IntPtr[] count)
		{
			unsafe {
				List<int> offsets = new List<int>();
				List<IntPtr> counts = new List<IntPtr>();
				byte* indicesPtr = (byte*)ClientBufferAddress.ToPointer();
				byte restartIndex = (byte)(RestartIndexKey & 0x000000FF);

				offsets.Add(0);
				for (int i = 0; i < ItemCount; i++, indicesPtr++) {
					if (indicesPtr[i] == restartIndex) {
						int previousIndex = offsets[offsets.Count - 1];

						counts.Add(new IntPtr(i - previousIndex));
						offsets.Add(i + 1);
					}
				}
				counts.Add(new IntPtr((int)ItemCount - offsets[offsets.Count - 1]));

				Debug.Assert(offsets.Count == counts.Count);
				count = counts.ToArray();

				return (offsets.ToArray());
			}
		}

		private int[] GetRestartIndices_UnsignedShort(out IntPtr[] count)
		{
			unsafe
			{
				List<int> offsets = new List<int>();
				List<IntPtr> counts = new List<IntPtr>();
				ushort* indicesPtr = (ushort*)ClientBufferAddress.ToPointer();
				ushort restartIndex = (ushort)(RestartIndexKey & 0x0000FFFF);

				for (int i = 0; i < ItemCount; i++) {
					if (indicesPtr[i] == restartIndex) {
						int previousIndex = offsets[offsets.Count - 1];

						counts.Add(new IntPtr(i - previousIndex));
						offsets.Add(i + 1);
					}
				}
				counts.Add(new IntPtr((int)ItemCount - offsets[offsets.Count - 1]));

				Debug.Assert(offsets.Count == counts.Count);
				count = counts.ToArray();

				return (offsets.ToArray());
			}
		}

		private int[] GetRestartIndices_UnsignedInt(out IntPtr[] count)
		{
			unsafe
			{
				List<int> offsets = new List<int>();
				List<IntPtr> counts = new List<IntPtr>();
				uint* indicesPtr = (uint*)ClientBufferAddress.ToPointer();
				uint restartIndex = RestartIndexKey;

				for (int i = 0; i < ItemCount; i++) {
					if (indicesPtr[i] == restartIndex) {
						int previousIndex = offsets[offsets.Count - 1];

						counts.Add(new IntPtr(i - previousIndex));
						offsets.Add(i + 1);
					}
				}
				counts.Add(new IntPtr((int)ItemCount - offsets[offsets.Count - 1]));

				Debug.Assert(offsets.Count == counts.Count);
				count = counts.ToArray();

				return (offsets.ToArray());
			}
		}

		/// <summary>
		/// Offset of the primitives at each restart.
		/// </summary>
		internal int[] PrimitiveRestartOffsets;

		/// <summary>
		/// Number of indices composing the restarted primitives.
		/// </summary>
		internal IntPtr[] PrimitiveRestartCounts;

		#endregion

		#region ArrayBufferObjectBase Overrides

		/// <summary>
		/// Get the count of the array sections aggregated in this ArrayBufferObjectBase.
		/// </summary>
		/// <exception cref="NotImplementedException">
		/// Exception always thrown.
		/// </exception>
		protected internal override uint ArraySectionsCount { get { return (1); } }

		/// <summary>
		/// Get the specified section information.
		/// </summary>
		/// <param name="index">
		/// The <see cref="UInt32"/> that specify the array section index.
		/// </param>
		/// <returns>
		/// It returns the <see cref="IArraySection"/> defining the array section.
		/// </returns>
		/// <exception cref="NotImplementedException">
		/// Exception always thrown.
		/// </exception>
		protected internal override IArraySection GetArraySection(uint index) { return (this); }

		/// <summary>
		/// Convert the client buffer in a strongly-typed array.
		/// </summary>
		/// <returns>
		/// It returns an <see cref="Array"/> having all items stored by this ArrayBufferObjectBase.
		/// </returns>
		public override Array ToArray()
		{
			if (ClientBufferAddress == IntPtr.Zero)
				throw new InvalidOperationException("no client buffer");

			Array genericArray = CreateArray(ArrayType, ItemCount);

			// Copy from buffer data to array data
			Memory.MemoryCopy(genericArray, ClientBufferAddress, ItemCount * ItemSize);

			return (genericArray);
		}

		/// <summary>
		/// Convert the GPU buffer in a strongly-typed array.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> that has created this ArrayBufferObject.
		/// </param>
		/// <returns>
		/// It returns an <see cref="Array"/> having all items stored by this ArrayBufferObjectBase.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this ArrayBufferObject does not exist for <paramref name="ctx"/>.
		/// </exception>
		public override Array ToArray(GraphicsContext ctx)
		{
			if (Exists(ctx) == false)
				throw new InvalidOperationException("not existing");

			Array genericArray = CreateArray(ArrayType, ItemCount);

			// By checking existence, it's sure that we map the GPU buffer
			Map(ctx, BufferAccessARB.ReadOnly);
			try {
				// Copy from mapped data to array data
				Memory.MemoryCopy(genericArray, MappedBuffer, ItemCount * ItemSize);
			} finally {
				Unmap(ctx);
			}

			return (genericArray);
		}

		/// <summary>
		/// Actually create this BufferObject resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject has not client memory allocated and the hint is different from
		/// <see cref="BufferObjectHint.StaticCpuDraw"/> or <see cref="BufferObjectHint.DynamicCpuDraw"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is currently mapped.
		/// </exception>
		protected override void CreateObject(GraphicsContext ctx)
		{
			// Base implementation
			base.CreateObject(ctx);
			// Compute necessary information to support primitive restart even if the platform does not implement it
			if (!PrimitiveRestart.IsPrimitiveRestartSupported(ctx)  && RestartIndexEnabled)
				PrimitiveRestartOffsets = GetRestartIndices(out PrimitiveRestartCounts);
		}

		#endregion

		#region ArrayBufferObjectBase.IArraySection Implementation

		/// <summary>
		/// The type of the elements of the array section.
		/// </summary>
		ArrayBufferItemType IArraySection.ItemType { get { throw new NotImplementedException(); } }

		/// <summary>
		/// Get whether the array elements should be meant normalized (fixed point precision values).
		/// </summary>
		bool IArraySection.Normalized { get { return (false); } }

		/// <summary>
		/// Get the actual array buffer pointer. It could be <see cref="IntPtr.Zero"/> indicating an actual GPU
		/// buffer reference.
		/// </summary>
		IntPtr IArraySection.Pointer { get { return (GpuBufferAddress); } }

		/// <summary>
		/// Offset of the first element of the array section, in bytes.
		/// </summary>
		IntPtr IArraySection.Offset { get { return (IntPtr.Zero); } }

		/// <summary>
		/// Offset between two element of the array section, in bytes.
		/// </summary>
		IntPtr IArraySection.Stride { get { return (IntPtr.Zero); } }

		#endregion
	}

	/// <summary>
	/// Element buffer object.
	/// </summary>
	/// <typeparam name="T">
	/// The generic type must be <see cref="Byte"/>, <see cref="UInt16"/> or <see cref="UInt32"/>, otherwise
	/// the constructors will throw an exception.
	/// </typeparam>
	public class ElementBufferObject<T> : ElementBufferObject where T : struct, IConvertible
	{
		#region Constructors

		/// <summary>
		/// Construct an ElementBufferObject, implictly used with <see cref="BufferObjectHint.StaticCpuDraw"/>.
		/// </summary>
		public ElementBufferObject() :
			this(BufferObjectHint.StaticCpuDraw)
		{

		}

		/// <summary>
		/// Construct an ElementBufferObject.
		/// </summary>
		/// <param name="hint">
		/// An <see cref="BufferObjectHint"/> that specify the data buffer usage hints.
		/// </param>
		public ElementBufferObject(BufferObjectHint hint) :
			base(typeof(T), hint)
		{
			
		}

		#endregion
	}
}