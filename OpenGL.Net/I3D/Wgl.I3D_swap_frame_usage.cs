
// Copyright (C) 2015 Luca Piccioni
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

#pragma warning disable 1734

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Wgl
	{
		/// <summary>
		/// Binding for wglGetFrameUsageI3D.
		/// </summary>
		/// <param name="pUsage">
		/// A <see cref="T:float []"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_swap_frame_usage")]
		public static bool GetFrameUsageI3D([Out] float [] pUsage)
		{
			bool retValue;

			unsafe {
				fixed (float * p_pUsage = pUsage)
				{
					Debug.Assert(Delegates.pwglGetFrameUsageI3D != null, "pwglGetFrameUsageI3D not implemented");
					retValue = Delegates.pwglGetFrameUsageI3D(p_pUsage);
					LogFunction("wglGetFrameUsageI3D({0}) = {1}", LogValue(pUsage), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglBeginFrameTrackingI3D.
		/// </summary>
		[RequiredByFeature("WGL_I3D_swap_frame_usage")]
		public static bool BeginFrameTrackingI3D()
		{
			bool retValue;

			Debug.Assert(Delegates.pwglBeginFrameTrackingI3D != null, "pwglBeginFrameTrackingI3D not implemented");
			retValue = Delegates.pwglBeginFrameTrackingI3D();
			LogFunction("wglBeginFrameTrackingI3D() = {0}", retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglEndFrameTrackingI3D.
		/// </summary>
		[RequiredByFeature("WGL_I3D_swap_frame_usage")]
		public static bool EndFrameTrackingI3D()
		{
			bool retValue;

			Debug.Assert(Delegates.pwglEndFrameTrackingI3D != null, "pwglEndFrameTrackingI3D not implemented");
			retValue = Delegates.pwglEndFrameTrackingI3D();
			LogFunction("wglEndFrameTrackingI3D() = {0}", retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglQueryFrameTrackingI3D.
		/// </summary>
		/// <param name="pFrameCount">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="pMissedFrames">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="pLastMissedUsage">
		/// A <see cref="T:float []"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_swap_frame_usage")]
		public static bool QueryFrameTrackingI3D(Int32[] pFrameCount, Int32[] pMissedFrames, float [] pLastMissedUsage)
		{
			bool retValue;

			unsafe {
				fixed (Int32* p_pFrameCount = pFrameCount)
				fixed (Int32* p_pMissedFrames = pMissedFrames)
				fixed (float * p_pLastMissedUsage = pLastMissedUsage)
				{
					Debug.Assert(Delegates.pwglQueryFrameTrackingI3D != null, "pwglQueryFrameTrackingI3D not implemented");
					retValue = Delegates.pwglQueryFrameTrackingI3D(p_pFrameCount, p_pMissedFrames, p_pLastMissedUsage);
					LogFunction("wglQueryFrameTrackingI3D({0}, {1}, {2}) = {3}", LogValue(pFrameCount), LogValue(pMissedFrames), LogValue(pLastMissedUsage), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
