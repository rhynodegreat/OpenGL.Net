
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
	public partial class Glx
	{
		/// <summary>
		/// Value of GLX_CONTEXT_CORE_PROFILE_BIT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GLX_ARB_create_context_profile")]
		[Log(BitmaskName = "GLXContextProfileMask")]
		public const uint CONTEXT_CORE_PROFILE_BIT_ARB = 0x00000001;

		/// <summary>
		/// Value of GLX_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GLX_ARB_create_context_profile")]
		[Log(BitmaskName = "GLXContextProfileMask")]
		public const uint CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB = 0x00000002;

		/// <summary>
		/// Value of GLX_CONTEXT_PROFILE_MASK_ARB symbol.
		/// </summary>
		[RequiredByFeature("GLX_ARB_create_context_profile")]
		public const int CONTEXT_PROFILE_MASK_ARB = 0x9126;

	}

}
