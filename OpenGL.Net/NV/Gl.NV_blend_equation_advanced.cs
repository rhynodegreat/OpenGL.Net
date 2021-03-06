
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
		/// Value of GL_BLEND_OVERLAP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int BLEND_OVERLAP_NV = 0x9281;

		/// <summary>
		/// Value of GL_BLEND_PREMULTIPLIED_SRC_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int BLEND_PREMULTIPLIED_SRC_NV = 0x9280;

		/// <summary>
		/// Value of GL_COLORBURN_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int COLORBURN_NV = 0x929A;

		/// <summary>
		/// Value of GL_COLORDODGE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int COLORDODGE_NV = 0x9299;

		/// <summary>
		/// Value of GL_CONJOINT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int CONJOINT_NV = 0x9284;

		/// <summary>
		/// Value of GL_CONTRAST_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int CONTRAST_NV = 0x92A1;

		/// <summary>
		/// Value of GL_DARKEN_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int DARKEN_NV = 0x9297;

		/// <summary>
		/// Value of GL_DIFFERENCE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int DIFFERENCE_NV = 0x929E;

		/// <summary>
		/// Value of GL_DISJOINT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int DISJOINT_NV = 0x9283;

		/// <summary>
		/// Value of GL_DST_ATOP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int DST_ATOP_NV = 0x928F;

		/// <summary>
		/// Value of GL_DST_IN_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int DST_IN_NV = 0x928B;

		/// <summary>
		/// Value of GL_DST_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int DST_NV = 0x9287;

		/// <summary>
		/// Value of GL_DST_OUT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int DST_OUT_NV = 0x928D;

		/// <summary>
		/// Value of GL_DST_OVER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int DST_OVER_NV = 0x9289;

		/// <summary>
		/// Value of GL_EXCLUSION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int EXCLUSION_NV = 0x92A0;

		/// <summary>
		/// Value of GL_HARDLIGHT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int HARDLIGHT_NV = 0x929B;

		/// <summary>
		/// Value of GL_HARDMIX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int HARDMIX_NV = 0x92A9;

		/// <summary>
		/// Value of GL_HSL_COLOR_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int HSL_COLOR_NV = 0x92AF;

		/// <summary>
		/// Value of GL_HSL_HUE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int HSL_HUE_NV = 0x92AD;

		/// <summary>
		/// Value of GL_HSL_LUMINOSITY_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int HSL_LUMINOSITY_NV = 0x92B0;

		/// <summary>
		/// Value of GL_HSL_SATURATION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int HSL_SATURATION_NV = 0x92AE;

		/// <summary>
		/// Value of GL_INVERT_OVG_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int INVERT_OVG_NV = 0x92B4;

		/// <summary>
		/// Value of GL_INVERT_RGB_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int INVERT_RGB_NV = 0x92A3;

		/// <summary>
		/// Value of GL_LIGHTEN_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int LIGHTEN_NV = 0x9298;

		/// <summary>
		/// Value of GL_LINEARBURN_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int LINEARBURN_NV = 0x92A5;

		/// <summary>
		/// Value of GL_LINEARDODGE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int LINEARDODGE_NV = 0x92A4;

		/// <summary>
		/// Value of GL_LINEARLIGHT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int LINEARLIGHT_NV = 0x92A7;

		/// <summary>
		/// Value of GL_MINUS_CLAMPED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int MINUS_CLAMPED_NV = 0x92B3;

		/// <summary>
		/// Value of GL_MINUS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int MINUS_NV = 0x929F;

		/// <summary>
		/// Value of GL_MULTIPLY_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int MULTIPLY_NV = 0x9294;

		/// <summary>
		/// Value of GL_OVERLAY_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int OVERLAY_NV = 0x9296;

		/// <summary>
		/// Value of GL_PINLIGHT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int PINLIGHT_NV = 0x92A8;

		/// <summary>
		/// Value of GL_PLUS_CLAMPED_ALPHA_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int PLUS_CLAMPED_ALPHA_NV = 0x92B2;

		/// <summary>
		/// Value of GL_PLUS_CLAMPED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int PLUS_CLAMPED_NV = 0x92B1;

		/// <summary>
		/// Value of GL_PLUS_DARKER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int PLUS_DARKER_NV = 0x9292;

		/// <summary>
		/// Value of GL_PLUS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int PLUS_NV = 0x9291;

		/// <summary>
		/// Value of GL_SCREEN_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int SCREEN_NV = 0x9295;

		/// <summary>
		/// Value of GL_SOFTLIGHT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int SOFTLIGHT_NV = 0x929C;

		/// <summary>
		/// Value of GL_SRC_ATOP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int SRC_ATOP_NV = 0x928E;

		/// <summary>
		/// Value of GL_SRC_IN_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int SRC_IN_NV = 0x928A;

		/// <summary>
		/// Value of GL_SRC_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int SRC_NV = 0x9286;

		/// <summary>
		/// Value of GL_SRC_OUT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int SRC_OUT_NV = 0x928C;

		/// <summary>
		/// Value of GL_SRC_OVER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int SRC_OVER_NV = 0x9288;

		/// <summary>
		/// Value of GL_UNCORRELATED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int UNCORRELATED_NV = 0x9282;

		/// <summary>
		/// Value of GL_VIVIDLIGHT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int VIVIDLIGHT_NV = 0x92A6;

		/// <summary>
		/// Binding for glBlendParameteriNV.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public static void BlendParameterNV(Int32 pname, Int32 value)
		{
			Debug.Assert(Delegates.pglBlendParameteriNV != null, "pglBlendParameteriNV not implemented");
			Delegates.pglBlendParameteriNV(pname, value);
			LogFunction("glBlendParameteriNV({0}, {1})", LogEnumName(pname), value);
			DebugCheckErrors(null);
		}

	}

}
