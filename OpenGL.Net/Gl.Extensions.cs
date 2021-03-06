
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

using System;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Extension support listing.
		/// </summary>
		public partial class Extensions : ExtensionsCollection
		{
			/// <summary>
			/// Support for extension GL_ARB_multitexture.
			/// </summary>
			[Extension("GL_ARB_multitexture")]
			[ExtensionSupport("gl")]
			public bool Multitexture_ARB;

			/// <summary>
			/// Support for extension GL_ARB_transpose_matrix.
			/// </summary>
			[Extension("GL_ARB_transpose_matrix")]
			[ExtensionSupport("gl")]
			public bool TransposeMatrix_ARB;

			/// <summary>
			/// Support for extension GL_ARB_multisample.
			/// </summary>
			[Extension("GL_ARB_multisample")]
			[ExtensionSupport("gl")]
			public bool Multisample_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_env_add.
			/// </summary>
			[Extension("GL_ARB_texture_env_add")]
			[ExtensionSupport("gl")]
			public bool TextureEnvAdd_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_cube_map.
			/// </summary>
			[Extension("GL_ARB_texture_cube_map")]
			[ExtensionSupport("gl")]
			public bool TextureCubeMap_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_compression.
			/// </summary>
			[Extension("GL_ARB_texture_compression")]
			[ExtensionSupport("gl")]
			public bool TextureCompression_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_border_clamp.
			/// </summary>
			[Extension("GL_ARB_texture_border_clamp")]
			[ExtensionSupport("gl")]
			public bool TextureBorderClamp_ARB;

			/// <summary>
			/// Support for extension GL_ARB_point_parameters.
			/// </summary>
			[Extension("GL_ARB_point_parameters")]
			[ExtensionSupport("gl")]
			public bool PointParameters_ARB;

			/// <summary>
			/// Support for extension GL_ARB_vertex_blend.
			/// </summary>
			[Extension("GL_ARB_vertex_blend")]
			[ExtensionSupport("gl")]
			public bool VertexBlend_ARB;

			/// <summary>
			/// Support for extension GL_ARB_matrix_palette.
			/// </summary>
			[Extension("GL_ARB_matrix_palette")]
			[ExtensionSupport("gl")]
			public bool MatrixPalette_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_env_combine.
			/// </summary>
			[Extension("GL_ARB_texture_env_combine")]
			[ExtensionSupport("gl")]
			public bool TextureEnvCombine_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_env_crossbar.
			/// </summary>
			[Extension("GL_ARB_texture_env_crossbar")]
			[ExtensionSupport("gl")]
			public bool TextureEnvCrossbar_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_env_dot3.
			/// </summary>
			[Extension("GL_ARB_texture_env_dot3")]
			[ExtensionSupport("gl")]
			public bool TextureEnvDot3_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_mirrored_repeat.
			/// </summary>
			[Extension("GL_ARB_texture_mirrored_repeat")]
			[ExtensionSupport("gl")]
			public bool TextureMirroredRepeat_ARB;

			/// <summary>
			/// Support for extension GL_ARB_depth_texture.
			/// </summary>
			[Extension("GL_ARB_depth_texture")]
			[ExtensionSupport("gl")]
			public bool DepthTexture_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shadow.
			/// </summary>
			[Extension("GL_ARB_shadow")]
			[ExtensionSupport("gl")]
			public bool Shadow_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shadow_ambient.
			/// </summary>
			[Extension("GL_ARB_shadow_ambient")]
			[ExtensionSupport("gl")]
			public bool ShadowAmbient_ARB;

			/// <summary>
			/// Support for extension GL_ARB_window_pos.
			/// </summary>
			[Extension("GL_ARB_window_pos")]
			[ExtensionSupport("gl")]
			public bool WindowPos_ARB;

			/// <summary>
			/// Support for extension GL_ARB_vertex_program.
			/// </summary>
			[Extension("GL_ARB_vertex_program")]
			[ExtensionSupport("gl")]
			public bool VertexProgram_ARB;

			/// <summary>
			/// Support for extension GL_ARB_fragment_program.
			/// </summary>
			[Extension("GL_ARB_fragment_program")]
			[ExtensionSupport("gl")]
			public bool FragmentProgram_ARB;

			/// <summary>
			/// Support for extension GL_ARB_vertex_buffer_object.
			/// </summary>
			[Extension("GL_ARB_vertex_buffer_object")]
			[ExtensionSupport("gl")]
			public bool VertexBufferObject_ARB;

			/// <summary>
			/// Support for extension GL_ARB_occlusion_query.
			/// </summary>
			[Extension("GL_ARB_occlusion_query")]
			[ExtensionSupport("gl")]
			public bool OcclusionQuery_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shader_objects.
			/// </summary>
			[Extension("GL_ARB_shader_objects")]
			[ExtensionSupport("gl")]
			public bool ShaderObjects_ARB;

			/// <summary>
			/// Support for extension GL_ARB_vertex_shader.
			/// </summary>
			[Extension("GL_ARB_vertex_shader")]
			[ExtensionSupport("gl")]
			public bool VertexShader_ARB;

			/// <summary>
			/// Support for extension GL_ARB_fragment_shader.
			/// </summary>
			[Extension("GL_ARB_fragment_shader")]
			[ExtensionSupport("gl")]
			public bool FragmentShader_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shading_language_100.
			/// </summary>
			[Extension("GL_ARB_shading_language_100")]
			[ExtensionSupport("gl")]
			public bool ShadingLanguage100_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_non_power_of_two.
			/// </summary>
			[Extension("GL_ARB_texture_non_power_of_two")]
			[ExtensionSupport("gl")]
			public bool TextureNonPowerOfTwo_ARB;

			/// <summary>
			/// Support for extension GL_ARB_point_sprite.
			/// </summary>
			[Extension("GL_ARB_point_sprite")]
			[ExtensionSupport("gl")]
			public bool PointSprite_ARB;

			/// <summary>
			/// Support for extension GL_ARB_fragment_program_shadow.
			/// </summary>
			[Extension("GL_ARB_fragment_program_shadow")]
			[ExtensionSupport("gl")]
			public bool FragmentProgramShadow_ARB;

			/// <summary>
			/// Support for extension GL_ARB_draw_buffers.
			/// </summary>
			[Extension("GL_ARB_draw_buffers")]
			[ExtensionSupport("gl")]
			public bool DrawBuffers_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_rectangle.
			/// </summary>
			[Extension("GL_ARB_texture_rectangle")]
			[ExtensionSupport("gl")]
			public bool TextureRectangle_ARB;

			/// <summary>
			/// Support for extension GL_ARB_color_buffer_float.
			/// </summary>
			[Extension("GL_ARB_color_buffer_float")]
			[ExtensionSupport("gl")]
			public bool ColorBufferFloat_ARB;

			/// <summary>
			/// Support for extension GL_ARB_half_float_pixel.
			/// </summary>
			[Extension("GL_ARB_half_float_pixel")]
			[ExtensionSupport("gl")]
			public bool HalfFloatPixel_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_float.
			/// </summary>
			[Extension("GL_ARB_texture_float")]
			[ExtensionSupport("gl")]
			public bool TextureFloat_ARB;

			/// <summary>
			/// Support for extension GL_ARB_pixel_buffer_object.
			/// </summary>
			[Extension("GL_ARB_pixel_buffer_object")]
			[ExtensionSupport("gl")]
			public bool PixelBufferObject_ARB;

			/// <summary>
			/// Support for extension GL_ARB_depth_buffer_float.
			/// </summary>
			[Extension("GL_ARB_depth_buffer_float")]
			[ExtensionSupport("gl|glcore")]
			public bool DepthBufferFloat_ARB;

			/// <summary>
			/// Support for extension GL_ARB_draw_instanced.
			/// </summary>
			[Extension("GL_ARB_draw_instanced")]
			[ExtensionSupport("gl")]
			public bool DrawInstanced_ARB;

			/// <summary>
			/// Support for extension GL_ARB_framebuffer_object.
			/// </summary>
			[Extension("GL_ARB_framebuffer_object")]
			[ExtensionSupport("gl|glcore")]
			public bool FramebufferObject_ARB;

			/// <summary>
			/// Support for extension GL_ARB_framebuffer_sRGB.
			/// </summary>
			[Extension("GL_ARB_framebuffer_sRGB")]
			[ExtensionSupport("gl|glcore")]
			public bool FramebufferSRGB_ARB;

			/// <summary>
			/// Support for extension GL_ARB_geometry_shader4.
			/// </summary>
			[Extension("GL_ARB_geometry_shader4")]
			[ExtensionSupport("gl")]
			public bool GeometryShader4_ARB;

			/// <summary>
			/// Support for extension GL_ARB_half_float_vertex.
			/// </summary>
			[Extension("GL_ARB_half_float_vertex")]
			[ExtensionSupport("gl|glcore")]
			public bool HalfFloatVertex_ARB;

			/// <summary>
			/// Support for extension GL_ARB_instanced_arrays.
			/// </summary>
			[Extension("GL_ARB_instanced_arrays")]
			[ExtensionSupport("gl")]
			public bool InstancedArrays_ARB;

			/// <summary>
			/// Support for extension GL_ARB_map_buffer_range.
			/// </summary>
			[Extension("GL_ARB_map_buffer_range")]
			[ExtensionSupport("gl|glcore")]
			public bool MapBufferRange_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_buffer_object.
			/// </summary>
			[Extension("GL_ARB_texture_buffer_object")]
			[ExtensionSupport("gl")]
			public bool TextureBufferObject_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_compression_rgtc.
			/// </summary>
			[Extension("GL_ARB_texture_compression_rgtc")]
			[ExtensionSupport("gl|glcore")]
			public bool TextureCompressionRgtc_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_rg.
			/// </summary>
			[Extension("GL_ARB_texture_rg")]
			[ExtensionSupport("gl|glcore")]
			public bool TextureRg_ARB;

			/// <summary>
			/// Support for extension GL_ARB_vertex_array_object.
			/// </summary>
			[Extension("GL_ARB_vertex_array_object")]
			[ExtensionSupport("gl|glcore")]
			public bool VertexArrayObject_ARB;

			/// <summary>
			/// Support for extension GL_ARB_uniform_buffer_object.
			/// </summary>
			[Extension("GL_ARB_uniform_buffer_object")]
			[ExtensionSupport("gl|glcore")]
			public bool UniformBufferObject_ARB;

			/// <summary>
			/// Support for extension GL_ARB_compatibility.
			/// </summary>
			[Extension("GL_ARB_compatibility")]
			[ExtensionSupport("gl")]
			public bool Compatibility_ARB;

			/// <summary>
			/// Support for extension GL_ARB_copy_buffer.
			/// </summary>
			[Extension("GL_ARB_copy_buffer")]
			[ExtensionSupport("gl|glcore")]
			public bool CopyBuffer_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shader_texture_lod.
			/// </summary>
			[Extension("GL_ARB_shader_texture_lod")]
			[ExtensionSupport("gl")]
			public bool ShaderTextureLod_ARB;

			/// <summary>
			/// Support for extension GL_ARB_depth_clamp.
			/// </summary>
			[Extension("GL_ARB_depth_clamp")]
			[ExtensionSupport("gl|glcore")]
			public bool DepthClamp_ARB;

			/// <summary>
			/// Support for extension GL_ARB_draw_elements_base_vertex.
			/// </summary>
			[Extension("GL_ARB_draw_elements_base_vertex")]
			[ExtensionSupport("gl|glcore")]
			public bool DrawElementsBaseVertex_ARB;

			/// <summary>
			/// Support for extension GL_ARB_fragment_coord_conventions.
			/// </summary>
			[Extension("GL_ARB_fragment_coord_conventions")]
			[ExtensionSupport("gl|glcore")]
			public bool FragmentCoordConventions_ARB;

			/// <summary>
			/// Support for extension GL_ARB_provoking_vertex.
			/// </summary>
			[Extension("GL_ARB_provoking_vertex")]
			[ExtensionSupport("gl|glcore")]
			public bool ProvokingVertex_ARB;

			/// <summary>
			/// Support for extension GL_ARB_seamless_cube_map.
			/// </summary>
			[Extension("GL_ARB_seamless_cube_map")]
			[ExtensionSupport("gl|glcore")]
			public bool SeamlessCubeMap_ARB;

			/// <summary>
			/// Support for extension GL_ARB_sync.
			/// </summary>
			[Extension("GL_ARB_sync")]
			[ExtensionSupport("gl|glcore")]
			public bool Sync_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_multisample.
			/// </summary>
			[Extension("GL_ARB_texture_multisample")]
			[ExtensionSupport("gl|glcore")]
			public bool TextureMultisample_ARB;

			/// <summary>
			/// Support for extension GL_ARB_vertex_array_bgra.
			/// </summary>
			[Extension("GL_ARB_vertex_array_bgra")]
			[ExtensionSupport("gl|glcore")]
			public bool VertexArrayBgra_ARB;

			/// <summary>
			/// Support for extension GL_ARB_draw_buffers_blend.
			/// </summary>
			[Extension("GL_ARB_draw_buffers_blend")]
			[ExtensionSupport("gl|glcore")]
			public bool DrawBuffersBlend_ARB;

			/// <summary>
			/// Support for extension GL_ARB_sample_shading.
			/// </summary>
			[Extension("GL_ARB_sample_shading")]
			[ExtensionSupport("gl|glcore")]
			public bool SampleShading_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_cube_map_array.
			/// </summary>
			[Extension("GL_ARB_texture_cube_map_array")]
			[ExtensionSupport("gl|glcore")]
			public bool TextureCubeMapArray_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_gather.
			/// </summary>
			[Extension("GL_ARB_texture_gather")]
			[ExtensionSupport("gl|glcore")]
			public bool TextureGather_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_query_lod.
			/// </summary>
			[Extension("GL_ARB_texture_query_lod")]
			[ExtensionSupport("gl|glcore")]
			public bool TextureQueryLod_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shading_language_include.
			/// </summary>
			[Extension("GL_ARB_shading_language_include")]
			[ExtensionSupport("gl|glcore")]
			public bool ShadingLanguageInclude_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_compression_bptc.
			/// </summary>
			[Extension("GL_ARB_texture_compression_bptc")]
			[ExtensionSupport("gl|glcore")]
			public bool TextureCompressionBptc_ARB;

			/// <summary>
			/// Support for extension GL_ARB_blend_func_extended.
			/// </summary>
			[Extension("GL_ARB_blend_func_extended")]
			[ExtensionSupport("gl|glcore")]
			public bool BlendFuncExtended_ARB;

			/// <summary>
			/// Support for extension GL_ARB_explicit_attrib_location.
			/// </summary>
			[Extension("GL_ARB_explicit_attrib_location")]
			[ExtensionSupport("gl|glcore")]
			public bool ExplicitAttribLocation_ARB;

			/// <summary>
			/// Support for extension GL_ARB_occlusion_query2.
			/// </summary>
			[Extension("GL_ARB_occlusion_query2")]
			[ExtensionSupport("gl|glcore")]
			public bool OcclusionQuery2_ARB;

			/// <summary>
			/// Support for extension GL_ARB_sampler_objects.
			/// </summary>
			[Extension("GL_ARB_sampler_objects")]
			[ExtensionSupport("gl|glcore")]
			public bool SamplerObjects_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shader_bit_encoding.
			/// </summary>
			[Extension("GL_ARB_shader_bit_encoding")]
			[ExtensionSupport("gl|glcore")]
			public bool ShaderBitEncoding_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_rgb10_a2ui.
			/// </summary>
			[Extension("GL_ARB_texture_rgb10_a2ui")]
			[ExtensionSupport("gl|glcore")]
			public bool TextureRgb10A2ui_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_swizzle.
			/// </summary>
			[Extension("GL_ARB_texture_swizzle")]
			[ExtensionSupport("gl|glcore")]
			public bool TextureSwizzle_ARB;

			/// <summary>
			/// Support for extension GL_ARB_timer_query.
			/// </summary>
			[Extension("GL_ARB_timer_query")]
			[ExtensionSupport("gl|glcore")]
			public bool TimerQuery_ARB;

			/// <summary>
			/// Support for extension GL_ARB_vertex_type_2_10_10_10_rev.
			/// </summary>
			[Extension("GL_ARB_vertex_type_2_10_10_10_rev")]
			[ExtensionSupport("gl|glcore")]
			public bool VertexType2101010Rev_ARB;

			/// <summary>
			/// Support for extension GL_ARB_draw_indirect.
			/// </summary>
			[Extension("GL_ARB_draw_indirect")]
			[ExtensionSupport("gl|glcore")]
			public bool DrawIndirect_ARB;

			/// <summary>
			/// Support for extension GL_ARB_gpu_shader5.
			/// </summary>
			[Extension("GL_ARB_gpu_shader5")]
			[ExtensionSupport("gl|glcore")]
			public bool GpuShader5_ARB;

			/// <summary>
			/// Support for extension GL_ARB_gpu_shader_fp64.
			/// </summary>
			[Extension("GL_ARB_gpu_shader_fp64")]
			[ExtensionSupport("gl|glcore")]
			public bool GpuShaderFp64_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shader_subroutine.
			/// </summary>
			[Extension("GL_ARB_shader_subroutine")]
			[ExtensionSupport("gl|glcore")]
			public bool ShaderSubroutine_ARB;

			/// <summary>
			/// Support for extension GL_ARB_tessellation_shader.
			/// </summary>
			[Extension("GL_ARB_tessellation_shader")]
			[ExtensionSupport("gl|glcore")]
			public bool TessellationShader_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_buffer_object_rgb32.
			/// </summary>
			[Extension("GL_ARB_texture_buffer_object_rgb32")]
			[ExtensionSupport("gl|glcore")]
			public bool TextureBufferObjectRgb32_ARB;

			/// <summary>
			/// Support for extension GL_ARB_transform_feedback2.
			/// </summary>
			[Extension("GL_ARB_transform_feedback2")]
			[ExtensionSupport("gl|glcore")]
			public bool TransformFeedback2_ARB;

			/// <summary>
			/// Support for extension GL_ARB_transform_feedback3.
			/// </summary>
			[Extension("GL_ARB_transform_feedback3")]
			[ExtensionSupport("gl|glcore")]
			public bool TransformFeedback3_ARB;

			/// <summary>
			/// Support for extension GL_ARB_ES2_compatibility.
			/// </summary>
			[Extension("GL_ARB_ES2_compatibility")]
			[ExtensionSupport("gl|glcore")]
			public bool ES2Compatibility_ARB;

			/// <summary>
			/// Support for extension GL_ARB_get_program_binary.
			/// </summary>
			[Extension("GL_ARB_get_program_binary")]
			[ExtensionSupport("gl|glcore")]
			public bool GetProgramBinary_ARB;

			/// <summary>
			/// Support for extension GL_ARB_separate_shader_objects.
			/// </summary>
			[Extension("GL_ARB_separate_shader_objects")]
			[ExtensionSupport("gl|glcore")]
			public bool SeparateShaderObjects_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shader_precision.
			/// </summary>
			[Extension("GL_ARB_shader_precision")]
			[ExtensionSupport("gl|glcore")]
			public bool ShaderPrecision_ARB;

			/// <summary>
			/// Support for extension GL_ARB_vertex_attrib_64bit.
			/// </summary>
			[Extension("GL_ARB_vertex_attrib_64bit")]
			[ExtensionSupport("gl|glcore")]
			public bool VertexAttrib64bit_ARB;

			/// <summary>
			/// Support for extension GL_ARB_viewport_array.
			/// </summary>
			[Extension("GL_ARB_viewport_array")]
			[ExtensionSupport("gl|glcore")]
			public bool ViewportArray_ARB;

			/// <summary>
			/// Support for extension GL_ARB_cl_event.
			/// </summary>
			[Extension("GL_ARB_cl_event")]
			[ExtensionSupport("gl|glcore")]
			public bool ClEvent_ARB;

			/// <summary>
			/// Support for extension GL_ARB_debug_output.
			/// </summary>
			[Extension("GL_ARB_debug_output")]
			[ExtensionSupport("gl|glcore")]
			public bool DebugOutput_ARB;

			/// <summary>
			/// Support for extension GL_ARB_robustness.
			/// </summary>
			[Extension("GL_ARB_robustness")]
			[ExtensionSupport("gl|glcore")]
			public bool Robustness_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shader_stencil_export.
			/// </summary>
			[Extension("GL_ARB_shader_stencil_export")]
			[ExtensionSupport("gl|glcore")]
			public bool ShaderStencilExport_ARB;

			/// <summary>
			/// Support for extension GL_ARB_base_instance.
			/// </summary>
			[Extension("GL_ARB_base_instance")]
			[ExtensionSupport("gl|glcore")]
			public bool BaseInstance_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shading_language_420pack.
			/// </summary>
			[Extension("GL_ARB_shading_language_420pack")]
			[ExtensionSupport("gl|glcore")]
			public bool ShadingLanguage420pack_ARB;

			/// <summary>
			/// Support for extension GL_ARB_transform_feedback_instanced.
			/// </summary>
			[Extension("GL_ARB_transform_feedback_instanced")]
			[ExtensionSupport("gl|glcore")]
			public bool TransformFeedbackInstanced_ARB;

			/// <summary>
			/// Support for extension GL_ARB_compressed_texture_pixel_storage.
			/// </summary>
			[Extension("GL_ARB_compressed_texture_pixel_storage")]
			[ExtensionSupport("gl|glcore")]
			public bool CompressedTexturePixelStorage_ARB;

			/// <summary>
			/// Support for extension GL_ARB_conservative_depth.
			/// </summary>
			[Extension("GL_ARB_conservative_depth")]
			[ExtensionSupport("gl|glcore")]
			public bool ConservativeDepth_ARB;

			/// <summary>
			/// Support for extension GL_ARB_internalformat_query.
			/// </summary>
			[Extension("GL_ARB_internalformat_query")]
			[ExtensionSupport("gl|glcore")]
			public bool InternalformatQuery_ARB;

			/// <summary>
			/// Support for extension GL_ARB_map_buffer_alignment.
			/// </summary>
			[Extension("GL_ARB_map_buffer_alignment")]
			[ExtensionSupport("gl|glcore")]
			public bool MapBufferAlignment_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shader_atomic_counters.
			/// </summary>
			[Extension("GL_ARB_shader_atomic_counters")]
			[ExtensionSupport("gl|glcore")]
			public bool ShaderAtomicCounters_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shader_image_load_store.
			/// </summary>
			[Extension("GL_ARB_shader_image_load_store")]
			[ExtensionSupport("gl|glcore")]
			public bool ShaderImageLoadStore_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shading_language_packing.
			/// </summary>
			[Extension("GL_ARB_shading_language_packing")]
			[ExtensionSupport("gl|glcore")]
			public bool ShadingLanguagePacking_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_storage.
			/// </summary>
			[Extension("GL_ARB_texture_storage")]
			[ExtensionSupport("gl|glcore")]
			public bool TextureStorage_ARB;

			/// <summary>
			/// Support for extension GL_KHR_texture_compression_astc_hdr.
			/// </summary>
			[Extension("GL_KHR_texture_compression_astc_hdr")]
			[Extension("GL_KHR_texture_compression_astc_ldr")]
			[ExtensionSupport("gl|glcore|gles2")]
			public bool TextureCompressionAstcHdr_KHR;

			/// <summary>
			/// Support for extension GL_KHR_debug.
			/// </summary>
			[Extension("GL_KHR_debug")]
			[ExtensionSupport("gl|glcore|gles2")]
			public bool Debug_KHR;

			/// <summary>
			/// Support for extension GL_ARB_arrays_of_arrays.
			/// </summary>
			[Extension("GL_ARB_arrays_of_arrays")]
			[ExtensionSupport("gl|glcore")]
			public bool ArraysOfArrays_ARB;

			/// <summary>
			/// Support for extension GL_ARB_clear_buffer_object.
			/// </summary>
			[Extension("GL_ARB_clear_buffer_object")]
			[ExtensionSupport("gl|glcore")]
			public bool ClearBufferObject_ARB;

			/// <summary>
			/// Support for extension GL_ARB_compute_shader.
			/// </summary>
			[Extension("GL_ARB_compute_shader")]
			[ExtensionSupport("gl|glcore")]
			public bool ComputeShader_ARB;

			/// <summary>
			/// Support for extension GL_ARB_copy_image.
			/// </summary>
			[Extension("GL_ARB_copy_image")]
			[ExtensionSupport("gl|glcore")]
			public bool CopyImage_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_view.
			/// </summary>
			[Extension("GL_ARB_texture_view")]
			[ExtensionSupport("gl|glcore")]
			public bool TextureView_ARB;

			/// <summary>
			/// Support for extension GL_ARB_vertex_attrib_binding.
			/// </summary>
			[Extension("GL_ARB_vertex_attrib_binding")]
			[ExtensionSupport("gl|glcore")]
			public bool VertexAttribBinding_ARB;

			/// <summary>
			/// Support for extension GL_ARB_robustness_isolation.
			/// </summary>
			[Extension("GL_ARB_robustness_isolation")]
			[ExtensionSupport("gl|glcore")]
			public bool RobustnessIsolation_ARB;

			/// <summary>
			/// Support for extension GL_ARB_ES3_compatibility.
			/// </summary>
			[Extension("GL_ARB_ES3_compatibility")]
			[ExtensionSupport("gl|glcore")]
			public bool ES3Compatibility_ARB;

			/// <summary>
			/// Support for extension GL_ARB_explicit_uniform_location.
			/// </summary>
			[Extension("GL_ARB_explicit_uniform_location")]
			[ExtensionSupport("gl|glcore")]
			public bool ExplicitUniformLocation_ARB;

			/// <summary>
			/// Support for extension GL_ARB_fragment_layer_viewport.
			/// </summary>
			[Extension("GL_ARB_fragment_layer_viewport")]
			[ExtensionSupport("gl|glcore")]
			public bool FragmentLayerViewport_ARB;

			/// <summary>
			/// Support for extension GL_ARB_framebuffer_no_attachments.
			/// </summary>
			[Extension("GL_ARB_framebuffer_no_attachments")]
			[ExtensionSupport("gl|glcore")]
			public bool FramebufferNoAttachments_ARB;

			/// <summary>
			/// Support for extension GL_ARB_internalformat_query2.
			/// </summary>
			[Extension("GL_ARB_internalformat_query2")]
			[ExtensionSupport("gl|glcore")]
			public bool InternalformatQuery2_ARB;

			/// <summary>
			/// Support for extension GL_ARB_invalidate_subdata.
			/// </summary>
			[Extension("GL_ARB_invalidate_subdata")]
			[ExtensionSupport("gl|glcore")]
			public bool InvalidateSubdata_ARB;

			/// <summary>
			/// Support for extension GL_ARB_multi_draw_indirect.
			/// </summary>
			[Extension("GL_ARB_multi_draw_indirect")]
			[ExtensionSupport("gl|glcore")]
			public bool MultiDrawIndirect_ARB;

			/// <summary>
			/// Support for extension GL_ARB_program_interface_query.
			/// </summary>
			[Extension("GL_ARB_program_interface_query")]
			[ExtensionSupport("gl|glcore")]
			public bool ProgramInterfaceQuery_ARB;

			/// <summary>
			/// Support for extension GL_ARB_robust_buffer_access_behavior.
			/// </summary>
			[Extension("GL_ARB_robust_buffer_access_behavior")]
			[ExtensionSupport("gl|glcore")]
			public bool RobustBufferAccessBehavior_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shader_image_size.
			/// </summary>
			[Extension("GL_ARB_shader_image_size")]
			[ExtensionSupport("gl|glcore")]
			public bool ShaderImageSize_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shader_storage_buffer_object.
			/// </summary>
			[Extension("GL_ARB_shader_storage_buffer_object")]
			[ExtensionSupport("gl|glcore")]
			public bool ShaderStorageBufferObject_ARB;

			/// <summary>
			/// Support for extension GL_ARB_stencil_texturing.
			/// </summary>
			[Extension("GL_ARB_stencil_texturing")]
			[ExtensionSupport("gl|glcore")]
			public bool StencilTexturing_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_buffer_range.
			/// </summary>
			[Extension("GL_ARB_texture_buffer_range")]
			[ExtensionSupport("gl|glcore")]
			public bool TextureBufferRange_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_query_levels.
			/// </summary>
			[Extension("GL_ARB_texture_query_levels")]
			[ExtensionSupport("gl|glcore")]
			public bool TextureQueryLevels_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_storage_multisample.
			/// </summary>
			[Extension("GL_ARB_texture_storage_multisample")]
			[ExtensionSupport("gl|glcore")]
			public bool TextureStorageMultisample_ARB;

			/// <summary>
			/// Support for extension GL_ARB_buffer_storage.
			/// </summary>
			[Extension("GL_ARB_buffer_storage")]
			[ExtensionSupport("gl|glcore")]
			public bool BufferStorage_ARB;

			/// <summary>
			/// Support for extension GL_ARB_clear_texture.
			/// </summary>
			[Extension("GL_ARB_clear_texture")]
			[ExtensionSupport("gl|glcore")]
			public bool ClearTexture_ARB;

			/// <summary>
			/// Support for extension GL_ARB_enhanced_layouts.
			/// </summary>
			[Extension("GL_ARB_enhanced_layouts")]
			[ExtensionSupport("gl|glcore")]
			public bool EnhancedLayouts_ARB;

			/// <summary>
			/// Support for extension GL_ARB_multi_bind.
			/// </summary>
			[Extension("GL_ARB_multi_bind")]
			[ExtensionSupport("gl|glcore")]
			public bool MultiBind_ARB;

			/// <summary>
			/// Support for extension GL_ARB_query_buffer_object.
			/// </summary>
			[Extension("GL_ARB_query_buffer_object")]
			[ExtensionSupport("gl|glcore")]
			public bool QueryBufferObject_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_mirror_clamp_to_edge.
			/// </summary>
			[Extension("GL_ARB_texture_mirror_clamp_to_edge")]
			[ExtensionSupport("gl|glcore")]
			public bool TextureMirrorClampToEdge_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_stencil8.
			/// </summary>
			[Extension("GL_ARB_texture_stencil8")]
			[ExtensionSupport("gl|glcore")]
			public bool TextureStencil8_ARB;

			/// <summary>
			/// Support for extension GL_ARB_vertex_type_10f_11f_11f_rev.
			/// </summary>
			[Extension("GL_ARB_vertex_type_10f_11f_11f_rev")]
			[ExtensionSupport("gl|glcore")]
			public bool VertexType10f11f11fRev_ARB;

			/// <summary>
			/// Support for extension GL_ARB_bindless_texture.
			/// </summary>
			[Extension("GL_ARB_bindless_texture")]
			[ExtensionSupport("gl|glcore")]
			public bool BindlessTexture_ARB;

			/// <summary>
			/// Support for extension GL_ARB_compute_variable_group_size.
			/// </summary>
			[Extension("GL_ARB_compute_variable_group_size")]
			[ExtensionSupport("gl|glcore")]
			public bool ComputeVariableGroupSize_ARB;

			/// <summary>
			/// Support for extension GL_ARB_indirect_parameters.
			/// </summary>
			[Extension("GL_ARB_indirect_parameters")]
			[ExtensionSupport("gl|glcore")]
			public bool IndirectParameters_ARB;

			/// <summary>
			/// Support for extension GL_ARB_seamless_cubemap_per_texture.
			/// </summary>
			[Extension("GL_ARB_seamless_cubemap_per_texture")]
			[ExtensionSupport("gl|glcore")]
			public bool SeamlessCubemapPerTexture_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shader_draw_parameters.
			/// </summary>
			[Extension("GL_ARB_shader_draw_parameters")]
			[ExtensionSupport("gl|glcore")]
			public bool ShaderDrawParameters_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shader_group_vote.
			/// </summary>
			[Extension("GL_ARB_shader_group_vote")]
			[ExtensionSupport("gl|glcore")]
			public bool ShaderGroupVote_ARB;

			/// <summary>
			/// Support for extension GL_ARB_sparse_texture.
			/// </summary>
			[Extension("GL_ARB_sparse_texture")]
			[ExtensionSupport("gl|glcore")]
			public bool SparseTexture_ARB;

			/// <summary>
			/// Support for extension GL_ARB_ES3_1_compatibility.
			/// </summary>
			[Extension("GL_ARB_ES3_1_compatibility")]
			[ExtensionSupport("gl|glcore")]
			public bool ES31Compatibility_ARB;

			/// <summary>
			/// Support for extension GL_ARB_clip_control.
			/// </summary>
			[Extension("GL_ARB_clip_control")]
			[ExtensionSupport("gl|glcore")]
			public bool ClipControl_ARB;

			/// <summary>
			/// Support for extension GL_ARB_conditional_render_inverted.
			/// </summary>
			[Extension("GL_ARB_conditional_render_inverted")]
			[ExtensionSupport("gl|glcore")]
			public bool ConditionalRenderInverted_ARB;

			/// <summary>
			/// Support for extension GL_ARB_cull_distance.
			/// </summary>
			[Extension("GL_ARB_cull_distance")]
			[ExtensionSupport("gl|glcore")]
			public bool CullDistance_ARB;

			/// <summary>
			/// Support for extension GL_ARB_derivative_control.
			/// </summary>
			[Extension("GL_ARB_derivative_control")]
			[ExtensionSupport("gl|glcore")]
			public bool DerivativeControl_ARB;

			/// <summary>
			/// Support for extension GL_ARB_direct_state_access.
			/// </summary>
			[Extension("GL_ARB_direct_state_access")]
			[ExtensionSupport("gl|glcore")]
			public bool DirectStateAccess_ARB;

			/// <summary>
			/// Support for extension GL_ARB_get_texture_sub_image.
			/// </summary>
			[Extension("GL_ARB_get_texture_sub_image")]
			[ExtensionSupport("gl|glcore")]
			public bool GetTextureSubImage_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shader_texture_image_samples.
			/// </summary>
			[Extension("GL_ARB_shader_texture_image_samples")]
			[ExtensionSupport("gl|glcore")]
			public bool ShaderTextureImageSamples_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_barrier.
			/// </summary>
			[Extension("GL_ARB_texture_barrier")]
			[ExtensionSupport("gl|glcore")]
			public bool TextureBarrier_ARB;

			/// <summary>
			/// Support for extension GL_KHR_context_flush_control.
			/// </summary>
			[Extension("GL_KHR_context_flush_control")]
			[ExtensionSupport("gl|glcore|gles2")]
			public bool ContextFlushControl_KHR;

			/// <summary>
			/// Support for extension GL_KHR_robust_buffer_access_behavior.
			/// </summary>
			[Extension("GL_KHR_robust_buffer_access_behavior")]
			[ExtensionSupport("gl|glcore|gles2")]
			public bool RobustBufferAccessBehavior_KHR;

			/// <summary>
			/// Support for extension GL_KHR_robustness.
			/// </summary>
			[Extension("GL_KHR_robustness")]
			[ExtensionSupport("gl|glcore|gles2")]
			public bool Robustness_KHR;

			/// <summary>
			/// Support for extension GL_ARB_pipeline_statistics_query.
			/// </summary>
			[Extension("GL_ARB_pipeline_statistics_query")]
			[ExtensionSupport("gl|glcore")]
			public bool PipelineStatisticsQuery_ARB;

			/// <summary>
			/// Support for extension GL_ARB_sparse_buffer.
			/// </summary>
			[Extension("GL_ARB_sparse_buffer")]
			[ExtensionSupport("gl|glcore")]
			public bool SparseBuffer_ARB;

			/// <summary>
			/// Support for extension GL_ARB_transform_feedback_overflow_query.
			/// </summary>
			[Extension("GL_ARB_transform_feedback_overflow_query")]
			[ExtensionSupport("gl|glcore")]
			public bool TransformFeedbackOverflowQuery_ARB;

			/// <summary>
			/// Support for extension GL_KHR_blend_equation_advanced.
			/// </summary>
			[Extension("GL_KHR_blend_equation_advanced")]
			[Extension("GL_KHR_blend_equation_advanced_coherent")]
			[ExtensionSupport("gl|gles2")]
			public bool BlendEquationAdvanced_KHR;

			/// <summary>
			/// Support for extension GL_KHR_texture_compression_astc_sliced_3d.
			/// </summary>
			[Extension("GL_KHR_texture_compression_astc_sliced_3d")]
			[ExtensionSupport("gl|glcore|gles2")]
			public bool TextureCompressionAstcSliced3d_KHR;

			/// <summary>
			/// Support for extension GL_KHR_no_error.
			/// </summary>
			[Extension("GL_KHR_no_error")]
			[ExtensionSupport("gl|glcore|gles2")]
			public bool NoError_KHR;

			/// <summary>
			/// Support for extension GL_ARB_ES3_2_compatibility.
			/// </summary>
			[Extension("GL_ARB_ES3_2_compatibility")]
			[ExtensionSupport("gl")]
			public bool ES32Compatibility_ARB;

			/// <summary>
			/// Support for extension GL_ARB_fragment_shader_interlock.
			/// </summary>
			[Extension("GL_ARB_fragment_shader_interlock")]
			[ExtensionSupport("gl")]
			public bool FragmentShaderInterlock_ARB;

			/// <summary>
			/// Support for extension GL_ARB_gpu_shader_int64.
			/// </summary>
			[Extension("GL_ARB_gpu_shader_int64")]
			[ExtensionSupport("gl")]
			public bool GpuShaderInt64_ARB;

			/// <summary>
			/// Support for extension GL_ARB_imaging.
			/// </summary>
			[Extension("GL_ARB_imaging")]
			[ExtensionSupport("gl|glcore")]
			public bool Imaging_ARB;

			/// <summary>
			/// Support for extension GL_ARB_parallel_shader_compile.
			/// </summary>
			[Extension("GL_ARB_parallel_shader_compile")]
			[ExtensionSupport("gl")]
			public bool ParallelShaderCompile_ARB;

			/// <summary>
			/// Support for extension GL_ARB_post_depth_coverage.
			/// </summary>
			[Extension("GL_ARB_post_depth_coverage")]
			[ExtensionSupport("gl")]
			public bool PostDepthCoverage_ARB;

			/// <summary>
			/// Support for extension GL_ARB_sample_locations.
			/// </summary>
			[Extension("GL_ARB_sample_locations")]
			[ExtensionSupport("gl")]
			public bool SampleLocations_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shader_atomic_counter_ops.
			/// </summary>
			[Extension("GL_ARB_shader_atomic_counter_ops")]
			[ExtensionSupport("gl")]
			public bool ShaderAtomicCounterOps_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shader_ballot.
			/// </summary>
			[Extension("GL_ARB_shader_ballot")]
			[ExtensionSupport("gl")]
			public bool ShaderBallot_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shader_clock.
			/// </summary>
			[Extension("GL_ARB_shader_clock")]
			[ExtensionSupport("gl")]
			public bool ShaderClock_ARB;

			/// <summary>
			/// Support for extension GL_ARB_shader_viewport_layer_array.
			/// </summary>
			[Extension("GL_ARB_shader_viewport_layer_array")]
			[ExtensionSupport("gl")]
			public bool ShaderViewportLayerArray_ARB;

			/// <summary>
			/// Support for extension GL_ARB_sparse_texture2.
			/// </summary>
			[Extension("GL_ARB_sparse_texture2")]
			[ExtensionSupport("gl")]
			public bool SparseTexture2_ARB;

			/// <summary>
			/// Support for extension GL_ARB_sparse_texture_clamp.
			/// </summary>
			[Extension("GL_ARB_sparse_texture_clamp")]
			[ExtensionSupport("gl")]
			public bool SparseTextureClamp_ARB;

			/// <summary>
			/// Support for extension GL_ARB_texture_filter_minmax.
			/// </summary>
			[Extension("GL_ARB_texture_filter_minmax")]
			[ExtensionSupport("gl")]
			public bool TextureFilterMinmax_ARB;

			/// <summary>
			/// Support for extension GL_EXT_abgr.
			/// </summary>
			[Extension("GL_EXT_abgr")]
			public bool Abgr_EXT;

			/// <summary>
			/// Support for extension GL_EXT_blend_color.
			/// </summary>
			[Extension("GL_EXT_blend_color")]
			public bool BlendColor_EXT;

			/// <summary>
			/// Support for extension GL_EXT_polygon_offset.
			/// </summary>
			[Extension("GL_EXT_polygon_offset")]
			public bool PolygonOffset_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture.
			/// </summary>
			[Extension("GL_EXT_texture")]
			public bool Texture_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture3D.
			/// </summary>
			[Extension("GL_EXT_texture3D")]
			public bool Texture3D_EXT;

			/// <summary>
			/// Support for extension GL_SGIS_texture_filter4.
			/// </summary>
			[Extension("GL_SGIS_texture_filter4")]
			public bool TextureFilter4_SGIS;

			/// <summary>
			/// Support for extension GL_EXT_subtexture.
			/// </summary>
			[Extension("GL_EXT_subtexture")]
			public bool Subtexture_EXT;

			/// <summary>
			/// Support for extension GL_EXT_copy_texture.
			/// </summary>
			[Extension("GL_EXT_copy_texture")]
			public bool CopyTexture_EXT;

			/// <summary>
			/// Support for extension GL_EXT_histogram.
			/// </summary>
			[Extension("GL_EXT_histogram")]
			public bool Histogram_EXT;

			/// <summary>
			/// Support for extension GL_EXT_convolution.
			/// </summary>
			[Extension("GL_EXT_convolution")]
			public bool Convolution_EXT;

			/// <summary>
			/// Support for extension GL_SGI_color_matrix.
			/// </summary>
			[Extension("GL_SGI_color_matrix")]
			public bool ColorMatrix_SGI;

			/// <summary>
			/// Support for extension GL_SGI_color_table.
			/// </summary>
			[Extension("GL_SGI_color_table")]
			public bool ColorTable_SGI;

			/// <summary>
			/// Support for extension GL_SGIS_pixel_texture.
			/// </summary>
			[Extension("GL_SGIS_pixel_texture")]
			[Extension("GL_SGIX_pixel_texture")]
			public bool PixelTexture_SGIS;

			/// <summary>
			/// Support for extension GL_SGIS_texture4D.
			/// </summary>
			[Extension("GL_SGIS_texture4D")]
			public bool Texture4D_SGIS;

			/// <summary>
			/// Support for extension GL_SGI_texture_color_table.
			/// </summary>
			[Extension("GL_SGI_texture_color_table")]
			public bool TextureColorTable_SGI;

			/// <summary>
			/// Support for extension GL_EXT_cmyka.
			/// </summary>
			[Extension("GL_EXT_cmyka")]
			public bool Cmyka_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_object.
			/// </summary>
			[Extension("GL_EXT_texture_object")]
			public bool TextureObject_EXT;

			/// <summary>
			/// Support for extension GL_SGIS_detail_texture.
			/// </summary>
			[Extension("GL_SGIS_detail_texture")]
			public bool DetailTexture_SGIS;

			/// <summary>
			/// Support for extension GL_SGIS_sharpen_texture.
			/// </summary>
			[Extension("GL_SGIS_sharpen_texture")]
			public bool SharpenTexture_SGIS;

			/// <summary>
			/// Support for extension GL_EXT_packed_pixels.
			/// </summary>
			[Extension("GL_EXT_packed_pixels")]
			public bool PackedPixels_EXT;

			/// <summary>
			/// Support for extension GL_SGIS_texture_lod.
			/// </summary>
			[Extension("GL_SGIS_texture_lod")]
			public bool TextureLod_SGIS;

			/// <summary>
			/// Support for extension GL_SGIS_multisample.
			/// </summary>
			[Extension("GL_SGIS_multisample")]
			public bool Multisample_SGIS;

			/// <summary>
			/// Support for extension GL_EXT_rescale_normal.
			/// </summary>
			[Extension("GL_EXT_rescale_normal")]
			public bool RescaleNormal_EXT;

			/// <summary>
			/// Support for extension GL_EXT_vertex_array.
			/// </summary>
			[Extension("GL_EXT_vertex_array")]
			public bool VertexArray_EXT;

			/// <summary>
			/// Support for extension GL_EXT_misc_attribute.
			/// </summary>
			[Extension("GL_EXT_misc_attribute")]
			public bool MiscAttribute_EXT;

			/// <summary>
			/// Support for extension GL_SGIS_generate_mipmap.
			/// </summary>
			[Extension("GL_SGIS_generate_mipmap")]
			public bool GenerateMipmap_SGIS;

			/// <summary>
			/// Support for extension GL_SGIX_clipmap.
			/// </summary>
			[Extension("GL_SGIX_clipmap")]
			public bool Clipmap_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_shadow.
			/// </summary>
			[Extension("GL_SGIX_shadow")]
			public bool Shadow_SGIX;

			/// <summary>
			/// Support for extension GL_SGIS_texture_edge_clamp.
			/// </summary>
			[Extension("GL_SGIS_texture_edge_clamp")]
			public bool TextureEdgeClamp_SGIS;

			/// <summary>
			/// Support for extension GL_SGIS_texture_border_clamp.
			/// </summary>
			[Extension("GL_SGIS_texture_border_clamp")]
			public bool TextureBorderClamp_SGIS;

			/// <summary>
			/// Support for extension GL_EXT_blend_minmax.
			/// </summary>
			[Extension("GL_EXT_blend_minmax")]
			public bool BlendMinmax_EXT;

			/// <summary>
			/// Support for extension GL_EXT_blend_subtract.
			/// </summary>
			[Extension("GL_EXT_blend_subtract")]
			public bool BlendSubtract_EXT;

			/// <summary>
			/// Support for extension GL_EXT_blend_logic_op.
			/// </summary>
			[Extension("GL_EXT_blend_logic_op")]
			public bool BlendLogicOp_EXT;

			/// <summary>
			/// Support for extension GL_SGIX_interlace.
			/// </summary>
			[Extension("GL_SGIX_interlace")]
			public bool Interlace_SGIX;

			/// <summary>
			/// Support for extension GL_SGIS_texture_select.
			/// </summary>
			[Extension("GL_SGIS_texture_select")]
			public bool TextureSelect_SGIS;

			/// <summary>
			/// Support for extension GL_SGIX_sprite.
			/// </summary>
			[Extension("GL_SGIX_sprite")]
			public bool Sprite_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_texture_multi_buffer.
			/// </summary>
			[Extension("GL_SGIX_texture_multi_buffer")]
			public bool TextureMultiBuffer_SGIX;

			/// <summary>
			/// Support for extension GL_EXT_point_parameters.
			/// </summary>
			[Extension("GL_EXT_point_parameters")]
			public bool PointParameters_EXT;

			/// <summary>
			/// Support for extension GL_SGIX_instruments.
			/// </summary>
			[Extension("GL_SGIX_instruments")]
			public bool Instruments_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_texture_scale_bias.
			/// </summary>
			[Extension("GL_SGIX_texture_scale_bias")]
			public bool TextureScaleBias_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_framezoom.
			/// </summary>
			[Extension("GL_SGIX_framezoom")]
			public bool Framezoom_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_tag_sample_buffer.
			/// </summary>
			[Extension("GL_SGIX_tag_sample_buffer")]
			public bool TagSampleBuffer_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_reference_plane.
			/// </summary>
			[Extension("GL_SGIX_reference_plane")]
			public bool ReferencePlane_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_flush_raster.
			/// </summary>
			[Extension("GL_SGIX_flush_raster")]
			public bool FlushRaster_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_depth_texture.
			/// </summary>
			[Extension("GL_SGIX_depth_texture")]
			public bool DepthTexture_SGIX;

			/// <summary>
			/// Support for extension GL_SGIS_fog_function.
			/// </summary>
			[Extension("GL_SGIS_fog_function")]
			public bool FogFunction_SGIS;

			/// <summary>
			/// Support for extension GL_SGIX_fog_offset.
			/// </summary>
			[Extension("GL_SGIX_fog_offset")]
			public bool FogOffset_SGIX;

			/// <summary>
			/// Support for extension GL_HP_image_transform.
			/// </summary>
			[Extension("GL_HP_image_transform")]
			public bool ImageTransform_HP;

			/// <summary>
			/// Support for extension GL_HP_convolution_border_modes.
			/// </summary>
			[Extension("GL_HP_convolution_border_modes")]
			public bool ConvolutionBorderModes_HP;

			/// <summary>
			/// Support for extension GL_SGIX_texture_add_env.
			/// </summary>
			[Extension("GL_SGIX_texture_add_env")]
			public bool TextureAddEnv_SGIX;

			/// <summary>
			/// Support for extension GL_EXT_color_subtable.
			/// </summary>
			[Extension("GL_EXT_color_subtable")]
			public bool ColorSubtable_EXT;

			/// <summary>
			/// Support for extension GL_PGI_vertex_hints.
			/// </summary>
			[Extension("GL_PGI_vertex_hints")]
			public bool VertexHints_PGI;

			/// <summary>
			/// Support for extension GL_PGI_misc_hints.
			/// </summary>
			[Extension("GL_PGI_misc_hints")]
			public bool MiscHints_PGI;

			/// <summary>
			/// Support for extension GL_EXT_paletted_texture.
			/// </summary>
			[Extension("GL_EXT_paletted_texture")]
			public bool PalettedTexture_EXT;

			/// <summary>
			/// Support for extension GL_EXT_clip_volume_hint.
			/// </summary>
			[Extension("GL_EXT_clip_volume_hint")]
			public bool ClipVolumeHint_EXT;

			/// <summary>
			/// Support for extension GL_SGIX_list_priority.
			/// </summary>
			[Extension("GL_SGIX_list_priority")]
			public bool ListPriority_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_ir_instrument1.
			/// </summary>
			[Extension("GL_SGIX_ir_instrument1")]
			public bool IrInstrument1_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_texture_lod_bias.
			/// </summary>
			[Extension("GL_SGIX_texture_lod_bias")]
			public bool TextureLodBias_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_shadow_ambient.
			/// </summary>
			[Extension("GL_SGIX_shadow_ambient")]
			public bool ShadowAmbient_SGIX;

			/// <summary>
			/// Support for extension GL_EXT_index_texture.
			/// </summary>
			[Extension("GL_EXT_index_texture")]
			public bool IndexTexture_EXT;

			/// <summary>
			/// Support for extension GL_EXT_index_material.
			/// </summary>
			[Extension("GL_EXT_index_material")]
			public bool IndexMaterial_EXT;

			/// <summary>
			/// Support for extension GL_EXT_index_func.
			/// </summary>
			[Extension("GL_EXT_index_func")]
			public bool IndexFunc_EXT;

			/// <summary>
			/// Support for extension GL_EXT_index_array_formats.
			/// </summary>
			[Extension("GL_EXT_index_array_formats")]
			public bool IndexArrayFormats_EXT;

			/// <summary>
			/// Support for extension GL_EXT_compiled_vertex_array.
			/// </summary>
			[Extension("GL_EXT_compiled_vertex_array")]
			public bool CompiledVertexArray_EXT;

			/// <summary>
			/// Support for extension GL_EXT_cull_vertex.
			/// </summary>
			[Extension("GL_EXT_cull_vertex")]
			public bool CullVertex_EXT;

			/// <summary>
			/// Support for extension GL_SGIX_ycrcb.
			/// </summary>
			[Extension("GL_SGIX_ycrcb")]
			public bool Ycrcb_SGIX;

			/// <summary>
			/// Support for extension GL_IBM_rasterpos_clip.
			/// </summary>
			[Extension("GL_IBM_rasterpos_clip")]
			public bool RasterposClip_IBM;

			/// <summary>
			/// Support for extension GL_HP_texture_lighting.
			/// </summary>
			[Extension("GL_HP_texture_lighting")]
			public bool TextureLighting_HP;

			/// <summary>
			/// Support for extension GL_EXT_draw_range_elements.
			/// </summary>
			[Extension("GL_EXT_draw_range_elements")]
			public bool DrawRangeElements_EXT;

			/// <summary>
			/// Support for extension GL_WIN_phong_shading.
			/// </summary>
			[Extension("GL_WIN_phong_shading")]
			public bool PhongShading_WIN;

			/// <summary>
			/// Support for extension GL_WIN_specular_fog.
			/// </summary>
			[Extension("GL_WIN_specular_fog")]
			public bool SpecularFog_WIN;

			/// <summary>
			/// Support for extension GL_EXT_light_texture.
			/// </summary>
			[Extension("GL_EXT_light_texture")]
			public bool LightTexture_EXT;

			/// <summary>
			/// Support for extension GL_SGIX_blend_alpha_minmax.
			/// </summary>
			[Extension("GL_SGIX_blend_alpha_minmax")]
			public bool BlendAlphaMinmax_SGIX;

			/// <summary>
			/// Support for extension GL_EXT_bgra.
			/// </summary>
			[Extension("GL_EXT_bgra")]
			public bool Bgra_EXT;

			/// <summary>
			/// Support for extension GL_SGIX_async.
			/// </summary>
			[Extension("GL_SGIX_async")]
			public bool Async_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_async_pixel.
			/// </summary>
			[Extension("GL_SGIX_async_pixel")]
			public bool AsyncPixel_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_async_histogram.
			/// </summary>
			[Extension("GL_SGIX_async_histogram")]
			public bool AsyncHistogram_SGIX;

			/// <summary>
			/// Support for extension GL_INTEL_parallel_arrays.
			/// </summary>
			[Extension("GL_INTEL_parallel_arrays")]
			public bool ParallelArrays_INTEL;

			/// <summary>
			/// Support for extension GL_HP_occlusion_test.
			/// </summary>
			[Extension("GL_HP_occlusion_test")]
			public bool OcclusionTest_HP;

			/// <summary>
			/// Support for extension GL_EXT_pixel_transform.
			/// </summary>
			[Extension("GL_EXT_pixel_transform")]
			public bool PixelTransform_EXT;

			/// <summary>
			/// Support for extension GL_EXT_pixel_transform_color_table.
			/// </summary>
			[Extension("GL_EXT_pixel_transform_color_table")]
			public bool PixelTransformColorTable_EXT;

			/// <summary>
			/// Support for extension GL_EXT_shared_texture_palette.
			/// </summary>
			[Extension("GL_EXT_shared_texture_palette")]
			public bool SharedTexturePalette_EXT;

			/// <summary>
			/// Support for extension GL_EXT_separate_specular_color.
			/// </summary>
			[Extension("GL_EXT_separate_specular_color")]
			public bool SeparateSpecularColor_EXT;

			/// <summary>
			/// Support for extension GL_EXT_secondary_color.
			/// </summary>
			[Extension("GL_EXT_secondary_color")]
			public bool SecondaryColor_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_perturb_normal.
			/// </summary>
			[Extension("GL_EXT_texture_perturb_normal")]
			public bool TexturePerturbNormal_EXT;

			/// <summary>
			/// Support for extension GL_EXT_multi_draw_arrays.
			/// </summary>
			[Extension("GL_EXT_multi_draw_arrays")]
			public bool MultiDrawArrays_EXT;

			/// <summary>
			/// Support for extension GL_EXT_fog_coord.
			/// </summary>
			[Extension("GL_EXT_fog_coord")]
			public bool FogCoord_EXT;

			/// <summary>
			/// Support for extension GL_REND_screen_coordinates.
			/// </summary>
			[Extension("GL_REND_screen_coordinates")]
			public bool ScreenCoordinates_REND;

			/// <summary>
			/// Support for extension GL_EXT_coordinate_frame.
			/// </summary>
			[Extension("GL_EXT_coordinate_frame")]
			public bool CoordinateFrame_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_env_combine.
			/// </summary>
			[Extension("GL_EXT_texture_env_combine")]
			public bool TextureEnvCombine_EXT;

			/// <summary>
			/// Support for extension GL_APPLE_specular_vector.
			/// </summary>
			[Extension("GL_APPLE_specular_vector")]
			public bool SpecularVector_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_transform_hint.
			/// </summary>
			[Extension("GL_APPLE_transform_hint")]
			public bool TransformHint_APPLE;

			/// <summary>
			/// Support for extension GL_SUNX_constant_data.
			/// </summary>
			[Extension("GL_SUNX_constant_data")]
			public bool ConstantData_SUNX;

			/// <summary>
			/// Support for extension GL_SUN_global_alpha.
			/// </summary>
			[Extension("GL_SUN_global_alpha")]
			public bool GlobalAlpha_SUN;

			/// <summary>
			/// Support for extension GL_SUN_triangle_list.
			/// </summary>
			[Extension("GL_SUN_triangle_list")]
			public bool TriangleList_SUN;

			/// <summary>
			/// Support for extension GL_SUN_vertex.
			/// </summary>
			[Extension("GL_SUN_vertex")]
			public bool Vertex_SUN;

			/// <summary>
			/// Support for extension GL_EXT_blend_func_separate.
			/// </summary>
			[Extension("GL_EXT_blend_func_separate")]
			public bool BlendFuncSeparate_EXT;

			/// <summary>
			/// Support for extension GL_INGR_color_clamp.
			/// </summary>
			[Extension("GL_INGR_color_clamp")]
			public bool ColorClamp_INGR;

			/// <summary>
			/// Support for extension GL_INGR_interlace_read.
			/// </summary>
			[Extension("GL_INGR_interlace_read")]
			public bool InterlaceRead_INGR;

			/// <summary>
			/// Support for extension GL_EXT_stencil_wrap.
			/// </summary>
			[Extension("GL_EXT_stencil_wrap")]
			public bool StencilWrap_EXT;

			/// <summary>
			/// Support for extension GL_EXT_422_pixels.
			/// </summary>
			[Extension("GL_EXT_422_pixels")]
			public bool _422Pixels_EXT;

			/// <summary>
			/// Support for extension GL_NV_texgen_reflection.
			/// </summary>
			[Extension("GL_NV_texgen_reflection")]
			public bool TexgenReflection_NV;

			/// <summary>
			/// Support for extension GL_SUN_convolution_border_modes.
			/// </summary>
			[Extension("GL_SUN_convolution_border_modes")]
			public bool ConvolutionBorderModes_SUN;

			/// <summary>
			/// Support for extension GL_EXT_texture_env_add.
			/// </summary>
			[Extension("GL_EXT_texture_env_add")]
			public bool TextureEnvAdd_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_lod_bias.
			/// </summary>
			[Extension("GL_EXT_texture_lod_bias")]
			public bool TextureLodBias_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_filter_anisotropic.
			/// </summary>
			[Extension("GL_EXT_texture_filter_anisotropic")]
			public bool TextureFilterAnisotropic_EXT;

			/// <summary>
			/// Support for extension GL_EXT_vertex_weighting.
			/// </summary>
			[Extension("GL_EXT_vertex_weighting")]
			public bool VertexWeighting_EXT;

			/// <summary>
			/// Support for extension GL_NV_light_max_exponent.
			/// </summary>
			[Extension("GL_NV_light_max_exponent")]
			public bool LightMaxExponent_NV;

			/// <summary>
			/// Support for extension GL_NV_vertex_array_range.
			/// </summary>
			[Extension("GL_NV_vertex_array_range")]
			public bool VertexArrayRange_NV;

			/// <summary>
			/// Support for extension GL_NV_register_combiners.
			/// </summary>
			[Extension("GL_NV_register_combiners")]
			public bool RegisterCombiners_NV;

			/// <summary>
			/// Support for extension GL_NV_fog_distance.
			/// </summary>
			[Extension("GL_NV_fog_distance")]
			public bool FogDistance_NV;

			/// <summary>
			/// Support for extension GL_NV_texgen_emboss.
			/// </summary>
			[Extension("GL_NV_texgen_emboss")]
			public bool TexgenEmboss_NV;

			/// <summary>
			/// Support for extension GL_NV_blend_square.
			/// </summary>
			[Extension("GL_NV_blend_square")]
			public bool BlendSquare_NV;

			/// <summary>
			/// Support for extension GL_NV_texture_env_combine4.
			/// </summary>
			[Extension("GL_NV_texture_env_combine4")]
			public bool TextureEnvCombine4_NV;

			/// <summary>
			/// Support for extension GL_MESA_resize_buffers.
			/// </summary>
			[Extension("GL_MESA_resize_buffers")]
			public bool ResizeBuffers_MESA;

			/// <summary>
			/// Support for extension GL_MESA_window_pos.
			/// </summary>
			[Extension("GL_MESA_window_pos")]
			public bool WindowPos_MESA;

			/// <summary>
			/// Support for extension GL_EXT_texture_compression_s3tc.
			/// </summary>
			[Extension("GL_EXT_texture_compression_s3tc")]
			public bool TextureCompressionS3tc_EXT;

			/// <summary>
			/// Support for extension GL_IBM_cull_vertex.
			/// </summary>
			[Extension("GL_IBM_cull_vertex")]
			public bool CullVertex_IBM;

			/// <summary>
			/// Support for extension GL_IBM_multimode_draw_arrays.
			/// </summary>
			[Extension("GL_IBM_multimode_draw_arrays")]
			public bool MultimodeDrawArrays_IBM;

			/// <summary>
			/// Support for extension GL_IBM_vertex_array_lists.
			/// </summary>
			[Extension("GL_IBM_vertex_array_lists")]
			public bool VertexArrayLists_IBM;

			/// <summary>
			/// Support for extension GL_3DFX_texture_compression_FXT1.
			/// </summary>
			[Extension("GL_3DFX_texture_compression_FXT1")]
			public bool TextureCompressionFXT1_3DFX;

			/// <summary>
			/// Support for extension GL_3DFX_multisample.
			/// </summary>
			[Extension("GL_3DFX_multisample")]
			public bool Multisample_3DFX;

			/// <summary>
			/// Support for extension GL_3DFX_tbuffer.
			/// </summary>
			[Extension("GL_3DFX_tbuffer")]
			public bool Tbuffer_3DFX;

			/// <summary>
			/// Support for extension GL_EXT_multisample.
			/// </summary>
			[Extension("GL_EXT_multisample")]
			public bool Multisample_EXT;

			/// <summary>
			/// Support for extension GL_SGIX_vertex_preclip.
			/// </summary>
			[Extension("GL_SGIX_vertex_preclip")]
			public bool VertexPreclip_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_convolution_accuracy.
			/// </summary>
			[Extension("GL_SGIX_convolution_accuracy")]
			public bool ConvolutionAccuracy_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_resample.
			/// </summary>
			[Extension("GL_SGIX_resample")]
			public bool Resample_SGIX;

			/// <summary>
			/// Support for extension GL_SGIS_point_line_texgen.
			/// </summary>
			[Extension("GL_SGIS_point_line_texgen")]
			public bool PointLineTexgen_SGIS;

			/// <summary>
			/// Support for extension GL_SGIS_texture_color_mask.
			/// </summary>
			[Extension("GL_SGIS_texture_color_mask")]
			public bool TextureColorMask_SGIS;

			/// <summary>
			/// Support for extension GL_EXT_texture_env_dot3.
			/// </summary>
			[Extension("GL_EXT_texture_env_dot3")]
			public bool TextureEnvDot3_EXT;

			/// <summary>
			/// Support for extension GL_ATI_texture_mirror_once.
			/// </summary>
			[Extension("GL_ATI_texture_mirror_once")]
			public bool TextureMirrorOnce_ATI;

			/// <summary>
			/// Support for extension GL_NV_fence.
			/// </summary>
			[Extension("GL_NV_fence")]
			public bool Fence_NV;

			/// <summary>
			/// Support for extension GL_IBM_static_data.
			/// </summary>
			[Extension("GL_IBM_static_data")]
			public bool StaticData_IBM;

			/// <summary>
			/// Support for extension GL_IBM_texture_mirrored_repeat.
			/// </summary>
			[Extension("GL_IBM_texture_mirrored_repeat")]
			public bool TextureMirroredRepeat_IBM;

			/// <summary>
			/// Support for extension GL_NV_evaluators.
			/// </summary>
			[Extension("GL_NV_evaluators")]
			public bool Evaluators_NV;

			/// <summary>
			/// Support for extension GL_NV_packed_depth_stencil.
			/// </summary>
			[Extension("GL_NV_packed_depth_stencil")]
			public bool PackedDepthStencil_NV;

			/// <summary>
			/// Support for extension GL_NV_register_combiners2.
			/// </summary>
			[Extension("GL_NV_register_combiners2")]
			public bool RegisterCombiners2_NV;

			/// <summary>
			/// Support for extension GL_NV_texture_compression_vtc.
			/// </summary>
			[Extension("GL_NV_texture_compression_vtc")]
			public bool TextureCompressionVtc_NV;

			/// <summary>
			/// Support for extension GL_NV_texture_rectangle.
			/// </summary>
			[Extension("GL_NV_texture_rectangle")]
			public bool TextureRectangle_NV;

			/// <summary>
			/// Support for extension GL_NV_texture_shader.
			/// </summary>
			[Extension("GL_NV_texture_shader")]
			public bool TextureShader_NV;

			/// <summary>
			/// Support for extension GL_NV_texture_shader2.
			/// </summary>
			[Extension("GL_NV_texture_shader2")]
			public bool TextureShader2_NV;

			/// <summary>
			/// Support for extension GL_NV_vertex_array_range2.
			/// </summary>
			[Extension("GL_NV_vertex_array_range2")]
			public bool VertexArrayRange2_NV;

			/// <summary>
			/// Support for extension GL_NV_vertex_program.
			/// </summary>
			[Extension("GL_NV_vertex_program")]
			public bool VertexProgram_NV;

			/// <summary>
			/// Support for extension GL_SGIX_texture_coordinate_clamp.
			/// </summary>
			[Extension("GL_SGIX_texture_coordinate_clamp")]
			public bool TextureCoordinateClamp_SGIX;

			/// <summary>
			/// Support for extension GL_OML_interlace.
			/// </summary>
			[Extension("GL_OML_interlace")]
			public bool Interlace_OML;

			/// <summary>
			/// Support for extension GL_OML_subsample.
			/// </summary>
			[Extension("GL_OML_subsample")]
			public bool Subsample_OML;

			/// <summary>
			/// Support for extension GL_OML_resample.
			/// </summary>
			[Extension("GL_OML_resample")]
			public bool Resample_OML;

			/// <summary>
			/// Support for extension GL_NV_copy_depth_to_color.
			/// </summary>
			[Extension("GL_NV_copy_depth_to_color")]
			public bool CopyDepthToColor_NV;

			/// <summary>
			/// Support for extension GL_ATI_envmap_bumpmap.
			/// </summary>
			[Extension("GL_ATI_envmap_bumpmap")]
			public bool EnvmapBumpmap_ATI;

			/// <summary>
			/// Support for extension GL_ATI_fragment_shader.
			/// </summary>
			[Extension("GL_ATI_fragment_shader")]
			public bool FragmentShader_ATI;

			/// <summary>
			/// Support for extension GL_ATI_pn_triangles.
			/// </summary>
			[Extension("GL_ATI_pn_triangles")]
			public bool PnTriangles_ATI;

			/// <summary>
			/// Support for extension GL_ATI_vertex_array_object.
			/// </summary>
			[Extension("GL_ATI_vertex_array_object")]
			public bool VertexArrayObject_ATI;

			/// <summary>
			/// Support for extension GL_EXT_vertex_shader.
			/// </summary>
			[Extension("GL_EXT_vertex_shader")]
			public bool VertexShader_EXT;

			/// <summary>
			/// Support for extension GL_ATI_vertex_streams.
			/// </summary>
			[Extension("GL_ATI_vertex_streams")]
			public bool VertexStreams_ATI;

			/// <summary>
			/// Support for extension GL_ATI_element_array.
			/// </summary>
			[Extension("GL_ATI_element_array")]
			public bool ElementArray_ATI;

			/// <summary>
			/// Support for extension GL_SUN_mesh_array.
			/// </summary>
			[Extension("GL_SUN_mesh_array")]
			public bool MeshArray_SUN;

			/// <summary>
			/// Support for extension GL_SUN_slice_accum.
			/// </summary>
			[Extension("GL_SUN_slice_accum")]
			public bool SliceAccum_SUN;

			/// <summary>
			/// Support for extension GL_NV_multisample_filter_hint.
			/// </summary>
			[Extension("GL_NV_multisample_filter_hint")]
			public bool MultisampleFilterHint_NV;

			/// <summary>
			/// Support for extension GL_NV_depth_clamp.
			/// </summary>
			[Extension("GL_NV_depth_clamp")]
			public bool DepthClamp_NV;

			/// <summary>
			/// Support for extension GL_NV_occlusion_query.
			/// </summary>
			[Extension("GL_NV_occlusion_query")]
			public bool OcclusionQuery_NV;

			/// <summary>
			/// Support for extension GL_NV_point_sprite.
			/// </summary>
			[Extension("GL_NV_point_sprite")]
			public bool PointSprite_NV;

			/// <summary>
			/// Support for extension GL_NV_texture_shader3.
			/// </summary>
			[Extension("GL_NV_texture_shader3")]
			public bool TextureShader3_NV;

			/// <summary>
			/// Support for extension GL_NV_vertex_program1_1.
			/// </summary>
			[Extension("GL_NV_vertex_program1_1")]
			public bool VertexProgram11_NV;

			/// <summary>
			/// Support for extension GL_EXT_shadow_funcs.
			/// </summary>
			[Extension("GL_EXT_shadow_funcs")]
			public bool ShadowFuncs_EXT;

			/// <summary>
			/// Support for extension GL_EXT_stencil_two_side.
			/// </summary>
			[Extension("GL_EXT_stencil_two_side")]
			public bool StencilTwoSide_EXT;

			/// <summary>
			/// Support for extension GL_ATI_text_fragment_shader.
			/// </summary>
			[Extension("GL_ATI_text_fragment_shader")]
			public bool TextFragmentShader_ATI;

			/// <summary>
			/// Support for extension GL_APPLE_client_storage.
			/// </summary>
			[Extension("GL_APPLE_client_storage")]
			public bool ClientStorage_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_element_array.
			/// </summary>
			[Extension("GL_APPLE_element_array")]
			public bool ElementArray_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_fence.
			/// </summary>
			[Extension("GL_APPLE_fence")]
			public bool Fence_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_vertex_array_object.
			/// </summary>
			[Extension("GL_APPLE_vertex_array_object")]
			public bool VertexArrayObject_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_vertex_array_range.
			/// </summary>
			[Extension("GL_APPLE_vertex_array_range")]
			public bool VertexArrayRange_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_ycbcr_422.
			/// </summary>
			[Extension("GL_APPLE_ycbcr_422")]
			public bool Ycbcr422_APPLE;

			/// <summary>
			/// Support for extension GL_S3_s3tc.
			/// </summary>
			[Extension("GL_S3_s3tc")]
			public bool S3tc_S3;

			/// <summary>
			/// Support for extension GL_ATI_draw_buffers.
			/// </summary>
			[Extension("GL_ATI_draw_buffers")]
			public bool DrawBuffers_ATI;

			/// <summary>
			/// Support for extension GL_ATI_texture_env_combine3.
			/// </summary>
			[Extension("GL_ATI_texture_env_combine3")]
			public bool TextureEnvCombine3_ATI;

			/// <summary>
			/// Support for extension GL_ATI_texture_float.
			/// </summary>
			[Extension("GL_ATI_texture_float")]
			public bool TextureFloat_ATI;

			/// <summary>
			/// Support for extension GL_NV_float_buffer.
			/// </summary>
			[Extension("GL_NV_float_buffer")]
			public bool FloatBuffer_NV;

			/// <summary>
			/// Support for extension GL_NV_fragment_program.
			/// </summary>
			[Extension("GL_NV_fragment_program")]
			public bool FragmentProgram_NV;

			/// <summary>
			/// Support for extension GL_NV_half_float.
			/// </summary>
			[Extension("GL_NV_half_float")]
			public bool HalfFloat_NV;

			/// <summary>
			/// Support for extension GL_NV_pixel_data_range.
			/// </summary>
			[Extension("GL_NV_pixel_data_range")]
			public bool PixelDataRange_NV;

			/// <summary>
			/// Support for extension GL_NV_primitive_restart.
			/// </summary>
			[Extension("GL_NV_primitive_restart")]
			public bool PrimitiveRestart_NV;

			/// <summary>
			/// Support for extension GL_NV_texture_expand_normal.
			/// </summary>
			[Extension("GL_NV_texture_expand_normal")]
			public bool TextureExpandNormal_NV;

			/// <summary>
			/// Support for extension GL_NV_vertex_program2.
			/// </summary>
			[Extension("GL_NV_vertex_program2")]
			public bool VertexProgram2_NV;

			/// <summary>
			/// Support for extension GL_ATI_map_object_buffer.
			/// </summary>
			[Extension("GL_ATI_map_object_buffer")]
			public bool MapObjectBuffer_ATI;

			/// <summary>
			/// Support for extension GL_ATI_separate_stencil.
			/// </summary>
			[Extension("GL_ATI_separate_stencil")]
			public bool SeparateStencil_ATI;

			/// <summary>
			/// Support for extension GL_ATI_vertex_attrib_array_object.
			/// </summary>
			[Extension("GL_ATI_vertex_attrib_array_object")]
			public bool VertexAttribArrayObject_ATI;

			/// <summary>
			/// Support for extension GL_OES_byte_coordinates.
			/// </summary>
			[Extension("GL_OES_byte_coordinates")]
			public bool ByteCoordinates_OES;

			/// <summary>
			/// Support for extension GL_OES_fixed_point.
			/// </summary>
			[Extension("GL_OES_fixed_point")]
			public bool FixedPoint_OES;

			/// <summary>
			/// Support for extension GL_OES_single_precision.
			/// </summary>
			[Extension("GL_OES_single_precision")]
			public bool SinglePrecision_OES;

			/// <summary>
			/// Support for extension GL_OES_compressed_paletted_texture.
			/// </summary>
			[Extension("GL_OES_compressed_paletted_texture")]
			public bool CompressedPalettedTexture_OES;

			/// <summary>
			/// Support for extension GL_OES_read_format.
			/// </summary>
			[Extension("GL_OES_read_format")]
			public bool ReadFormat_OES;

			/// <summary>
			/// Support for extension GL_OES_query_matrix.
			/// </summary>
			[Extension("GL_OES_query_matrix")]
			public bool QueryMatrix_OES;

			/// <summary>
			/// Support for extension GL_EXT_depth_bounds_test.
			/// </summary>
			[Extension("GL_EXT_depth_bounds_test")]
			public bool DepthBoundsTest_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_mirror_clamp.
			/// </summary>
			[Extension("GL_EXT_texture_mirror_clamp")]
			public bool TextureMirrorClamp_EXT;

			/// <summary>
			/// Support for extension GL_EXT_blend_equation_separate.
			/// </summary>
			[Extension("GL_EXT_blend_equation_separate")]
			public bool BlendEquationSeparate_EXT;

			/// <summary>
			/// Support for extension GL_MESA_pack_invert.
			/// </summary>
			[Extension("GL_MESA_pack_invert")]
			public bool PackInvert_MESA;

			/// <summary>
			/// Support for extension GL_MESA_ycbcr_texture.
			/// </summary>
			[Extension("GL_MESA_ycbcr_texture")]
			public bool YcbcrTexture_MESA;

			/// <summary>
			/// Support for extension GL_EXT_pixel_buffer_object.
			/// </summary>
			[Extension("GL_EXT_pixel_buffer_object")]
			public bool PixelBufferObject_EXT;

			/// <summary>
			/// Support for extension GL_NV_fragment_program_option.
			/// </summary>
			[Extension("GL_NV_fragment_program_option")]
			public bool FragmentProgramOption_NV;

			/// <summary>
			/// Support for extension GL_NV_fragment_program2.
			/// </summary>
			[Extension("GL_NV_fragment_program2")]
			public bool FragmentProgram2_NV;

			/// <summary>
			/// Support for extension GL_NV_vertex_program2_option.
			/// </summary>
			[Extension("GL_NV_vertex_program2_option")]
			public bool VertexProgram2Option_NV;

			/// <summary>
			/// Support for extension GL_NV_vertex_program3.
			/// </summary>
			[Extension("GL_NV_vertex_program3")]
			public bool VertexProgram3_NV;

			/// <summary>
			/// Support for extension GL_EXT_texture_compression_dxt1.
			/// </summary>
			[Extension("GL_EXT_texture_compression_dxt1")]
			public bool TextureCompressionDxt1_EXT;

			/// <summary>
			/// Support for extension GL_EXT_framebuffer_object.
			/// </summary>
			[Extension("GL_EXT_framebuffer_object")]
			public bool FramebufferObject_EXT;

			/// <summary>
			/// Support for extension GL_GREMEDY_string_marker.
			/// </summary>
			[Extension("GL_GREMEDY_string_marker")]
			public bool StringMarker_GREMEDY;

			/// <summary>
			/// Support for extension GL_EXT_packed_depth_stencil.
			/// </summary>
			[Extension("GL_EXT_packed_depth_stencil")]
			public bool PackedDepthStencil_EXT;

			/// <summary>
			/// Support for extension GL_EXT_stencil_clear_tag.
			/// </summary>
			[Extension("GL_EXT_stencil_clear_tag")]
			public bool StencilClearTag_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_sRGB.
			/// </summary>
			[Extension("GL_EXT_texture_sRGB")]
			public bool TextureSRGB_EXT;

			/// <summary>
			/// Support for extension GL_EXT_framebuffer_blit.
			/// </summary>
			[Extension("GL_EXT_framebuffer_blit")]
			public bool FramebufferBlit_EXT;

			/// <summary>
			/// Support for extension GL_EXT_framebuffer_multisample.
			/// </summary>
			[Extension("GL_EXT_framebuffer_multisample")]
			public bool FramebufferMultisample_EXT;

			/// <summary>
			/// Support for extension GL_MESAX_texture_stack.
			/// </summary>
			[Extension("GL_MESAX_texture_stack")]
			public bool TextureStack_MESAX;

			/// <summary>
			/// Support for extension GL_EXT_timer_query.
			/// </summary>
			[Extension("GL_EXT_timer_query")]
			public bool TimerQuery_EXT;

			/// <summary>
			/// Support for extension GL_EXT_gpu_program_parameters.
			/// </summary>
			[Extension("GL_EXT_gpu_program_parameters")]
			public bool GpuProgramParameters_EXT;

			/// <summary>
			/// Support for extension GL_APPLE_flush_buffer_range.
			/// </summary>
			[Extension("GL_APPLE_flush_buffer_range")]
			public bool FlushBufferRange_APPLE;

			/// <summary>
			/// Support for extension GL_NV_gpu_program4.
			/// </summary>
			[Extension("GL_NV_gpu_program4")]
			public bool GpuProgram4_NV;

			/// <summary>
			/// Support for extension GL_NV_geometry_program4.
			/// </summary>
			[Extension("GL_NV_geometry_program4")]
			public bool GeometryProgram4_NV;

			/// <summary>
			/// Support for extension GL_EXT_geometry_shader4.
			/// </summary>
			[Extension("GL_EXT_geometry_shader4")]
			public bool GeometryShader4_EXT;

			/// <summary>
			/// Support for extension GL_NV_vertex_program4.
			/// </summary>
			[Extension("GL_NV_vertex_program4")]
			public bool VertexProgram4_NV;

			/// <summary>
			/// Support for extension GL_EXT_gpu_shader4.
			/// </summary>
			[Extension("GL_EXT_gpu_shader4")]
			public bool GpuShader4_EXT;

			/// <summary>
			/// Support for extension GL_EXT_draw_instanced.
			/// </summary>
			[Extension("GL_EXT_draw_instanced")]
			public bool DrawInstanced_EXT;

			/// <summary>
			/// Support for extension GL_EXT_packed_float.
			/// </summary>
			[Extension("GL_EXT_packed_float")]
			public bool PackedFloat_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_array.
			/// </summary>
			[Extension("GL_EXT_texture_array")]
			public bool TextureArray_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_buffer_object.
			/// </summary>
			[Extension("GL_EXT_texture_buffer_object")]
			public bool TextureBufferObject_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_compression_latc.
			/// </summary>
			[Extension("GL_EXT_texture_compression_latc")]
			public bool TextureCompressionLatc_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_compression_rgtc.
			/// </summary>
			[Extension("GL_EXT_texture_compression_rgtc")]
			public bool TextureCompressionRgtc_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_shared_exponent.
			/// </summary>
			[Extension("GL_EXT_texture_shared_exponent")]
			public bool TextureSharedExponent_EXT;

			/// <summary>
			/// Support for extension GL_NV_depth_buffer_float.
			/// </summary>
			[Extension("GL_NV_depth_buffer_float")]
			public bool DepthBufferFloat_NV;

			/// <summary>
			/// Support for extension GL_NV_fragment_program4.
			/// </summary>
			[Extension("GL_NV_fragment_program4")]
			public bool FragmentProgram4_NV;

			/// <summary>
			/// Support for extension GL_NV_framebuffer_multisample_coverage.
			/// </summary>
			[Extension("GL_NV_framebuffer_multisample_coverage")]
			public bool FramebufferMultisampleCoverage_NV;

			/// <summary>
			/// Support for extension GL_EXT_framebuffer_sRGB.
			/// </summary>
			[Extension("GL_EXT_framebuffer_sRGB")]
			public bool FramebufferSRGB_EXT;

			/// <summary>
			/// Support for extension GL_NV_geometry_shader4.
			/// </summary>
			[Extension("GL_NV_geometry_shader4")]
			public bool GeometryShader4_NV;

			/// <summary>
			/// Support for extension GL_NV_parameter_buffer_object.
			/// </summary>
			[Extension("GL_NV_parameter_buffer_object")]
			public bool ParameterBufferObject_NV;

			/// <summary>
			/// Support for extension GL_EXT_draw_buffers2.
			/// </summary>
			[Extension("GL_EXT_draw_buffers2")]
			public bool DrawBuffers2_EXT;

			/// <summary>
			/// Support for extension GL_NV_transform_feedback.
			/// </summary>
			[Extension("GL_NV_transform_feedback")]
			public bool TransformFeedback_NV;

			/// <summary>
			/// Support for extension GL_EXT_bindable_uniform.
			/// </summary>
			[Extension("GL_EXT_bindable_uniform")]
			public bool BindableUniform_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_integer.
			/// </summary>
			[Extension("GL_EXT_texture_integer")]
			public bool TextureInteger_EXT;

			/// <summary>
			/// Support for extension GL_GREMEDY_frame_terminator.
			/// </summary>
			[Extension("GL_GREMEDY_frame_terminator")]
			public bool FrameTerminator_GREMEDY;

			/// <summary>
			/// Support for extension GL_NV_conditional_render.
			/// </summary>
			[Extension("GL_NV_conditional_render")]
			public bool ConditionalRender_NV;

			/// <summary>
			/// Support for extension GL_NV_present_video.
			/// </summary>
			[Extension("GL_NV_present_video")]
			public bool PresentVideo_NV;

			/// <summary>
			/// Support for extension GL_EXT_transform_feedback.
			/// </summary>
			[Extension("GL_EXT_transform_feedback")]
			public bool TransformFeedback_EXT;

			/// <summary>
			/// Support for extension GL_EXT_direct_state_access.
			/// </summary>
			[Extension("GL_EXT_direct_state_access")]
			public bool DirectStateAccess_EXT;

			/// <summary>
			/// Support for extension GL_EXT_vertex_array_bgra.
			/// </summary>
			[Extension("GL_EXT_vertex_array_bgra")]
			public bool VertexArrayBgra_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_swizzle.
			/// </summary>
			[Extension("GL_EXT_texture_swizzle")]
			public bool TextureSwizzle_EXT;

			/// <summary>
			/// Support for extension GL_NV_explicit_multisample.
			/// </summary>
			[Extension("GL_NV_explicit_multisample")]
			public bool ExplicitMultisample_NV;

			/// <summary>
			/// Support for extension GL_NV_transform_feedback2.
			/// </summary>
			[Extension("GL_NV_transform_feedback2")]
			public bool TransformFeedback2_NV;

			/// <summary>
			/// Support for extension GL_ATI_meminfo.
			/// </summary>
			[Extension("GL_ATI_meminfo")]
			public bool Meminfo_ATI;

			/// <summary>
			/// Support for extension GL_AMD_performance_monitor.
			/// </summary>
			[Extension("GL_AMD_performance_monitor")]
			public bool PerformanceMonitor_AMD;

			/// <summary>
			/// Support for extension GL_AMD_texture_texture4.
			/// </summary>
			[Extension("GL_AMD_texture_texture4")]
			public bool TextureTexture4_AMD;

			/// <summary>
			/// Support for extension GL_AMD_vertex_shader_tessellator.
			/// </summary>
			[Extension("GL_AMD_vertex_shader_tessellator")]
			public bool VertexShaderTessellator_AMD;

			/// <summary>
			/// Support for extension GL_EXT_provoking_vertex.
			/// </summary>
			[Extension("GL_EXT_provoking_vertex")]
			public bool ProvokingVertex_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_snorm.
			/// </summary>
			[Extension("GL_EXT_texture_snorm")]
			public bool TextureSnorm_EXT;

			/// <summary>
			/// Support for extension GL_AMD_draw_buffers_blend.
			/// </summary>
			[Extension("GL_AMD_draw_buffers_blend")]
			public bool DrawBuffersBlend_AMD;

			/// <summary>
			/// Support for extension GL_APPLE_texture_range.
			/// </summary>
			[Extension("GL_APPLE_texture_range")]
			public bool TextureRange_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_float_pixels.
			/// </summary>
			[Extension("GL_APPLE_float_pixels")]
			public bool FloatPixels_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_vertex_program_evaluators.
			/// </summary>
			[Extension("GL_APPLE_vertex_program_evaluators")]
			public bool VertexProgramEvaluators_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_aux_depth_stencil.
			/// </summary>
			[Extension("GL_APPLE_aux_depth_stencil")]
			public bool AuxDepthStencil_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_object_purgeable.
			/// </summary>
			[Extension("GL_APPLE_object_purgeable")]
			public bool ObjectPurgeable_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_row_bytes.
			/// </summary>
			[Extension("GL_APPLE_row_bytes")]
			public bool RowBytes_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_rgb_422.
			/// </summary>
			[Extension("GL_APPLE_rgb_422")]
			public bool Rgb422_APPLE;

			/// <summary>
			/// Support for extension GL_NV_video_capture.
			/// </summary>
			[Extension("GL_NV_video_capture")]
			public bool VideoCapture_NV;

			/// <summary>
			/// Support for extension GL_NV_copy_image.
			/// </summary>
			[Extension("GL_NV_copy_image")]
			public bool CopyImage_NV;

			/// <summary>
			/// Support for extension GL_EXT_separate_shader_objects.
			/// </summary>
			[Extension("GL_EXT_separate_shader_objects")]
			public bool SeparateShaderObjects_EXT;

			/// <summary>
			/// Support for extension GL_NV_parameter_buffer_object2.
			/// </summary>
			[Extension("GL_NV_parameter_buffer_object2")]
			public bool ParameterBufferObject2_NV;

			/// <summary>
			/// Support for extension GL_NV_shader_buffer_load.
			/// </summary>
			[Extension("GL_NV_shader_buffer_load")]
			public bool ShaderBufferLoad_NV;

			/// <summary>
			/// Support for extension GL_NV_vertex_buffer_unified_memory.
			/// </summary>
			[Extension("GL_NV_vertex_buffer_unified_memory")]
			public bool VertexBufferUnifiedMemory_NV;

			/// <summary>
			/// Support for extension GL_NV_texture_barrier.
			/// </summary>
			[Extension("GL_NV_texture_barrier")]
			public bool TextureBarrier_NV;

			/// <summary>
			/// Support for extension GL_AMD_shader_stencil_export.
			/// </summary>
			[Extension("GL_AMD_shader_stencil_export")]
			public bool ShaderStencilExport_AMD;

			/// <summary>
			/// Support for extension GL_AMD_seamless_cubemap_per_texture.
			/// </summary>
			[Extension("GL_AMD_seamless_cubemap_per_texture")]
			public bool SeamlessCubemapPerTexture_AMD;

			/// <summary>
			/// Support for extension GL_AMD_conservative_depth.
			/// </summary>
			[Extension("GL_AMD_conservative_depth")]
			public bool ConservativeDepth_AMD;

			/// <summary>
			/// Support for extension GL_EXT_shader_image_load_store.
			/// </summary>
			[Extension("GL_EXT_shader_image_load_store")]
			public bool ShaderImageLoadStore_EXT;

			/// <summary>
			/// Support for extension GL_EXT_vertex_attrib_64bit.
			/// </summary>
			[Extension("GL_EXT_vertex_attrib_64bit")]
			public bool VertexAttrib64bit_EXT;

			/// <summary>
			/// Support for extension GL_NV_gpu_program5.
			/// </summary>
			[Extension("GL_NV_gpu_program5")]
			public bool GpuProgram5_NV;

			/// <summary>
			/// Support for extension GL_NV_gpu_shader5.
			/// </summary>
			[Extension("GL_NV_gpu_shader5")]
			public bool GpuShader5_NV;

			/// <summary>
			/// Support for extension GL_NV_shader_buffer_store.
			/// </summary>
			[Extension("GL_NV_shader_buffer_store")]
			public bool ShaderBufferStore_NV;

			/// <summary>
			/// Support for extension GL_NV_tessellation_program5.
			/// </summary>
			[Extension("GL_NV_tessellation_program5")]
			public bool TessellationProgram5_NV;

			/// <summary>
			/// Support for extension GL_NV_vertex_attrib_integer_64bit.
			/// </summary>
			[Extension("GL_NV_vertex_attrib_integer_64bit")]
			public bool VertexAttribInteger64bit_NV;

			/// <summary>
			/// Support for extension GL_NV_multisample_coverage.
			/// </summary>
			[Extension("GL_NV_multisample_coverage")]
			public bool MultisampleCoverage_NV;

			/// <summary>
			/// Support for extension GL_AMD_name_gen_delete.
			/// </summary>
			[Extension("GL_AMD_name_gen_delete")]
			public bool NameGenDelete_AMD;

			/// <summary>
			/// Support for extension GL_AMD_debug_output.
			/// </summary>
			[Extension("GL_AMD_debug_output")]
			public bool DebugOutput_AMD;

			/// <summary>
			/// Support for extension GL_NV_vdpau_interop.
			/// </summary>
			[Extension("GL_NV_vdpau_interop")]
			public bool VdpauInterop_NV;

			/// <summary>
			/// Support for extension GL_AMD_transform_feedback3_lines_triangles.
			/// </summary>
			[Extension("GL_AMD_transform_feedback3_lines_triangles")]
			public bool TransformFeedback3LinesTriangles_AMD;

			/// <summary>
			/// Support for extension GL_AMD_depth_clamp_separate.
			/// </summary>
			[Extension("GL_AMD_depth_clamp_separate")]
			public bool DepthClampSeparate_AMD;

			/// <summary>
			/// Support for extension GL_EXT_texture_sRGB_decode.
			/// </summary>
			[Extension("GL_EXT_texture_sRGB_decode")]
			public bool TextureSRGBDecode_EXT;

			/// <summary>
			/// Support for extension GL_NV_texture_multisample.
			/// </summary>
			[Extension("GL_NV_texture_multisample")]
			public bool TextureMultisample_NV;

			/// <summary>
			/// Support for extension GL_AMD_blend_minmax_factor.
			/// </summary>
			[Extension("GL_AMD_blend_minmax_factor")]
			public bool BlendMinmaxFactor_AMD;

			/// <summary>
			/// Support for extension GL_AMD_sample_positions.
			/// </summary>
			[Extension("GL_AMD_sample_positions")]
			public bool SamplePositions_AMD;

			/// <summary>
			/// Support for extension GL_EXT_x11_sync_object.
			/// </summary>
			[Extension("GL_EXT_x11_sync_object")]
			public bool X11SyncObject_EXT;

			/// <summary>
			/// Support for extension GL_AMD_multi_draw_indirect.
			/// </summary>
			[Extension("GL_AMD_multi_draw_indirect")]
			public bool MultiDrawIndirect_AMD;

			/// <summary>
			/// Support for extension GL_EXT_framebuffer_multisample_blit_scaled.
			/// </summary>
			[Extension("GL_EXT_framebuffer_multisample_blit_scaled")]
			public bool FramebufferMultisampleBlitScaled_EXT;

			/// <summary>
			/// Support for extension GL_NV_path_rendering.
			/// </summary>
			[Extension("GL_NV_path_rendering")]
			public bool PathRendering_NV;

			/// <summary>
			/// Support for extension GL_AMD_pinned_memory.
			/// </summary>
			[Extension("GL_AMD_pinned_memory")]
			public bool PinnedMemory_AMD;

			/// <summary>
			/// Support for extension GL_AMD_stencil_operation_extended.
			/// </summary>
			[Extension("GL_AMD_stencil_operation_extended")]
			public bool StencilOperationExtended_AMD;

			/// <summary>
			/// Support for extension GL_AMD_vertex_shader_viewport_index.
			/// </summary>
			[Extension("GL_AMD_vertex_shader_viewport_index")]
			public bool VertexShaderViewportIndex_AMD;

			/// <summary>
			/// Support for extension GL_AMD_vertex_shader_layer.
			/// </summary>
			[Extension("GL_AMD_vertex_shader_layer")]
			public bool VertexShaderLayer_AMD;

			/// <summary>
			/// Support for extension GL_NV_bindless_texture.
			/// </summary>
			[Extension("GL_NV_bindless_texture")]
			public bool BindlessTexture_NV;

			/// <summary>
			/// Support for extension GL_NV_shader_atomic_float.
			/// </summary>
			[Extension("GL_NV_shader_atomic_float")]
			public bool ShaderAtomicFloat_NV;

			/// <summary>
			/// Support for extension GL_AMD_query_buffer_object.
			/// </summary>
			[Extension("GL_AMD_query_buffer_object")]
			public bool QueryBufferObject_AMD;

			/// <summary>
			/// Support for extension GL_NV_compute_program5.
			/// </summary>
			[Extension("GL_NV_compute_program5")]
			public bool ComputeProgram5_NV;

			/// <summary>
			/// Support for extension GL_NV_shader_storage_buffer_object.
			/// </summary>
			[Extension("GL_NV_shader_storage_buffer_object")]
			public bool ShaderStorageBufferObject_NV;

			/// <summary>
			/// Support for extension GL_NV_shader_atomic_counters.
			/// </summary>
			[Extension("GL_NV_shader_atomic_counters")]
			public bool ShaderAtomicCounters_NV;

			/// <summary>
			/// Support for extension GL_NV_deep_texture3D.
			/// </summary>
			[Extension("GL_NV_deep_texture3D")]
			public bool DeepTexture3D_NV;

			/// <summary>
			/// Support for extension GL_NVX_conditional_render.
			/// </summary>
			[Extension("GL_NVX_conditional_render")]
			public bool ConditionalRender_NVX;

			/// <summary>
			/// Support for extension GL_AMD_sparse_texture.
			/// </summary>
			[Extension("GL_AMD_sparse_texture")]
			public bool SparseTexture_AMD;

			/// <summary>
			/// Support for extension GL_AMD_shader_trinary_minmax.
			/// </summary>
			[Extension("GL_AMD_shader_trinary_minmax")]
			public bool ShaderTrinaryMinmax_AMD;

			/// <summary>
			/// Support for extension GL_INTEL_map_texture.
			/// </summary>
			[Extension("GL_INTEL_map_texture")]
			public bool MapTexture_INTEL;

			/// <summary>
			/// Support for extension GL_NV_draw_texture.
			/// </summary>
			[Extension("GL_NV_draw_texture")]
			public bool DrawTexture_NV;

			/// <summary>
			/// Support for extension GL_AMD_interleaved_elements.
			/// </summary>
			[Extension("GL_AMD_interleaved_elements")]
			public bool InterleavedElements_AMD;

			/// <summary>
			/// Support for extension GL_NV_bindless_multi_draw_indirect.
			/// </summary>
			[Extension("GL_NV_bindless_multi_draw_indirect")]
			public bool BindlessMultiDrawIndirect_NV;

			/// <summary>
			/// Support for extension GL_NV_blend_equation_advanced.
			/// </summary>
			[Extension("GL_NV_blend_equation_advanced")]
			[Extension("GL_NV_blend_equation_advanced_coherent")]
			public bool BlendEquationAdvanced_NV;

			/// <summary>
			/// Support for extension GL_NV_gpu_program5_mem_extended.
			/// </summary>
			[Extension("GL_NV_gpu_program5_mem_extended")]
			public bool GpuProgram5MemExtended_NV;

			/// <summary>
			/// Support for extension GL_AMD_shader_atomic_counter_ops.
			/// </summary>
			[Extension("GL_AMD_shader_atomic_counter_ops")]
			public bool ShaderAtomicCounterOps_AMD;

			/// <summary>
			/// Support for extension GL_EXT_shader_integer_mix.
			/// </summary>
			[Extension("GL_EXT_shader_integer_mix")]
			public bool ShaderIntegerMix_EXT;

			/// <summary>
			/// Support for extension GL_NVX_gpu_memory_info.
			/// </summary>
			[Extension("GL_NVX_gpu_memory_info")]
			public bool GpuMemoryInfo_NVX;

			/// <summary>
			/// Support for extension GL_EXT_debug_label.
			/// </summary>
			[Extension("GL_EXT_debug_label")]
			public bool DebugLabel_EXT;

			/// <summary>
			/// Support for extension GL_EXT_debug_marker.
			/// </summary>
			[Extension("GL_EXT_debug_marker")]
			public bool DebugMarker_EXT;

			/// <summary>
			/// Support for extension GL_INTEL_fragment_shader_ordering.
			/// </summary>
			[Extension("GL_INTEL_fragment_shader_ordering")]
			public bool FragmentShaderOrdering_INTEL;

			/// <summary>
			/// Support for extension GL_AMD_occlusion_query_event.
			/// </summary>
			[Extension("GL_AMD_occlusion_query_event")]
			public bool OcclusionQueryEvent_AMD;

			/// <summary>
			/// Support for extension GL_INTEL_performance_query.
			/// </summary>
			[Extension("GL_INTEL_performance_query")]
			public bool PerformanceQuery_INTEL;

			/// <summary>
			/// Support for extension GL_NV_shader_thread_group.
			/// </summary>
			[Extension("GL_NV_shader_thread_group")]
			public bool ShaderThreadGroup_NV;

			/// <summary>
			/// Support for extension GL_NV_shader_thread_shuffle.
			/// </summary>
			[Extension("GL_NV_shader_thread_shuffle")]
			public bool ShaderThreadShuffle_NV;

			/// <summary>
			/// Support for extension GL_EXT_shader_image_load_formatted.
			/// </summary>
			[Extension("GL_EXT_shader_image_load_formatted")]
			public bool ShaderImageLoadFormatted_EXT;

			/// <summary>
			/// Support for extension GL_AMD_transform_feedback4.
			/// </summary>
			[Extension("GL_AMD_transform_feedback4")]
			public bool TransformFeedback4_AMD;

			/// <summary>
			/// Support for extension GL_AMD_gpu_shader_int64.
			/// </summary>
			[Extension("GL_AMD_gpu_shader_int64")]
			public bool GpuShaderInt64_AMD;

			/// <summary>
			/// Support for extension GL_AMD_gcn_shader.
			/// </summary>
			[Extension("GL_AMD_gcn_shader")]
			public bool GcnShader_AMD;

			/// <summary>
			/// Support for extension GL_NV_shader_atomic_int64.
			/// </summary>
			[Extension("GL_NV_shader_atomic_int64")]
			public bool ShaderAtomicInt64_NV;

			/// <summary>
			/// Support for extension GL_NV_bindless_multi_draw_indirect_count.
			/// </summary>
			[Extension("GL_NV_bindless_multi_draw_indirect_count")]
			public bool BindlessMultiDrawIndirectCount_NV;

			/// <summary>
			/// Support for extension GL_NV_uniform_buffer_unified_memory.
			/// </summary>
			[Extension("GL_NV_uniform_buffer_unified_memory")]
			public bool UniformBufferUnifiedMemory_NV;

			/// <summary>
			/// Support for extension GL_EXT_polygon_offset_clamp.
			/// </summary>
			[Extension("GL_EXT_polygon_offset_clamp")]
			public bool PolygonOffsetClamp_EXT;

			/// <summary>
			/// Support for extension GL_EXT_post_depth_coverage.
			/// </summary>
			[Extension("GL_EXT_post_depth_coverage")]
			public bool PostDepthCoverage_EXT;

			/// <summary>
			/// Support for extension GL_EXT_raster_multisample.
			/// </summary>
			[Extension("GL_EXT_raster_multisample")]
			public bool RasterMultisample_EXT;

			/// <summary>
			/// Support for extension GL_EXT_sparse_texture2.
			/// </summary>
			[Extension("GL_EXT_sparse_texture2")]
			public bool SparseTexture2_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_filter_minmax.
			/// </summary>
			[Extension("GL_EXT_texture_filter_minmax")]
			public bool TextureFilterMinmax_EXT;

			/// <summary>
			/// Support for extension GL_NV_conservative_raster.
			/// </summary>
			[Extension("GL_NV_conservative_raster")]
			public bool ConservativeRaster_NV;

			/// <summary>
			/// Support for extension GL_NV_fill_rectangle.
			/// </summary>
			[Extension("GL_NV_fill_rectangle")]
			public bool FillRectangle_NV;

			/// <summary>
			/// Support for extension GL_NV_fragment_coverage_to_color.
			/// </summary>
			[Extension("GL_NV_fragment_coverage_to_color")]
			public bool FragmentCoverageToColor_NV;

			/// <summary>
			/// Support for extension GL_NV_fragment_shader_interlock.
			/// </summary>
			[Extension("GL_NV_fragment_shader_interlock")]
			public bool FragmentShaderInterlock_NV;

			/// <summary>
			/// Support for extension GL_NV_framebuffer_mixed_samples.
			/// </summary>
			[Extension("GL_NV_framebuffer_mixed_samples")]
			public bool FramebufferMixedSamples_NV;

			/// <summary>
			/// Support for extension GL_NV_geometry_shader_passthrough.
			/// </summary>
			[Extension("GL_NV_geometry_shader_passthrough")]
			public bool GeometryShaderPassthrough_NV;

			/// <summary>
			/// Support for extension GL_NV_path_rendering_shared_edge.
			/// </summary>
			[Extension("GL_NV_path_rendering_shared_edge")]
			public bool PathRenderingSharedEdge_NV;

			/// <summary>
			/// Support for extension GL_NV_sample_locations.
			/// </summary>
			[Extension("GL_NV_sample_locations")]
			public bool SampleLocations_NV;

			/// <summary>
			/// Support for extension GL_NV_sample_mask_override_coverage.
			/// </summary>
			[Extension("GL_NV_sample_mask_override_coverage")]
			public bool SampleMaskOverrideCoverage_NV;

			/// <summary>
			/// Support for extension GL_NV_shader_atomic_fp16_vector.
			/// </summary>
			[Extension("GL_NV_shader_atomic_fp16_vector")]
			public bool ShaderAtomicFp16Vector_NV;

			/// <summary>
			/// Support for extension GL_NV_internalformat_sample_query.
			/// </summary>
			[Extension("GL_NV_internalformat_sample_query")]
			public bool InternalformatSampleQuery_NV;

			/// <summary>
			/// Support for extension GL_NV_viewport_array2.
			/// </summary>
			[Extension("GL_NV_viewport_array2")]
			public bool ViewportArray2_NV;

			/// <summary>
			/// Support for extension GL_SGIX_ycrcba.
			/// </summary>
			[Extension("GL_SGIX_ycrcba")]
			public bool Ycrcba_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_ycrcb_subsample.
			/// </summary>
			[Extension("GL_SGIX_ycrcb_subsample")]
			public bool YcrcbSubsample_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_subsample.
			/// </summary>
			[Extension("GL_SGIX_subsample")]
			public bool Subsample_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_scalebias_hint.
			/// </summary>
			[Extension("GL_SGIX_scalebias_hint")]
			public bool ScalebiasHint_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_polynomial_ffd.
			/// </summary>
			[Extension("GL_SGIX_polynomial_ffd")]
			public bool PolynomialFfd_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_pixel_tiles.
			/// </summary>
			[Extension("GL_SGIX_pixel_tiles")]
			public bool PixelTiles_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_igloo_interface.
			/// </summary>
			[Extension("GL_SGIX_igloo_interface")]
			public bool IglooInterface_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_fragment_lighting.
			/// </summary>
			[Extension("GL_SGIX_fragment_lighting")]
			public bool FragmentLighting_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_depth_pass_instrument.
			/// </summary>
			[Extension("GL_SGIX_depth_pass_instrument")]
			public bool DepthPassInstrument_SGIX;

			/// <summary>
			/// Support for extension GL_SGIX_calligraphic_fragment.
			/// </summary>
			[Extension("GL_SGIX_calligraphic_fragment")]
			public bool CalligraphicFragment_SGIX;

			/// <summary>
			/// Support for extension GL_SGIS_point_parameters.
			/// </summary>
			[Extension("GL_SGIS_point_parameters")]
			public bool PointParameters_SGIS;

			/// <summary>
			/// Support for extension GL_OVR_multiview2.
			/// </summary>
			[Extension("GL_OVR_multiview2")]
			public bool Multiview2_OVR;

			/// <summary>
			/// Support for extension GL_OVR_multiview.
			/// </summary>
			[Extension("GL_OVR_multiview")]
			public bool Multiview_OVR;

			/// <summary>
			/// Support for extension GL_NV_conservative_raster_dilate.
			/// </summary>
			[Extension("GL_NV_conservative_raster_dilate")]
			public bool ConservativeRasterDilate_NV;

			/// <summary>
			/// Support for extension GL_NV_command_list.
			/// </summary>
			[Extension("GL_NV_command_list")]
			public bool CommandList_NV;

			/// <summary>
			/// Support for extension GL_INTEL_framebuffer_CMAA.
			/// </summary>
			[Extension("GL_INTEL_framebuffer_CMAA")]
			public bool FramebufferCMAA_INTEL;

			/// <summary>
			/// Support for extension GL_INGR_blend_func_separate.
			/// </summary>
			[Extension("GL_INGR_blend_func_separate")]
			public bool BlendFuncSeparate_INGR;

			/// <summary>
			/// Support for extension GL_EXT_texture_cube_map.
			/// </summary>
			[Extension("GL_EXT_texture_cube_map")]
			public bool TextureCubeMap_EXT;

			/// <summary>
			/// Support for extension GL_ATI_pixel_format_float.
			/// </summary>
			[Extension("GL_ATI_pixel_format_float")]
			public bool PixelFormatFloat_ATI;

			/// <summary>
			/// Support for extension GL_AMD_compressed_3DC_texture.
			/// </summary>
			[Extension("GL_AMD_compressed_3DC_texture")]
			public bool Compressed3DCTexture_AMD;

			/// <summary>
			/// Support for extension GL_AMD_compressed_ATC_texture.
			/// </summary>
			[Extension("GL_AMD_compressed_ATC_texture")]
			public bool CompressedATCTexture_AMD;

			/// <summary>
			/// Support for extension GL_AMD_program_binary_Z400.
			/// </summary>
			[Extension("GL_AMD_program_binary_Z400")]
			public bool ProgramBinaryZ400_AMD;

			/// <summary>
			/// Support for extension GL_ANDROID_extension_pack_es31a.
			/// </summary>
			[Extension("GL_ANDROID_extension_pack_es31a")]
			public bool ExtensionPackEs31a_ANDROID;

			/// <summary>
			/// Support for extension GL_ANGLE_depth_texture.
			/// </summary>
			[Extension("GL_ANGLE_depth_texture")]
			public bool DepthTexture_ANGLE;

			/// <summary>
			/// Support for extension GL_ANGLE_framebuffer_blit.
			/// </summary>
			[Extension("GL_ANGLE_framebuffer_blit")]
			public bool FramebufferBlit_ANGLE;

			/// <summary>
			/// Support for extension GL_ANGLE_framebuffer_multisample.
			/// </summary>
			[Extension("GL_ANGLE_framebuffer_multisample")]
			public bool FramebufferMultisample_ANGLE;

			/// <summary>
			/// Support for extension GL_ANGLE_instanced_arrays.
			/// </summary>
			[Extension("GL_ANGLE_instanced_arrays")]
			public bool InstancedArrays_ANGLE;

			/// <summary>
			/// Support for extension GL_ANGLE_pack_reverse_row_order.
			/// </summary>
			[Extension("GL_ANGLE_pack_reverse_row_order")]
			public bool PackReverseRowOrder_ANGLE;

			/// <summary>
			/// Support for extension GL_ANGLE_program_binary.
			/// </summary>
			[Extension("GL_ANGLE_program_binary")]
			public bool ProgramBinary_ANGLE;

			/// <summary>
			/// Support for extension GL_ANGLE_texture_compression_dxt3.
			/// </summary>
			[Extension("GL_ANGLE_texture_compression_dxt3")]
			public bool TextureCompressionDxt3_ANGLE;

			/// <summary>
			/// Support for extension GL_ANGLE_texture_compression_dxt5.
			/// </summary>
			[Extension("GL_ANGLE_texture_compression_dxt5")]
			public bool TextureCompressionDxt5_ANGLE;

			/// <summary>
			/// Support for extension GL_ANGLE_texture_usage.
			/// </summary>
			[Extension("GL_ANGLE_texture_usage")]
			public bool TextureUsage_ANGLE;

			/// <summary>
			/// Support for extension GL_ANGLE_translated_shader_source.
			/// </summary>
			[Extension("GL_ANGLE_translated_shader_source")]
			public bool TranslatedShaderSource_ANGLE;

			/// <summary>
			/// Support for extension GL_APPLE_clip_distance.
			/// </summary>
			[Extension("GL_APPLE_clip_distance")]
			public bool ClipDistance_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_color_buffer_packed_float.
			/// </summary>
			[Extension("GL_APPLE_color_buffer_packed_float")]
			public bool ColorBufferPackedFloat_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_copy_texture_levels.
			/// </summary>
			[Extension("GL_APPLE_copy_texture_levels")]
			public bool CopyTextureLevels_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_framebuffer_multisample.
			/// </summary>
			[Extension("GL_APPLE_framebuffer_multisample")]
			public bool FramebufferMultisample_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_sync.
			/// </summary>
			[Extension("GL_APPLE_sync")]
			public bool Sync_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_texture_2D_limited_npot.
			/// </summary>
			[Extension("GL_APPLE_texture_2D_limited_npot")]
			public bool Texture2DLimitedNpot_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_texture_format_BGRA8888.
			/// </summary>
			[Extension("GL_APPLE_texture_format_BGRA8888")]
			public bool TextureFormatBGRA8888_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_texture_max_level.
			/// </summary>
			[Extension("GL_APPLE_texture_max_level")]
			public bool TextureMaxLevel_APPLE;

			/// <summary>
			/// Support for extension GL_APPLE_texture_packed_float.
			/// </summary>
			[Extension("GL_APPLE_texture_packed_float")]
			public bool TexturePackedFloat_APPLE;

			/// <summary>
			/// Support for extension GL_ARM_mali_program_binary.
			/// </summary>
			[Extension("GL_ARM_mali_program_binary")]
			public bool MaliProgramBinary_ARM;

			/// <summary>
			/// Support for extension GL_ARM_mali_shader_binary.
			/// </summary>
			[Extension("GL_ARM_mali_shader_binary")]
			public bool MaliShaderBinary_ARM;

			/// <summary>
			/// Support for extension GL_ARM_rgba8.
			/// </summary>
			[Extension("GL_ARM_rgba8")]
			public bool Rgba8_ARM;

			/// <summary>
			/// Support for extension GL_ARM_shader_framebuffer_fetch.
			/// </summary>
			[Extension("GL_ARM_shader_framebuffer_fetch")]
			public bool ShaderFramebufferFetch_ARM;

			/// <summary>
			/// Support for extension GL_ARM_shader_framebuffer_fetch_depth_stencil.
			/// </summary>
			[Extension("GL_ARM_shader_framebuffer_fetch_depth_stencil")]
			public bool ShaderFramebufferFetchDepthStencil_ARM;

			/// <summary>
			/// Support for extension GL_DMP_program_binary.
			/// </summary>
			[Extension("GL_DMP_program_binary")]
			public bool ProgramBinary_DMP;

			/// <summary>
			/// Support for extension GL_DMP_shader_binary.
			/// </summary>
			[Extension("GL_DMP_shader_binary")]
			public bool ShaderBinary_DMP;

			/// <summary>
			/// Support for extension GL_EXT_YUV_target.
			/// </summary>
			[Extension("GL_EXT_YUV_target")]
			public bool YUVTarget_EXT;

			/// <summary>
			/// Support for extension GL_EXT_base_instance.
			/// </summary>
			[Extension("GL_EXT_base_instance")]
			public bool BaseInstance_EXT;

			/// <summary>
			/// Support for extension GL_EXT_blend_func_extended.
			/// </summary>
			[Extension("GL_EXT_blend_func_extended")]
			public bool BlendFuncExtended_EXT;

			/// <summary>
			/// Support for extension GL_EXT_buffer_storage.
			/// </summary>
			[Extension("GL_EXT_buffer_storage")]
			public bool BufferStorage_EXT;

			/// <summary>
			/// Support for extension GL_EXT_color_buffer_float.
			/// </summary>
			[Extension("GL_EXT_color_buffer_float")]
			public bool ColorBufferFloat_EXT;

			/// <summary>
			/// Support for extension GL_EXT_color_buffer_half_float.
			/// </summary>
			[Extension("GL_EXT_color_buffer_half_float")]
			public bool ColorBufferHalfFloat_EXT;

			/// <summary>
			/// Support for extension GL_EXT_copy_image.
			/// </summary>
			[Extension("GL_EXT_copy_image")]
			public bool CopyImage_EXT;

			/// <summary>
			/// Support for extension GL_EXT_discard_framebuffer.
			/// </summary>
			[Extension("GL_EXT_discard_framebuffer")]
			public bool DiscardFramebuffer_EXT;

			/// <summary>
			/// Support for extension GL_EXT_disjoint_timer_query.
			/// </summary>
			[Extension("GL_EXT_disjoint_timer_query")]
			public bool DisjointTimerQuery_EXT;

			/// <summary>
			/// Support for extension GL_EXT_draw_buffers.
			/// </summary>
			[Extension("GL_EXT_draw_buffers")]
			public bool DrawBuffers_EXT;

			/// <summary>
			/// Support for extension GL_EXT_draw_buffers_indexed.
			/// </summary>
			[Extension("GL_EXT_draw_buffers_indexed")]
			public bool DrawBuffersIndexed_EXT;

			/// <summary>
			/// Support for extension GL_EXT_draw_elements_base_vertex.
			/// </summary>
			[Extension("GL_EXT_draw_elements_base_vertex")]
			public bool DrawElementsBaseVertex_EXT;

			/// <summary>
			/// Support for extension GL_EXT_float_blend.
			/// </summary>
			[Extension("GL_EXT_float_blend")]
			public bool FloatBlend_EXT;

			/// <summary>
			/// Support for extension GL_EXT_geometry_point_size.
			/// </summary>
			[Extension("GL_EXT_geometry_point_size")]
			public bool GeometryPointSize_EXT;

			/// <summary>
			/// Support for extension GL_EXT_geometry_shader.
			/// </summary>
			[Extension("GL_EXT_geometry_shader")]
			public bool GeometryShader_EXT;

			/// <summary>
			/// Support for extension GL_EXT_gpu_shader5.
			/// </summary>
			[Extension("GL_EXT_gpu_shader5")]
			public bool GpuShader5_EXT;

			/// <summary>
			/// Support for extension GL_EXT_instanced_arrays.
			/// </summary>
			[Extension("GL_EXT_instanced_arrays")]
			public bool InstancedArrays_EXT;

			/// <summary>
			/// Support for extension GL_EXT_map_buffer_range.
			/// </summary>
			[Extension("GL_EXT_map_buffer_range")]
			public bool MapBufferRange_EXT;

			/// <summary>
			/// Support for extension GL_EXT_multi_draw_indirect.
			/// </summary>
			[Extension("GL_EXT_multi_draw_indirect")]
			public bool MultiDrawIndirect_EXT;

			/// <summary>
			/// Support for extension GL_EXT_multisampled_compatibility.
			/// </summary>
			[Extension("GL_EXT_multisampled_compatibility")]
			public bool MultisampledCompatibility_EXT;

			/// <summary>
			/// Support for extension GL_EXT_multisampled_render_to_texture.
			/// </summary>
			[Extension("GL_EXT_multisampled_render_to_texture")]
			public bool MultisampledRenderToTexture_EXT;

			/// <summary>
			/// Support for extension GL_EXT_multiview_draw_buffers.
			/// </summary>
			[Extension("GL_EXT_multiview_draw_buffers")]
			public bool MultiviewDrawBuffers_EXT;

			/// <summary>
			/// Support for extension GL_EXT_occlusion_query_boolean.
			/// </summary>
			[Extension("GL_EXT_occlusion_query_boolean")]
			public bool OcclusionQueryBoolean_EXT;

			/// <summary>
			/// Support for extension GL_EXT_primitive_bounding_box.
			/// </summary>
			[Extension("GL_EXT_primitive_bounding_box")]
			public bool PrimitiveBoundingBox_EXT;

			/// <summary>
			/// Support for extension GL_EXT_pvrtc_sRGB.
			/// </summary>
			[Extension("GL_EXT_pvrtc_sRGB")]
			public bool PvrtcSRGB_EXT;

			/// <summary>
			/// Support for extension GL_EXT_read_format_bgra.
			/// </summary>
			[Extension("GL_EXT_read_format_bgra")]
			public bool ReadFormatBgra_EXT;

			/// <summary>
			/// Support for extension GL_EXT_render_snorm.
			/// </summary>
			[Extension("GL_EXT_render_snorm")]
			public bool RenderSnorm_EXT;

			/// <summary>
			/// Support for extension GL_EXT_robustness.
			/// </summary>
			[Extension("GL_EXT_robustness")]
			public bool Robustness_EXT;

			/// <summary>
			/// Support for extension GL_EXT_sRGB.
			/// </summary>
			[Extension("GL_EXT_sRGB")]
			public bool SRGB_EXT;

			/// <summary>
			/// Support for extension GL_EXT_sRGB_write_control.
			/// </summary>
			[Extension("GL_EXT_sRGB_write_control")]
			public bool SRGBWriteControl_EXT;

			/// <summary>
			/// Support for extension GL_EXT_shader_framebuffer_fetch.
			/// </summary>
			[Extension("GL_EXT_shader_framebuffer_fetch")]
			public bool ShaderFramebufferFetch_EXT;

			/// <summary>
			/// Support for extension GL_EXT_shader_implicit_conversions.
			/// </summary>
			[Extension("GL_EXT_shader_implicit_conversions")]
			public bool ShaderImplicitConversions_EXT;

			/// <summary>
			/// Support for extension GL_EXT_shader_io_blocks.
			/// </summary>
			[Extension("GL_EXT_shader_io_blocks")]
			public bool ShaderIoBlocks_EXT;

			/// <summary>
			/// Support for extension GL_EXT_shader_pixel_local_storage.
			/// </summary>
			[Extension("GL_EXT_shader_pixel_local_storage")]
			public bool ShaderPixelLocalStorage_EXT;

			/// <summary>
			/// Support for extension GL_EXT_shader_texture_lod.
			/// </summary>
			[Extension("GL_EXT_shader_texture_lod")]
			public bool ShaderTextureLod_EXT;

			/// <summary>
			/// Support for extension GL_EXT_shadow_samplers.
			/// </summary>
			[Extension("GL_EXT_shadow_samplers")]
			public bool ShadowSamplers_EXT;

			/// <summary>
			/// Support for extension GL_EXT_sparse_texture.
			/// </summary>
			[Extension("GL_EXT_sparse_texture")]
			public bool SparseTexture_EXT;

			/// <summary>
			/// Support for extension GL_EXT_tessellation_point_size.
			/// </summary>
			[Extension("GL_EXT_tessellation_point_size")]
			public bool TessellationPointSize_EXT;

			/// <summary>
			/// Support for extension GL_EXT_tessellation_shader.
			/// </summary>
			[Extension("GL_EXT_tessellation_shader")]
			public bool TessellationShader_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_border_clamp.
			/// </summary>
			[Extension("GL_EXT_texture_border_clamp")]
			public bool TextureBorderClamp_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_buffer.
			/// </summary>
			[Extension("GL_EXT_texture_buffer")]
			public bool TextureBuffer_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_cube_map_array.
			/// </summary>
			[Extension("GL_EXT_texture_cube_map_array")]
			public bool TextureCubeMapArray_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_format_BGRA8888.
			/// </summary>
			[Extension("GL_EXT_texture_format_BGRA8888")]
			public bool TextureFormatBGRA8888_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_norm16.
			/// </summary>
			[Extension("GL_EXT_texture_norm16")]
			public bool TextureNorm16_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_rg.
			/// </summary>
			[Extension("GL_EXT_texture_rg")]
			public bool TextureRg_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_sRGB_R8.
			/// </summary>
			[Extension("GL_EXT_texture_sRGB_R8")]
			public bool TextureSRGBR8_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_sRGB_RG8.
			/// </summary>
			[Extension("GL_EXT_texture_sRGB_RG8")]
			public bool TextureSRGBRG8_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_storage.
			/// </summary>
			[Extension("GL_EXT_texture_storage")]
			public bool TextureStorage_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_type_2_10_10_10_REV.
			/// </summary>
			[Extension("GL_EXT_texture_type_2_10_10_10_REV")]
			public bool TextureType2101010REV_EXT;

			/// <summary>
			/// Support for extension GL_EXT_texture_view.
			/// </summary>
			[Extension("GL_EXT_texture_view")]
			public bool TextureView_EXT;

			/// <summary>
			/// Support for extension GL_EXT_unpack_subimage.
			/// </summary>
			[Extension("GL_EXT_unpack_subimage")]
			public bool UnpackSubimage_EXT;

			/// <summary>
			/// Support for extension GL_FJ_shader_binary_GCCSO.
			/// </summary>
			[Extension("GL_FJ_shader_binary_GCCSO")]
			public bool ShaderBinaryGCCSO_FJ;

			/// <summary>
			/// Support for extension GL_IMG_multisampled_render_to_texture.
			/// </summary>
			[Extension("GL_IMG_multisampled_render_to_texture")]
			public bool MultisampledRenderToTexture_IMG;

			/// <summary>
			/// Support for extension GL_IMG_program_binary.
			/// </summary>
			[Extension("GL_IMG_program_binary")]
			public bool ProgramBinary_IMG;

			/// <summary>
			/// Support for extension GL_IMG_read_format.
			/// </summary>
			[Extension("GL_IMG_read_format")]
			public bool ReadFormat_IMG;

			/// <summary>
			/// Support for extension GL_IMG_shader_binary.
			/// </summary>
			[Extension("GL_IMG_shader_binary")]
			public bool ShaderBinary_IMG;

			/// <summary>
			/// Support for extension GL_IMG_texture_compression_pvrtc.
			/// </summary>
			[Extension("GL_IMG_texture_compression_pvrtc")]
			public bool TextureCompressionPvrtc_IMG;

			/// <summary>
			/// Support for extension GL_IMG_texture_compression_pvrtc2.
			/// </summary>
			[Extension("GL_IMG_texture_compression_pvrtc2")]
			public bool TextureCompressionPvrtc2_IMG;

			/// <summary>
			/// Support for extension GL_IMG_texture_env_enhanced_fixed_function.
			/// </summary>
			[Extension("GL_IMG_texture_env_enhanced_fixed_function")]
			public bool TextureEnvEnhancedFixedFunction_IMG;

			/// <summary>
			/// Support for extension GL_IMG_texture_filter_cubic.
			/// </summary>
			[Extension("GL_IMG_texture_filter_cubic")]
			public bool TextureFilterCubic_IMG;

			/// <summary>
			/// Support for extension GL_IMG_user_clip_plane.
			/// </summary>
			[Extension("GL_IMG_user_clip_plane")]
			public bool UserClipPlane_IMG;

			/// <summary>
			/// Support for extension GL_NV_copy_buffer.
			/// </summary>
			[Extension("GL_NV_copy_buffer")]
			public bool CopyBuffer_NV;

			/// <summary>
			/// Support for extension GL_NV_coverage_sample.
			/// </summary>
			[Extension("GL_NV_coverage_sample")]
			public bool CoverageSample_NV;

			/// <summary>
			/// Support for extension GL_NV_depth_nonlinear.
			/// </summary>
			[Extension("GL_NV_depth_nonlinear")]
			public bool DepthNonlinear_NV;

			/// <summary>
			/// Support for extension GL_NV_draw_buffers.
			/// </summary>
			[Extension("GL_NV_draw_buffers")]
			public bool DrawBuffers_NV;

			/// <summary>
			/// Support for extension GL_NV_draw_instanced.
			/// </summary>
			[Extension("GL_NV_draw_instanced")]
			public bool DrawInstanced_NV;

			/// <summary>
			/// Support for extension GL_NV_explicit_attrib_location.
			/// </summary>
			[Extension("GL_NV_explicit_attrib_location")]
			public bool ExplicitAttribLocation_NV;

			/// <summary>
			/// Support for extension GL_NV_fbo_color_attachments.
			/// </summary>
			[Extension("GL_NV_fbo_color_attachments")]
			public bool FboColorAttachments_NV;

			/// <summary>
			/// Support for extension GL_NV_framebuffer_blit.
			/// </summary>
			[Extension("GL_NV_framebuffer_blit")]
			public bool FramebufferBlit_NV;

			/// <summary>
			/// Support for extension GL_NV_framebuffer_multisample.
			/// </summary>
			[Extension("GL_NV_framebuffer_multisample")]
			public bool FramebufferMultisample_NV;

			/// <summary>
			/// Support for extension GL_NV_generate_mipmap_sRGB.
			/// </summary>
			[Extension("GL_NV_generate_mipmap_sRGB")]
			public bool GenerateMipmapSRGB_NV;

			/// <summary>
			/// Support for extension GL_NV_image_formats.
			/// </summary>
			[Extension("GL_NV_image_formats")]
			public bool ImageFormats_NV;

			/// <summary>
			/// Support for extension GL_NV_instanced_arrays.
			/// </summary>
			[Extension("GL_NV_instanced_arrays")]
			public bool InstancedArrays_NV;

			/// <summary>
			/// Support for extension GL_NV_non_square_matrices.
			/// </summary>
			[Extension("GL_NV_non_square_matrices")]
			public bool NonSquareMatrices_NV;

			/// <summary>
			/// Support for extension GL_NV_polygon_mode.
			/// </summary>
			[Extension("GL_NV_polygon_mode")]
			public bool PolygonMode_NV;

			/// <summary>
			/// Support for extension GL_NV_read_buffer.
			/// </summary>
			[Extension("GL_NV_read_buffer")]
			public bool ReadBuffer_NV;

			/// <summary>
			/// Support for extension GL_NV_read_buffer_front.
			/// </summary>
			[Extension("GL_NV_read_buffer_front")]
			public bool ReadBufferFront_NV;

			/// <summary>
			/// Support for extension GL_NV_read_depth.
			/// </summary>
			[Extension("GL_NV_read_depth")]
			public bool ReadDepth_NV;

			/// <summary>
			/// Support for extension GL_NV_read_depth_stencil.
			/// </summary>
			[Extension("GL_NV_read_depth_stencil")]
			public bool ReadDepthStencil_NV;

			/// <summary>
			/// Support for extension GL_NV_read_stencil.
			/// </summary>
			[Extension("GL_NV_read_stencil")]
			public bool ReadStencil_NV;

			/// <summary>
			/// Support for extension GL_NV_sRGB_formats.
			/// </summary>
			[Extension("GL_NV_sRGB_formats")]
			public bool SRGBFormats_NV;

			/// <summary>
			/// Support for extension GL_NV_shader_noperspective_interpolation.
			/// </summary>
			[Extension("GL_NV_shader_noperspective_interpolation")]
			public bool ShaderNoperspectiveInterpolation_NV;

			/// <summary>
			/// Support for extension GL_NV_shadow_samplers_array.
			/// </summary>
			[Extension("GL_NV_shadow_samplers_array")]
			public bool ShadowSamplersArray_NV;

			/// <summary>
			/// Support for extension GL_NV_shadow_samplers_cube.
			/// </summary>
			[Extension("GL_NV_shadow_samplers_cube")]
			public bool ShadowSamplersCube_NV;

			/// <summary>
			/// Support for extension GL_NV_texture_border_clamp.
			/// </summary>
			[Extension("GL_NV_texture_border_clamp")]
			public bool TextureBorderClamp_NV;

			/// <summary>
			/// Support for extension GL_NV_texture_compression_s3tc_update.
			/// </summary>
			[Extension("GL_NV_texture_compression_s3tc_update")]
			public bool TextureCompressionS3tcUpdate_NV;

			/// <summary>
			/// Support for extension GL_NV_texture_npot_2D_mipmap.
			/// </summary>
			[Extension("GL_NV_texture_npot_2D_mipmap")]
			public bool TextureNpot2DMipmap_NV;

			/// <summary>
			/// Support for extension GL_NV_viewport_array.
			/// </summary>
			[Extension("GL_NV_viewport_array")]
			public bool ViewportArray_NV;

			/// <summary>
			/// Support for extension GL_OES_EGL_image.
			/// </summary>
			[Extension("GL_OES_EGL_image")]
			public bool EGLImage_OES;

			/// <summary>
			/// Support for extension GL_OES_EGL_image_external.
			/// </summary>
			[Extension("GL_OES_EGL_image_external")]
			public bool EGLImageExternal_OES;

			/// <summary>
			/// Support for extension GL_OES_EGL_image_external_essl3.
			/// </summary>
			[Extension("GL_OES_EGL_image_external_essl3")]
			public bool EGLImageExternalEssl3_OES;

			/// <summary>
			/// Support for extension GL_OES_blend_equation_separate.
			/// </summary>
			[Extension("GL_OES_blend_equation_separate")]
			public bool BlendEquationSeparate_OES;

			/// <summary>
			/// Support for extension GL_OES_blend_func_separate.
			/// </summary>
			[Extension("GL_OES_blend_func_separate")]
			public bool BlendFuncSeparate_OES;

			/// <summary>
			/// Support for extension GL_OES_blend_subtract.
			/// </summary>
			[Extension("GL_OES_blend_subtract")]
			public bool BlendSubtract_OES;

			/// <summary>
			/// Support for extension GL_OES_compressed_ETC1_RGB8_sub_texture.
			/// </summary>
			[Extension("GL_OES_compressed_ETC1_RGB8_sub_texture")]
			public bool CompressedETC1RGB8SubTexture_OES;

			/// <summary>
			/// Support for extension GL_OES_compressed_ETC1_RGB8_texture.
			/// </summary>
			[Extension("GL_OES_compressed_ETC1_RGB8_texture")]
			public bool CompressedETC1RGB8Texture_OES;

			/// <summary>
			/// Support for extension GL_OES_copy_image.
			/// </summary>
			[Extension("GL_OES_copy_image")]
			public bool CopyImage_OES;

			/// <summary>
			/// Support for extension GL_OES_depth24.
			/// </summary>
			[Extension("GL_OES_depth24")]
			public bool Depth24_OES;

			/// <summary>
			/// Support for extension GL_OES_depth32.
			/// </summary>
			[Extension("GL_OES_depth32")]
			public bool Depth32_OES;

			/// <summary>
			/// Support for extension GL_OES_depth_texture.
			/// </summary>
			[Extension("GL_OES_depth_texture")]
			public bool DepthTexture_OES;

			/// <summary>
			/// Support for extension GL_OES_draw_buffers_indexed.
			/// </summary>
			[Extension("GL_OES_draw_buffers_indexed")]
			public bool DrawBuffersIndexed_OES;

			/// <summary>
			/// Support for extension GL_OES_draw_elements_base_vertex.
			/// </summary>
			[Extension("GL_OES_draw_elements_base_vertex")]
			public bool DrawElementsBaseVertex_OES;

			/// <summary>
			/// Support for extension GL_OES_draw_texture.
			/// </summary>
			[Extension("GL_OES_draw_texture")]
			public bool DrawTexture_OES;

			/// <summary>
			/// Support for extension GL_OES_element_index_uint.
			/// </summary>
			[Extension("GL_OES_element_index_uint")]
			public bool ElementIndexUint_OES;

			/// <summary>
			/// Support for extension GL_OES_extended_matrix_palette.
			/// </summary>
			[Extension("GL_OES_extended_matrix_palette")]
			public bool ExtendedMatrixPalette_OES;

			/// <summary>
			/// Support for extension GL_OES_fbo_render_mipmap.
			/// </summary>
			[Extension("GL_OES_fbo_render_mipmap")]
			public bool FboRenderMipmap_OES;

			/// <summary>
			/// Support for extension GL_OES_fragment_precision_high.
			/// </summary>
			[Extension("GL_OES_fragment_precision_high")]
			public bool FragmentPrecisionHigh_OES;

			/// <summary>
			/// Support for extension GL_OES_framebuffer_object.
			/// </summary>
			[Extension("GL_OES_framebuffer_object")]
			public bool FramebufferObject_OES;

			/// <summary>
			/// Support for extension GL_OES_geometry_point_size.
			/// </summary>
			[Extension("GL_OES_geometry_point_size")]
			public bool GeometryPointSize_OES;

			/// <summary>
			/// Support for extension GL_OES_geometry_shader.
			/// </summary>
			[Extension("GL_OES_geometry_shader")]
			public bool GeometryShader_OES;

			/// <summary>
			/// Support for extension GL_OES_get_program_binary.
			/// </summary>
			[Extension("GL_OES_get_program_binary")]
			public bool GetProgramBinary_OES;

			/// <summary>
			/// Support for extension GL_OES_gpu_shader5.
			/// </summary>
			[Extension("GL_OES_gpu_shader5")]
			public bool GpuShader5_OES;

			/// <summary>
			/// Support for extension GL_OES_mapbuffer.
			/// </summary>
			[Extension("GL_OES_mapbuffer")]
			public bool Mapbuffer_OES;

			/// <summary>
			/// Support for extension GL_OES_matrix_get.
			/// </summary>
			[Extension("GL_OES_matrix_get")]
			public bool MatrixGet_OES;

			/// <summary>
			/// Support for extension GL_OES_matrix_palette.
			/// </summary>
			[Extension("GL_OES_matrix_palette")]
			public bool MatrixPalette_OES;

			/// <summary>
			/// Support for extension GL_OES_packed_depth_stencil.
			/// </summary>
			[Extension("GL_OES_packed_depth_stencil")]
			public bool PackedDepthStencil_OES;

			/// <summary>
			/// Support for extension GL_OES_point_size_array.
			/// </summary>
			[Extension("GL_OES_point_size_array")]
			public bool PointSizeArray_OES;

			/// <summary>
			/// Support for extension GL_OES_point_sprite.
			/// </summary>
			[Extension("GL_OES_point_sprite")]
			public bool PointSprite_OES;

			/// <summary>
			/// Support for extension GL_OES_primitive_bounding_box.
			/// </summary>
			[Extension("GL_OES_primitive_bounding_box")]
			public bool PrimitiveBoundingBox_OES;

			/// <summary>
			/// Support for extension GL_OES_required_internalformat.
			/// </summary>
			[Extension("GL_OES_required_internalformat")]
			public bool RequiredInternalformat_OES;

			/// <summary>
			/// Support for extension GL_OES_rgb8_rgba8.
			/// </summary>
			[Extension("GL_OES_rgb8_rgba8")]
			public bool Rgb8Rgba8_OES;

			/// <summary>
			/// Support for extension GL_OES_sample_shading.
			/// </summary>
			[Extension("GL_OES_sample_shading")]
			public bool SampleShading_OES;

			/// <summary>
			/// Support for extension GL_OES_sample_variables.
			/// </summary>
			[Extension("GL_OES_sample_variables")]
			public bool SampleVariables_OES;

			/// <summary>
			/// Support for extension GL_OES_shader_image_atomic.
			/// </summary>
			[Extension("GL_OES_shader_image_atomic")]
			public bool ShaderImageAtomic_OES;

			/// <summary>
			/// Support for extension GL_OES_shader_io_blocks.
			/// </summary>
			[Extension("GL_OES_shader_io_blocks")]
			public bool ShaderIoBlocks_OES;

			/// <summary>
			/// Support for extension GL_OES_shader_multisample_interpolation.
			/// </summary>
			[Extension("GL_OES_shader_multisample_interpolation")]
			public bool ShaderMultisampleInterpolation_OES;

			/// <summary>
			/// Support for extension GL_OES_standard_derivatives.
			/// </summary>
			[Extension("GL_OES_standard_derivatives")]
			public bool StandardDerivatives_OES;

			/// <summary>
			/// Support for extension GL_OES_stencil1.
			/// </summary>
			[Extension("GL_OES_stencil1")]
			public bool Stencil1_OES;

			/// <summary>
			/// Support for extension GL_OES_stencil4.
			/// </summary>
			[Extension("GL_OES_stencil4")]
			public bool Stencil4_OES;

			/// <summary>
			/// Support for extension GL_OES_stencil8.
			/// </summary>
			[Extension("GL_OES_stencil8")]
			public bool Stencil8_OES;

			/// <summary>
			/// Support for extension GL_OES_stencil_wrap.
			/// </summary>
			[Extension("GL_OES_stencil_wrap")]
			public bool StencilWrap_OES;

			/// <summary>
			/// Support for extension GL_OES_surfaceless_context.
			/// </summary>
			[Extension("GL_OES_surfaceless_context")]
			public bool SurfacelessContext_OES;

			/// <summary>
			/// Support for extension GL_OES_tessellation_point_size.
			/// </summary>
			[Extension("GL_OES_tessellation_point_size")]
			public bool TessellationPointSize_OES;

			/// <summary>
			/// Support for extension GL_OES_tessellation_shader.
			/// </summary>
			[Extension("GL_OES_tessellation_shader")]
			public bool TessellationShader_OES;

			/// <summary>
			/// Support for extension GL_OES_texture_3D.
			/// </summary>
			[Extension("GL_OES_texture_3D")]
			public bool Texture3D_OES;

			/// <summary>
			/// Support for extension GL_OES_texture_border_clamp.
			/// </summary>
			[Extension("GL_OES_texture_border_clamp")]
			public bool TextureBorderClamp_OES;

			/// <summary>
			/// Support for extension GL_OES_texture_buffer.
			/// </summary>
			[Extension("GL_OES_texture_buffer")]
			public bool TextureBuffer_OES;

			/// <summary>
			/// Support for extension GL_OES_texture_compression_astc.
			/// </summary>
			[Extension("GL_OES_texture_compression_astc")]
			public bool TextureCompressionAstc_OES;

			/// <summary>
			/// Support for extension GL_OES_texture_cube_map.
			/// </summary>
			[Extension("GL_OES_texture_cube_map")]
			public bool TextureCubeMap_OES;

			/// <summary>
			/// Support for extension GL_OES_texture_cube_map_array.
			/// </summary>
			[Extension("GL_OES_texture_cube_map_array")]
			public bool TextureCubeMapArray_OES;

			/// <summary>
			/// Support for extension GL_OES_texture_env_crossbar.
			/// </summary>
			[Extension("GL_OES_texture_env_crossbar")]
			public bool TextureEnvCrossbar_OES;

			/// <summary>
			/// Support for extension GL_OES_texture_float.
			/// </summary>
			[Extension("GL_OES_texture_float")]
			public bool TextureFloat_OES;

			/// <summary>
			/// Support for extension GL_OES_texture_float_linear.
			/// </summary>
			[Extension("GL_OES_texture_float_linear")]
			public bool TextureFloatLinear_OES;

			/// <summary>
			/// Support for extension GL_OES_texture_half_float.
			/// </summary>
			[Extension("GL_OES_texture_half_float")]
			public bool TextureHalfFloat_OES;

			/// <summary>
			/// Support for extension GL_OES_texture_half_float_linear.
			/// </summary>
			[Extension("GL_OES_texture_half_float_linear")]
			public bool TextureHalfFloatLinear_OES;

			/// <summary>
			/// Support for extension GL_OES_texture_mirrored_repeat.
			/// </summary>
			[Extension("GL_OES_texture_mirrored_repeat")]
			public bool TextureMirroredRepeat_OES;

			/// <summary>
			/// Support for extension GL_OES_texture_npot.
			/// </summary>
			[Extension("GL_OES_texture_npot")]
			public bool TextureNpot_OES;

			/// <summary>
			/// Support for extension GL_OES_texture_stencil8.
			/// </summary>
			[Extension("GL_OES_texture_stencil8")]
			public bool TextureStencil8_OES;

			/// <summary>
			/// Support for extension GL_OES_texture_storage_multisample_2d_array.
			/// </summary>
			[Extension("GL_OES_texture_storage_multisample_2d_array")]
			public bool TextureStorageMultisample2dArray_OES;

			/// <summary>
			/// Support for extension GL_OES_texture_view.
			/// </summary>
			[Extension("GL_OES_texture_view")]
			public bool TextureView_OES;

			/// <summary>
			/// Support for extension GL_OES_vertex_array_object.
			/// </summary>
			[Extension("GL_OES_vertex_array_object")]
			public bool VertexArrayObject_OES;

			/// <summary>
			/// Support for extension GL_OES_vertex_half_float.
			/// </summary>
			[Extension("GL_OES_vertex_half_float")]
			public bool VertexHalfFloat_OES;

			/// <summary>
			/// Support for extension GL_OES_vertex_type_10_10_10_2.
			/// </summary>
			[Extension("GL_OES_vertex_type_10_10_10_2")]
			public bool VertexType1010102_OES;

			/// <summary>
			/// Support for extension GL_OVR_multiview_multisampled_render_to_texture.
			/// </summary>
			[Extension("GL_OVR_multiview_multisampled_render_to_texture")]
			public bool MultiviewMultisampledRenderToTexture_OVR;

			/// <summary>
			/// Support for extension GL_QCOM_alpha_test.
			/// </summary>
			[Extension("GL_QCOM_alpha_test")]
			public bool AlphaTest_QCOM;

			/// <summary>
			/// Support for extension GL_QCOM_binning_control.
			/// </summary>
			[Extension("GL_QCOM_binning_control")]
			public bool BinningControl_QCOM;

			/// <summary>
			/// Support for extension GL_QCOM_driver_control.
			/// </summary>
			[Extension("GL_QCOM_driver_control")]
			public bool DriverControl_QCOM;

			/// <summary>
			/// Support for extension GL_QCOM_extended_get.
			/// </summary>
			[Extension("GL_QCOM_extended_get")]
			public bool ExtendedGet_QCOM;

			/// <summary>
			/// Support for extension GL_QCOM_extended_get2.
			/// </summary>
			[Extension("GL_QCOM_extended_get2")]
			public bool ExtendedGet2_QCOM;

			/// <summary>
			/// Support for extension GL_QCOM_perfmon_global_mode.
			/// </summary>
			[Extension("GL_QCOM_perfmon_global_mode")]
			public bool PerfmonGlobalMode_QCOM;

			/// <summary>
			/// Support for extension GL_QCOM_tiled_rendering.
			/// </summary>
			[Extension("GL_QCOM_tiled_rendering")]
			public bool TiledRendering_QCOM;

			/// <summary>
			/// Support for extension GL_QCOM_writeonly_rendering.
			/// </summary>
			[Extension("GL_QCOM_writeonly_rendering")]
			public bool WriteonlyRendering_QCOM;

			/// <summary>
			/// Support for extension GL_VIV_shader_binary.
			/// </summary>
			[Extension("GL_VIV_shader_binary")]
			public bool ShaderBinary_VIV;

		}
}

}
