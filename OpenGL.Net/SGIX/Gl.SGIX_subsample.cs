
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
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_PACK_SUBSAMPLE_RATE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_subsample")]
		public const int PACK_SUBSAMPLE_RATE_SGIX = 0x85A0;

		/// <summary>
		/// Value of GL_UNPACK_SUBSAMPLE_RATE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_subsample")]
		public const int UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1;

		/// <summary>
		/// Value of GL_PIXEL_SUBSAMPLE_4444_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_subsample")]
		public const int PIXEL_SUBSAMPLE_4444_SGIX = 0x85A2;

		/// <summary>
		/// Value of GL_PIXEL_SUBSAMPLE_2424_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_subsample")]
		public const int PIXEL_SUBSAMPLE_2424_SGIX = 0x85A3;

		/// <summary>
		/// Value of GL_PIXEL_SUBSAMPLE_4242_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_subsample")]
		public const int PIXEL_SUBSAMPLE_4242_SGIX = 0x85A4;

	}

}
