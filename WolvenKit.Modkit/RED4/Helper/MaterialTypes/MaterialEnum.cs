using WolvenKit.RED4.CR2W.Types;
using WolvenKit.RED4.CR2W;
using Newtonsoft.Json;
using System.IO;
using System;
using WolvenKit.Modkit.RED4.Materials.Types;

namespace WolvenKit.Modkit.RED4.Materials
{
    public partial class MATERIAL
    {
        public static void WriteMatToMeshEnum(ref CR2WFile mi, ref RawMaterial mat)
        {
            switch (Enum.Parse<MaterialTypes>(mat.MaterialType))
            {
                case MaterialTypes._3d_map:
                    mat._3d_map.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\3d_map.mt";
                    break;
                case MaterialTypes._3d_map_cubes:
                    mat._3d_map_cubes.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\3d_map_cubes.mt";
                    break;
                case MaterialTypes._3d_map_solid:
                    mat._3d_map_solid.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\3d_map_solid.mt";
                    break;
                case MaterialTypes._beyondblackwall:
                    mat._beyondblackwall.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\beyondblackwall.mt";
                    break;
                case MaterialTypes._beyondblackwall_chars:
                    mat._beyondblackwall_chars.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\beyondblackwall_chars.mt";
                    break;
                case MaterialTypes._beyondblackwall_sky:
                    mat._beyondblackwall_sky.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\beyondblackwall_sky.mt";
                    break;
                case MaterialTypes._beyondblackwall_sky_raymarch:
                    mat._beyondblackwall_sky_raymarch.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\beyondblackwall_sky_raymarch.mt";
                    break;
                case MaterialTypes._blood_puddle_decal:
                    mat._blood_puddle_decal.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\blood_puddle_decal.mt";
                    break;
                case MaterialTypes._cable:
                    mat._cable.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\cable.mt";
                    break;
                case MaterialTypes._circuit_wires:
                    mat._circuit_wires.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\circuit_wires.mt";
                    break;
                case MaterialTypes._cloth_mov:
                    mat._cloth_mov.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\cloth_mov.mt";
                    break;
                case MaterialTypes._cloth_mov_multilayered:
                    mat._cloth_mov_multilayered.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\cloth_mov_multilayered.mt";
                    break;
                case MaterialTypes._cyberparticles_base:
                    mat._cyberparticles_base.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\cyberparticles_base.mt";
                    break;
                case MaterialTypes._cyberparticles_blackwall:
                    mat._cyberparticles_blackwall.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\cyberparticles_blackwall.mt";
                    break;
                case MaterialTypes._cyberparticles_blackwall_touch:
                    mat._cyberparticles_blackwall_touch.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\cyberparticles_blackwall_touch.mt";
                    break;
                case MaterialTypes._cyberparticles_braindance:
                    mat._cyberparticles_braindance.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\cyberparticles_braindance.mt";
                    break;
                case MaterialTypes._cyberparticles_dynamic:
                    mat._cyberparticles_dynamic.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\cyberparticles_dynamic.mt";
                    break;
                case MaterialTypes._cyberparticles_platform:
                    mat._cyberparticles_platform.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\cyberparticles_platform.mt";
                    break;
                case MaterialTypes._decal_emissive_color:
                    mat._decal_emissive_color.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\decal_emissive_color.mt";
                    break;
                case MaterialTypes._decal_emissive_only:
                    mat._decal_emissive_only.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\decal_emissive_only.mt";
                    break;
                case MaterialTypes._decal_forward:
                    mat._decal_forward.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\decal_forward.mt";
                    break;
                case MaterialTypes._decal_gradientmap_recolor:
                    mat._decal_gradientmap_recolor.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\decal_gradientmap_recolor.mt";
                    break;
                case MaterialTypes._decal_gradientmap_recolor_emissive:
                    mat._decal_gradientmap_recolor_emissive.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\decal_gradientmap_recolor_emissive.mt";
                    break;
                case MaterialTypes._decal_normal_roughness:
                    mat._decal_normal_roughness.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\decal_normal_roughness.mt";
                    break;
                case MaterialTypes._decal_normal_roughness_metalness:
                    mat._decal_normal_roughness_metalness.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\decal_normal_roughness_metalness.mt";
                    break;
                case MaterialTypes._decal_normal_roughness_metalness_2:
                    mat._decal_normal_roughness_metalness_2.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\decal_normal_roughness_metalness_2.mt";
                    break;
                case MaterialTypes._decal_parallax:
                    mat._decal_parallax.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\decal_parallax.mt";
                    break;
                case MaterialTypes._decal_puddle:
                    mat._decal_puddle.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\decal_puddle.mt";
                    break;
                case MaterialTypes._decal_roughness:
                    mat._decal_roughness.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\decal_roughness.mt";
                    break;
                case MaterialTypes._decal_roughness_only:
                    mat._decal_roughness_only.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\decal_roughness_only.mt";
                    break;
                case MaterialTypes._decal_terrain_projected:
                    mat._decal_terrain_projected.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\decal_terrain_projected.mt";
                    break;
                case MaterialTypes._decal_tintable:
                    mat._decal_tintable.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\decal_tintable.mt";
                    break;
                case MaterialTypes._diode_sign:
                    mat._diode_sign.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\diode_sign.mt";
                    break;
                case MaterialTypes._earth_globe:
                    mat._earth_globe.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\earth_globe.mt";
                    break;
                case MaterialTypes._earth_globe_atmosphere:
                    mat._earth_globe_atmosphere.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\earth_globe_atmosphere.mt";
                    break;
                case MaterialTypes._earth_globe_lights:
                    mat._earth_globe_lights.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\earth_globe_lights.mt";
                    break;
                case MaterialTypes._emissive_control:
                    mat._emissive_control.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\emissive_control.mt";
                    break;
                case MaterialTypes._eye:
                    mat._eye.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\eye.mt";
                    break;
                case MaterialTypes._eye_blendable:
                    mat._eye_blendable.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\eye_blendable.mt";
                    break;
                case MaterialTypes._eye_gradient:
                    mat._eye_gradient.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\eye_gradient.mt";
                    break;
                case MaterialTypes._eye_shadow:
                    mat._eye_shadow.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\eye_shadow.mt";
                    break;
                case MaterialTypes._eye_shadow_blendable:
                    mat._eye_shadow_blendable.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\eye_shadow_blendable.mt";
                    break;
                case MaterialTypes._fake_occluder:
                    mat._fake_occluder.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\fake_occluder.mt";
                    break;
                case MaterialTypes._fillable_fluid:
                    mat._fillable_fluid.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\fillable_fluid.mt";
                    break;
                case MaterialTypes._fillable_fluid_vertex:
                    mat._fillable_fluid_vertex.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\fillable_fluid_vertex.mt";
                    break;
                case MaterialTypes._fluid_mov:
                    mat._fluid_mov.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\fluid_mov.mt";
                    break;
                case MaterialTypes._frosted_glass:
                    mat._frosted_glass.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\frosted_glass.mt";
                    break;
                case MaterialTypes._frosted_glass_curtain:
                    mat._frosted_glass_curtain.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\frosted_glass_curtain.mt";
                    break;
                case MaterialTypes._glass:
                    mat._glass.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\glass.mt";
                    break;
                case MaterialTypes._glass_blendable:
                    mat._glass_blendable.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\glass_blendable.mt";
                    break;
                case MaterialTypes._glass_cracked_edge:
                    mat._glass_cracked_edge.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\glass_cracked_edge.mt";
                    break;
                case MaterialTypes._glass_deferred:
                    mat._glass_deferred.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\glass_deferred.mt";
                    break;
                case MaterialTypes._glass_scope:
                    mat._glass_scope.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\glass_scope.mt";
                    break;
                case MaterialTypes._glass_window_rain:
                    mat._glass_window_rain.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\glass_window_rain.mt";
                    break;
                case MaterialTypes._hair:
                    mat._hair.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\hair.mt";
                    break;
                case MaterialTypes._hair_blendable:
                    mat._hair_blendable.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\hair_blendable.mt";
                    break;
                case MaterialTypes._hair_proxy:
                    mat._hair_proxy.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\hair_proxy.mt";
                    break;
                case MaterialTypes._ice_fluid_mov:
                    mat._ice_fluid_mov.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\ice_fluid_mov.mt";
                    break;
                case MaterialTypes._ice_ver_mov_translucent:
                    mat._ice_ver_mov_translucent.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\ice_ver_mov_translucent.mt";
                    break;
                case MaterialTypes._lights_interactive:
                    mat._lights_interactive.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\lights_interactive.mt";
                    break;
                case MaterialTypes._loot_drop_highlight:
                    mat._loot_drop_highlight.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\loot_drop_highlight.mt";
                    break;
                case MaterialTypes._mesh_decal:
                    mat._mesh_decal.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\mesh_decal.mt";
                    break;
                case MaterialTypes._mesh_decal_blendable:
                    mat._mesh_decal_blendable.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\mesh_decal_blendable.mt";
                    break;
                case MaterialTypes._mesh_decal_double_diffuse:
                    mat._mesh_decal_double_diffuse.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\mesh_decal_double_diffuse.mt";
                    break;
                case MaterialTypes._mesh_decal_emissive:
                    mat._mesh_decal_emissive.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\mesh_decal_emissive.mt";
                    break;
                case MaterialTypes._mesh_decal_emissive_subsurface:
                    mat._mesh_decal_emissive_subsurface.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\mesh_decal_emissive_subsurface.mt";
                    break;
                case MaterialTypes._mesh_decal_gradientmap_recolor:
                    mat._mesh_decal_gradientmap_recolor.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\mesh_decal_gradientmap_recolor.mt";
                    break;
                case MaterialTypes._mesh_decal_gradientmap_recolor_2:
                    mat._mesh_decal_gradientmap_recolor_2.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\mesh_decal_gradientmap_recolor_2.mt";
                    break;
                case MaterialTypes._mesh_decal_gradientmap_recolor_emissive:
                    mat._mesh_decal_gradientmap_recolor_emissive.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\mesh_decal_gradientmap_recolor_emissive.mt";
                    break;
                case MaterialTypes._mesh_decal_multitinted:
                    mat._mesh_decal_multitinted.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\mesh_decal_multitinted.mt";
                    break;
                case MaterialTypes._mesh_decal_parallax:
                    mat._mesh_decal_parallax.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\mesh_decal_parallax.mt";
                    break;
                case MaterialTypes._mesh_decal_revealed:
                    mat._mesh_decal_revealed.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\mesh_decal_revealed.mt";
                    break;
                case MaterialTypes._mesh_decal_wet_character:
                    mat._mesh_decal_wet_character.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\mesh_decal_wet_character.mt";
                    break;
                case MaterialTypes._metal_base_bink:
                    mat._metal_base_bink.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\metal_base_bink.mt";
                    break;
                case MaterialTypes._metal_base_det:
                    mat._metal_base_det.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\metal_base_det.mt";
                    break;
                case MaterialTypes._metal_base_det_dithered:
                    mat._metal_base_det_dithered.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\metal_base_det_dithered.mt";
                    break;
                case MaterialTypes._metal_base_dithered:
                    mat._metal_base_dithered.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\metal_base_dithered.mt";
                    break;
                case MaterialTypes._metal_base_gradientmap_recolor:
                    mat._metal_base_gradientmap_recolor.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\metal_base_gradientmap_recolor.mt";
                    break;
                case MaterialTypes._metal_base_parallax:
                    mat._metal_base_parallax.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\metal_base_parallax.mt";
                    break;
                case MaterialTypes._metal_base_trafficlight_proxy:
                    mat._metal_base_trafficlight_proxy.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\metal_base_trafficlight_proxy.mt";
                    break;
                case MaterialTypes._metal_base_ui:
                    mat._metal_base_ui.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\metal_base_ui.mt";
                    break;
                case MaterialTypes._metal_base_vertexcolored:
                    mat._metal_base_vertexcolored.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\metal_base_vertexcolored.mt";
                    break;
                case MaterialTypes._mikoshi_blocks_big:
                    mat._mikoshi_blocks_big.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\mikoshi_blocks_big.mt";
                    break;
                case MaterialTypes._mikoshi_blocks_medium:
                    mat._mikoshi_blocks_medium.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\mikoshi_blocks_medium.mt";
                    break;
                case MaterialTypes._mikoshi_blocks_small:
                    mat._mikoshi_blocks_small.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\mikoshi_blocks_small.mt";
                    break;
                case MaterialTypes._mikoshi_parallax:
                    mat._mikoshi_parallax.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\mikoshi_parallax.mt";
                    break;
                case MaterialTypes._mikoshi_prison_cell:
                    mat._mikoshi_prison_cell.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\mikoshi_prison_cell.mt";
                    break;
                case MaterialTypes._multilayered_clear_coat:
                    mat._multilayered_clear_coat.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\multilayered_clear_coat.mt";
                    break;
                case MaterialTypes._multilayered_terrain:
                    mat._multilayered_terrain.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\multilayered_terrain.mt";
                    break;
                case MaterialTypes._neon_parallax:
                    mat._neon_parallax.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\neon_parallax.mt";
                    break;
                case MaterialTypes._presimulated_particles:
                    mat._presimulated_particles.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\presimulated_particles.mt";
                    break;
                case MaterialTypes._proxy_ad:
                    mat._proxy_ad.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\proxy_ad.mt";
                    break;
                case MaterialTypes._proxy_crowd:
                    mat._proxy_crowd.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\proxy_crowd.mt";
                    break;
                case MaterialTypes._q116_mikoshi_cubes:
                    mat._q116_mikoshi_cubes.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\q116_mikoshi_cubes.mt";
                    break;
                case MaterialTypes._q116_mikoshi_floor:
                    mat._q116_mikoshi_floor.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\q116_mikoshi_floor.mt";
                    break;
                case MaterialTypes._q202_lake_surface:
                    mat._q202_lake_surface.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\q202_lake_surface.mt";
                    break;
                case MaterialTypes._rain:
                    mat._rain.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\rain.mt";
                    break;
                case MaterialTypes._road_debug_grid:
                    mat._road_debug_grid.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\road_debug_grid.mt";
                    break;
                case MaterialTypes._set_stencil_3:
                    mat._set_stencil_3.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\set_stencil_3.mt";
                    break;
                case MaterialTypes._silverhand_overlay:
                    mat._silverhand_overlay.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\silverhand_overlay.mt";
                    break;
                case MaterialTypes._silverhand_overlay_blendable:
                    mat._silverhand_overlay_blendable.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\silverhand_overlay_blendable.mt";
                    break;
                case MaterialTypes._skin:
                    mat._skin.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\skin.mt";
                    break;
                case MaterialTypes._skin_blendable:
                    mat._skin_blendable.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\skin_blendable.mt";
                    break;
                case MaterialTypes._skybox:
                    mat._skybox.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\skybox.mt";
                    break;
                case MaterialTypes._speedtree_3d_v8_billboard:
                    mat._speedtree_3d_v8_billboard.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\speedtree_3d_v8_billboard.mt";
                    break;
                case MaterialTypes._speedtree_3d_v8_onesided:
                    mat._speedtree_3d_v8_onesided.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\speedtree_3d_v8_onesided.mt";
                    break;
                case MaterialTypes._speedtree_3d_v8_onesided_gradient_recolor:
                    mat._speedtree_3d_v8_onesided_gradient_recolor.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\speedtree_3d_v8_onesided_gradient_recolor.mt";
                    break;
                case MaterialTypes._speedtree_3d_v8_seams:
                    mat._speedtree_3d_v8_seams.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\speedtree_3d_v8_seams.mt";
                    break;
                case MaterialTypes._speedtree_3d_v8_twosided:
                    mat._speedtree_3d_v8_twosided.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\speedtree_3d_v8_twosided.mt";
                    break;
                case MaterialTypes._spline_deformed_metal_base:
                    mat._spline_deformed_metal_base.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\spline_deformed_metal_base.mt";
                    break;
                case MaterialTypes._terrain_simple:
                    mat._terrain_simple.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\terrain_simple.mt";
                    break;
                case MaterialTypes._top_down_car_proxy_depth:
                    mat._top_down_car_proxy_depth.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\top_down_car_proxy_depth.mt";
                    break;
                case MaterialTypes._trail_decal:
                    mat._trail_decal.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\trail_decal.mt";
                    break;
                case MaterialTypes._trail_decal_normal:
                    mat._trail_decal_normal.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\trail_decal_normal.mt";
                    break;
                case MaterialTypes._trail_decal_normal_color:
                    mat._trail_decal_normal_color.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\trail_decal_normal_color.mt";
                    break;
                case MaterialTypes._transparent_liquid:
                    mat._transparent_liquid.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\transparent_liquid.mt";
                    break;
                case MaterialTypes._underwater_blood:
                    mat._underwater_blood.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\underwater_blood.mt";
                    break;
                case MaterialTypes._vehicle_destr_blendshape:
                    mat._vehicle_destr_blendshape.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\vehicle_destr_blendshape.mt";
                    break;
                case MaterialTypes._vehicle_glass:
                    mat._vehicle_glass.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\vehicle_glass.mt";
                    break;
                case MaterialTypes._vehicle_glass_proxy:
                    mat._vehicle_glass_proxy.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\vehicle_glass_proxy.mt";
                    break;
                case MaterialTypes._vehicle_lights:
                    mat._vehicle_lights.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\vehicle_lights.mt";
                    break;
                case MaterialTypes._vehicle_mesh_decal:
                    mat._vehicle_mesh_decal.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\vehicle_mesh_decal.mt";
                    break;
                case MaterialTypes._ver_mov:
                    mat._ver_mov.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\ver_mov.mt";
                    break;
                case MaterialTypes._ver_mov_glass:
                    mat._ver_mov_glass.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\ver_mov_glass.mt";
                    break;
                case MaterialTypes._ver_mov_multilayered:
                    mat._ver_mov_multilayered.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\ver_mov_multilayered.mt";
                    break;
                case MaterialTypes._ver_skinned_mov:
                    mat._ver_skinned_mov.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\ver_skinned_mov.mt";
                    break;
                case MaterialTypes._ver_skinned_mov_parade:
                    mat._ver_skinned_mov_parade.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\ver_skinned_mov_parade.mt";
                    break;
                case MaterialTypes._window_interior_uv:
                    mat._window_interior_uv.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\window_interior_uv.mt";
                    break;
                case MaterialTypes._window_parallax_interior:
                    mat._window_parallax_interior.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\window_parallax_interior.mt";
                    break;
                case MaterialTypes._window_parallax_interior_proxy:
                    mat._window_parallax_interior_proxy.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\window_parallax_interior_proxy.mt";
                    break;
                case MaterialTypes._window_parallax_interior_proxy_buffer:
                    mat._window_parallax_interior_proxy_buffer.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\window_parallax_interior_proxy_buffer.mt";
                    break;
                case MaterialTypes._window_very_long_distance:
                    mat._window_very_long_distance.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\window_very_long_distance.mt";
                    break;
                case MaterialTypes._worldspace_grid:
                    mat._worldspace_grid.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\worldspace_grid.mt";
                    break;
                case MaterialTypes._bink_simple:
                    mat._bink_simple.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\bink_simple.mt";
                    break;
                case MaterialTypes._cable_strip:
                    mat._cable_strip.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\cable_strip.mt";
                    break;
                case MaterialTypes._debugdraw_bias:
                    mat._debugdraw_bias.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\debugdraw_bias.mt";
                    break;
                case MaterialTypes._debugdraw_wireframe:
                    mat._debugdraw_wireframe.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\debugdraw_wireframe.mt";
                    break;
                case MaterialTypes._debugdraw_wireframe_bias:
                    mat._debugdraw_wireframe_bias.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\debugdraw_wireframe_bias.mt";
                    break;
                case MaterialTypes._debug_coloring:
                    mat._debug_coloring.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\debug_coloring.mt";
                    break;
                case MaterialTypes._font:
                    mat._font.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\font.mt";
                    break;
                case MaterialTypes._global_water_patch:
                    mat._global_water_patch.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\global_water_patch.mt";
                    break;
                case MaterialTypes._metal_base_animated_uv:
                    mat._metal_base_animated_uv.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\metal_base_animated_uv.mt";
                    break;
                case MaterialTypes._metal_base_blendable:
                    mat._metal_base_blendable.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\metal_base_blendable.mt";
                    break;
                case MaterialTypes._metal_base_fence:
                    mat._metal_base_fence.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\metal_base_fence.mt";
                    break;
                case MaterialTypes._metal_base_garment:
                    mat._metal_base_garment.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\metal_base_garment.mt";
                    break;
                case MaterialTypes._metal_base_packed:
                    mat._metal_base_packed.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\metal_base_packed.mt";
                    break;
                case MaterialTypes._metal_base_proxy:
                    mat._metal_base_proxy.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\metal_base_proxy.mt";
                    break;
                case MaterialTypes._multilayered:
                    mat._multilayered.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\multilayered.mt";
                    break;
                case MaterialTypes._multilayered_debug:
                    mat._multilayered_debug.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\multilayered_debug.mt";
                    break;
                case MaterialTypes._pbr_simple:
                    mat._pbr_simple.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\pbr_simple.mt";
                    break;
                case MaterialTypes._shadows_debug:
                    mat._shadows_debug.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\shadows_debug.mt";
                    break;
                case MaterialTypes._transparent_notxaa_2:
                    mat._transparent_notxaa_2.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\transparent_notxaa_2.mt";
                    break;
                case MaterialTypes._ui_default_element:
                    mat._ui_default_element.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\ui_default_element.mt";
                    break;
                case MaterialTypes._ui_default_nine_slice_element:
                    mat._ui_default_nine_slice_element.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\ui_default_nine_slice_element.mt";
                    break;
                case MaterialTypes._ui_default_tile_element:
                    mat._ui_default_tile_element.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\ui_default_tile_element.mt";
                    break;
                case MaterialTypes._ui_effect_box_blur:
                    mat._ui_effect_box_blur.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\ui_effect_box_blur.mt";
                    break;
                case MaterialTypes._ui_effect_color_correction:
                    mat._ui_effect_color_correction.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\ui_effect_color_correction.mt";
                    break;
                case MaterialTypes._ui_effect_color_fill:
                    mat._ui_effect_color_fill.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\ui_effect_color_fill.mt";
                    break;
                case MaterialTypes._ui_effect_glitch:
                    mat._ui_effect_glitch.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\ui_effect_glitch.mt";
                    break;
                case MaterialTypes._ui_effect_inner_glow:
                    mat._ui_effect_inner_glow.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\ui_effect_inner_glow.mt";
                    break;
                case MaterialTypes._ui_effect_light_sweep:
                    mat._ui_effect_light_sweep.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\ui_effect_light_sweep.mt";
                    break;
                case MaterialTypes._ui_effect_linear_wipe:
                    mat._ui_effect_linear_wipe.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\ui_effect_linear_wipe.mt";
                    break;
                case MaterialTypes._ui_effect_mask:
                    mat._ui_effect_mask.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\ui_effect_mask.mt";
                    break;
                case MaterialTypes._ui_effect_point_cloud:
                    mat._ui_effect_point_cloud.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\ui_effect_point_cloud.mt";
                    break;
                case MaterialTypes._ui_effect_radial_wipe:
                    mat._ui_effect_radial_wipe.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\ui_effect_radial_wipe.mt";
                    break;
                case MaterialTypes._ui_effect_swipe:
                    mat._ui_effect_swipe.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\ui_effect_swipe.mt";
                    break;
                case MaterialTypes._ui_element_depth_texture:
                    mat._ui_element_depth_texture.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\ui_element_depth_texture.mt";
                    break;
                case MaterialTypes._ui_panel:
                    mat._ui_panel.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\ui_panel.mt";
                    break;
                case MaterialTypes._ui_text_element:
                    mat._ui_text_element.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\ui_text_element.mt";
                    break;
                case MaterialTypes._alphablend_glass:
                    mat._alphablend_glass.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\alphablend_glass.mt";
                    break;
                case MaterialTypes._alpha_control_refraction:
                    mat._alpha_control_refraction.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\alpha_control_refraction.mt";
                    break;
                case MaterialTypes._animated_decal:
                    mat._animated_decal.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\animated_decal.mt";
                    break;
                case MaterialTypes._beam_particles:
                    mat._beam_particles.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\beam_particles.mt";
                    break;
                case MaterialTypes._blackbodyradiation:
                    mat._blackbodyradiation.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\blackbodyradiation.mt";
                    break;
                case MaterialTypes._blackbody_simple:
                    mat._blackbody_simple.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\blackbody_simple.mt";
                    break;
                case MaterialTypes._blood_transparent:
                    mat._blood_transparent.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\blood_transparent.mt";
                    break;
                case MaterialTypes._braindance_fog:
                    mat._braindance_fog.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\braindance_fog.mt";
                    break;
                case MaterialTypes._braindance_particle_thermal:
                    mat._braindance_particle_thermal.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\braindance_particle_thermal.mt";
                    break;
                case MaterialTypes._cloak:
                    mat._cloak.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\cloak.mt";
                    break;
                case MaterialTypes._cyberspace_pixelsort_stencil:
                    mat._cyberspace_pixelsort_stencil.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\cyberspace_pixelsort_stencil.mt";
                    break;
                case MaterialTypes._cyberspace_pixelsort_stencil_0:
                    mat._cyberspace_pixelsort_stencil_0.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\cyberspace_pixelsort_stencil_0.mt";
                    break;
                case MaterialTypes._cyberware_animation:
                    mat._cyberware_animation.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\cyberware_animation.mt";
                    break;
                case MaterialTypes._damage_indicator:
                    mat._damage_indicator.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\damage_indicator.mt";
                    break;
                case MaterialTypes._device_diode:
                    mat._device_diode.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\device_diode.mt";
                    break;
                case MaterialTypes._device_diode_multi_state:
                    mat._device_diode_multi_state.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\device_diode_multi_state.mt";
                    break;
                case MaterialTypes._diode_pavements:
                    mat._diode_pavements.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\diode_pavements.mt";
                    break;
                case MaterialTypes._drugged_sobel:
                    mat._drugged_sobel.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\drugged_sobel.mt";
                    break;
                case MaterialTypes._emissive_basic_transparent:
                    mat._emissive_basic_transparent.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\emissive_basic_transparent.mt";
                    break;
                case MaterialTypes._fog_laser:
                    mat._fog_laser.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\fog_laser.mt";
                    break;
                case MaterialTypes._hologram:
                    mat._hologram.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\hologram.mt";
                    break;
                case MaterialTypes._hologram_two_sided:
                    mat._hologram_two_sided.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\hologram_two_sided.mt";
                    break;
                case MaterialTypes._holo_projections:
                    mat._holo_projections.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\holo_projections.mt";
                    break;
                case MaterialTypes._hud_focus_mode_scanline:
                    mat._hud_focus_mode_scanline.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\hud_focus_mode_scanline.mt";
                    break;
                case MaterialTypes._hud_markers_notxaa:
                    mat._hud_markers_notxaa.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\hud_markers_notxaa.mt";
                    break;
                case MaterialTypes._hud_markers_transparent:
                    mat._hud_markers_transparent.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\hud_markers_transparent.mt";
                    break;
                case MaterialTypes._hud_markers_vision:
                    mat._hud_markers_vision.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\hud_markers_vision.mt";
                    break;
                case MaterialTypes._hud_ui_dot:
                    mat._hud_ui_dot.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\hud_ui_dot.mt";
                    break;
                case MaterialTypes._hud_vision_pass:
                    mat._hud_vision_pass.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\hud_vision_pass.mt";
                    break;
                case MaterialTypes._johnny_effect:
                    mat._johnny_effect.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\johnny_effect.mt";
                    break;
                case MaterialTypes._johnny_glitch:
                    mat._johnny_glitch.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\johnny_glitch.mt";
                    break;
                case MaterialTypes._metal_base_atlas_animation:
                    mat._metal_base_atlas_animation.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\metal_base_atlas_animation.mt";
                    break;
                case MaterialTypes._metal_base_blackbody:
                    mat._metal_base_blackbody.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\metal_base_blackbody.mt";
                    break;
                case MaterialTypes._metal_base_glitter:
                    mat._metal_base_glitter.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\metal_base_glitter.mt";
                    break;
                case MaterialTypes._neon_tubes:
                    mat._neon_tubes.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\neon_tubes.mt";
                    break;
                case MaterialTypes._noctovision_mode:
                    mat._noctovision_mode.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\noctovision_mode.mt";
                    break;
                case MaterialTypes._parallaxscreen:
                    mat._parallaxscreen.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\parallaxscreen.mt";
                    break;
                case MaterialTypes._parallaxscreen_transparent:
                    mat._parallaxscreen_transparent.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\parallaxscreen_transparent.mt";
                    break;
                case MaterialTypes._parallaxscreen_transparent_ui:
                    mat._parallaxscreen_transparent_ui.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\parallaxscreen_transparent_ui.mt";
                    break;
                case MaterialTypes._parallax_bink:
                    mat._parallax_bink.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\parallax_bink.mt";
                    break;
                case MaterialTypes._particles_generic_expanded:
                    mat._particles_generic_expanded.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\particles_generic_expanded.mt";
                    break;
                case MaterialTypes._particles_hologram:
                    mat._particles_hologram.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\particles_hologram.mt";
                    break;
                case MaterialTypes._pointcloud_source_mesh:
                    mat._pointcloud_source_mesh.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\pointcloud_source_mesh.mt";
                    break;
                case MaterialTypes._postprocess:
                    mat._postprocess.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\postprocess.mt";
                    break;
                case MaterialTypes._postprocess_notxaa:
                    mat._postprocess_notxaa.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\postprocess_notxaa.mt";
                    break;
                case MaterialTypes._radial_blur:
                    mat._radial_blur.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\radial_blur.mt";
                    break;
                case MaterialTypes._reflex_buster:
                    mat._reflex_buster.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\reflex_buster.mt";
                    break;
                case MaterialTypes._refraction:
                    mat._refraction.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\refraction.mt";
                    break;
                case MaterialTypes._sandevistan_trails:
                    mat._sandevistan_trails.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\sandevistan_trails.mt";
                    break;
                case MaterialTypes._screens:
                    mat._screens.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\screens.mt";
                    break;
                case MaterialTypes._screen_artifacts:
                    mat._screen_artifacts.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\screen_artifacts.mt";
                    break;
                case MaterialTypes._screen_artifacts_vision:
                    mat._screen_artifacts_vision.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\screen_artifacts_vision.mt";
                    break;
                case MaterialTypes._screen_black:
                    mat._screen_black.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\screen_black.mt";
                    break;
                case MaterialTypes._screen_fast_travel_glitch:
                    mat._screen_fast_travel_glitch.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\screen_fast_travel_glitch.mt";
                    break;
                case MaterialTypes._screen_glitch:
                    mat._screen_glitch.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\screen_glitch.mt";
                    break;
                case MaterialTypes._screen_glitch_notxaa:
                    mat._screen_glitch_notxaa.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\screen_glitch_notxaa.mt";
                    break;
                case MaterialTypes._screen_glitch_vision:
                    mat._screen_glitch_vision.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\screen_glitch_vision.mt";
                    break;
                case MaterialTypes._signages:
                    mat._signages.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\signages.mt";
                    break;
                case MaterialTypes._signages_transparent_no_txaa:
                    mat._signages_transparent_no_txaa.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\signages_transparent_no_txaa.mt";
                    break;
                case MaterialTypes._silverhand_proxy:
                    mat._silverhand_proxy.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\silverhand_proxy.mt";
                    break;
                case MaterialTypes._simple_additive_ui:
                    mat._simple_additive_ui.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\simple_additive_ui.mt";
                    break;
                case MaterialTypes._simple_emissive_decals:
                    mat._simple_emissive_decals.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\simple_emissive_decals.mt";
                    break;
                case MaterialTypes._simple_fresnel:
                    mat._simple_fresnel.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\simple_fresnel.mt";
                    break;
                case MaterialTypes._simple_refraction:
                    mat._simple_refraction.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\simple_refraction.mt";
                    break;
                case MaterialTypes._sound_clue:
                    mat._sound_clue.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\sound_clue.mt";
                    break;
                case MaterialTypes._television_ad:
                    mat._television_ad.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\television_ad.mt";
                    break;
                case MaterialTypes._triplanar_projection:
                    mat._triplanar_projection.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\triplanar_projection.mt";
                    break;
                case MaterialTypes._water_plane:
                    mat._water_plane.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\water_plane.mt";
                    break;
                case MaterialTypes._zoom:
                    mat._zoom.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\shaders\zoom.mt";
                    break;
                case MaterialTypes._alt_halo:
                    mat._alt_halo.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\alt_halo.mt";
                    break;
                case MaterialTypes._blackbodyradiation_distant:
                    mat._blackbodyradiation_distant.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\blackbodyradiation_distant.mt";
                    break;
                case MaterialTypes._blackbodyradiation_notxaa:
                    mat._blackbodyradiation_notxaa.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\blackbodyradiation_notxaa.mt";
                    break;
                case MaterialTypes._blood_metal_base:
                    mat._blood_metal_base.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\blood_metal_base.mt";
                    break;
                case MaterialTypes._caustics:
                    mat._caustics.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\caustics.mt";
                    break;
                case MaterialTypes._character_kerenzikov:
                    mat._character_kerenzikov.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\character_kerenzikov.mt";
                    break;
                case MaterialTypes._character_sandevistan:
                    mat._character_sandevistan.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\character_sandevistan.mt";
                    break;
                case MaterialTypes._crystal_dome:
                    mat._crystal_dome.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\crystal_dome.mt";
                    break;
                case MaterialTypes._crystal_dome_opaque:
                    mat._crystal_dome_opaque.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\crystal_dome_opaque.mt";
                    break;
                case MaterialTypes._cyberspace_gradient:
                    mat._cyberspace_gradient.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\cyberspace_gradient.mt";
                    break;
                case MaterialTypes._cyberspace_teleport_glitch:
                    mat._cyberspace_teleport_glitch.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\cyberspace_teleport_glitch.mt";
                    break;
                case MaterialTypes._decal_caustics:
                    mat._decal_caustics.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\decal_caustics.mt";
                    break;
                case MaterialTypes._decal_glitch:
                    mat._decal_glitch.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\decal_glitch.mt";
                    break;
                case MaterialTypes._decal_glitch_emissive:
                    mat._decal_glitch_emissive.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\decal_glitch_emissive.mt";
                    break;
                case MaterialTypes._depth_based_sobel:
                    mat._depth_based_sobel.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\depth_based_sobel.mt";
                    break;
                case MaterialTypes._diode_pavements_ui:
                    mat._diode_pavements_ui.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\diode_pavements_ui.mt";
                    break;
                case MaterialTypes._dirt_animated_masked:
                    mat._dirt_animated_masked.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\dirt_animated_masked.mt";
                    break;
                case MaterialTypes._e3_prototype_mask:
                    mat._e3_prototype_mask.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\e3_prototype_mask.mt";
                    break;
                case MaterialTypes._fake_flare:
                    mat._fake_flare.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\fake_flare.mt";
                    break;
                case MaterialTypes._fake_flare_simple:
                    mat._fake_flare_simple.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\fake_flare_simple.mt";
                    break;
                case MaterialTypes._flat_fog_masked:
                    mat._flat_fog_masked.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\flat_fog_masked.mt";
                    break;
                case MaterialTypes._flat_fog_masked_notxaa:
                    mat._flat_fog_masked_notxaa.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\flat_fog_masked_notxaa.mt";
                    break;
                case MaterialTypes._highlight_blocker:
                    mat._highlight_blocker.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\highlight_blocker.mt";
                    break;
                case MaterialTypes._hologram_proxy:
                    mat._hologram_proxy.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\hologram_proxy.mt";
                    break;
                case MaterialTypes._holo_mask:
                    mat._holo_mask.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\holo_mask.mt";
                    break;
                case MaterialTypes._invisible:
                    mat._invisible.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\invisible.mt";
                    break;
                case MaterialTypes._lightning_plasma:
                    mat._lightning_plasma.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\lightning_plasma.mt";
                    break;
                case MaterialTypes._light_gradients:
                    mat._light_gradients.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\light_gradients.mt";
                    break;
                case MaterialTypes._low_health:
                    mat._low_health.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\low_health.mt";
                    break;
                case MaterialTypes._mesh_decal__blackbody:
                    mat._mesh_decal__blackbody.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\mesh_decal__blackbody.mt";
                    break;
                case MaterialTypes._metal_base_scrolling:
                    mat._metal_base_scrolling.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\metal_base_scrolling.mt";
                    break;
                case MaterialTypes._multilayer_blackbody_inject:
                    mat._multilayer_blackbody_inject.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\multilayer_blackbody_inject.mt";
                    break;
                case MaterialTypes._nanowire_string:
                    mat._nanowire_string.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\nanowire_string.mt";
                    break;
                case MaterialTypes._oda_helm:
                    mat._oda_helm.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\oda_helm.mt";
                    break;
                case MaterialTypes._rift_noise:
                    mat._rift_noise.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\rift_noise.mt";
                    break;
                case MaterialTypes._screen_wave:
                    mat._screen_wave.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\screen_wave.mt";
                    break;
                case MaterialTypes._simple_fog:
                    mat._simple_fog.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\simple_fog.mt";
                    break;
                case MaterialTypes._simple_refraction_mask:
                    mat._simple_refraction_mask.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\simple_refraction_mask.mt";
                    break;
                case MaterialTypes._transparent_flowmap:
                    mat._transparent_flowmap.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\transparent_flowmap.mt";
                    break;
                case MaterialTypes._transparent_liquid_notxaa:
                    mat._transparent_liquid_notxaa.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\transparent_liquid_notxaa.mt";
                    break;
                case MaterialTypes._world_to_screen_glitch:
                    mat._world_to_screen_glitch.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\_shaders\world_to_screen_glitch.mt";
                    break;
                case MaterialTypes._hit_proxy:
                    mat._hit_proxy.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\debug\hit_proxy.mt";
                    break;
                case MaterialTypes._lod_coloring:
                    mat._lod_coloring.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\debug\lod_coloring.mt";
                    break;
                case MaterialTypes._overdraw:
                    mat._overdraw.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\debug\overdraw.mt";
                    break;
                case MaterialTypes._overdraw_seethrough:
                    mat._overdraw_seethrough.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\debug\overdraw_seethrough.mt";
                    break;
                case MaterialTypes._selection:
                    mat._selection.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\debug\selection.mt";
                    break;
                case MaterialTypes._uv_density:
                    mat._uv_density.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\debug\uv_density.mt";
                    break;
                case MaterialTypes._wireframe:
                    mat._wireframe.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\debug\wireframe.mt";
                    break;
                case MaterialTypes._editor_mlmask_preview:
                    mat._editor_mlmask_preview.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\internal\editor_mlmask_preview.mt";
                    break;
                case MaterialTypes._editor_mltemplate_preview:
                    mat._editor_mltemplate_preview.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\internal\editor_mltemplate_preview.mt";
                    break;
                case MaterialTypes._gi_backface_debug:
                    mat._gi_backface_debug.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\internal\gi_backface_debug.mt";
                    break;
                case MaterialTypes._multilayered_baked:
                    mat._multilayered_baked.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\internal\multilayered_baked.mt";
                    break;
                case MaterialTypes._silverhand_props_overlay:
                    mat._silverhand_props_overlay.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\materials\holograms\silverhand_props_overlay.mt";
                    break;
                case MaterialTypes._mikoshi_fullscr_transition:
                    mat._mikoshi_fullscr_transition.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\fx\quest\q116\mikoshi_fullscr_transition.mt";
                    break;
                case MaterialTypes._decal:
                    mat._decal.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\decal.remt";
                    break;
                case MaterialTypes._decal_normal:
                    mat._decal_normal.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\decal_normal.remt";
                    break;
                case MaterialTypes._pbr_layer:
                    mat._pbr_layer.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"base\materials\pbr_layer.remt";
                    break;
                case MaterialTypes._debugdraw:
                    mat._debugdraw.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\debugdraw.remt";
                    break;
                case MaterialTypes._fallback:
                    mat._fallback.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\fallback.remt";
                    break;
                case MaterialTypes._metal_base:
                    mat._metal_base.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\metal_base.remt";
                    break;
                case MaterialTypes._mirror:
                    mat._mirror.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\mirror.remt";
                    break;
                case MaterialTypes._particles_generic:
                    mat._particles_generic.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\particles_generic.remt";
                    break;
                case MaterialTypes._particles_liquid:
                    mat._particles_liquid.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = @"engine\materials\particles_liquid.remt";
                    break;
            }
        }
        public static void ContainRawMaterialEnum(ref RawMaterial rawMaterial, CMaterialInstance cMaterialInstance, string Type)
        {
            switch (Type)
            {
                case "3d_map.mt":
                    if (rawMaterial._3d_map == null)
                        rawMaterial._3d_map = new _3d_map();
                    rawMaterial._3d_map.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._3d_map.ToString();
                    break;
                case "3d_map_cubes.mt":
                    if (rawMaterial._3d_map_cubes == null)
                        rawMaterial._3d_map_cubes = new _3d_map_cubes();
                    rawMaterial._3d_map_cubes.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._3d_map_cubes.ToString();
                    break;
                case "3d_map_solid.mt":
                    if (rawMaterial._3d_map_solid == null)
                        rawMaterial._3d_map_solid = new _3d_map_solid();
                    rawMaterial._3d_map_solid.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._3d_map_solid.ToString();
                    break;
                case "beyondblackwall.mt":
                    if (rawMaterial._beyondblackwall == null)
                        rawMaterial._beyondblackwall = new _beyondblackwall();
                    rawMaterial._beyondblackwall.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._beyondblackwall.ToString();
                    break;
                case "beyondblackwall_chars.mt":
                    if (rawMaterial._beyondblackwall_chars == null)
                        rawMaterial._beyondblackwall_chars = new _beyondblackwall_chars();
                    rawMaterial._beyondblackwall_chars.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._beyondblackwall_chars.ToString();
                    break;
                case "beyondblackwall_sky.mt":
                    if (rawMaterial._beyondblackwall_sky == null)
                        rawMaterial._beyondblackwall_sky = new _beyondblackwall_sky();
                    rawMaterial._beyondblackwall_sky.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._beyondblackwall_sky.ToString();
                    break;
                case "beyondblackwall_sky_raymarch.mt":
                    if (rawMaterial._beyondblackwall_sky_raymarch == null)
                        rawMaterial._beyondblackwall_sky_raymarch = new _beyondblackwall_sky_raymarch();
                    rawMaterial._beyondblackwall_sky_raymarch.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._beyondblackwall_sky_raymarch.ToString();
                    break;
                case "blood_puddle_decal.mt":
                    if (rawMaterial._blood_puddle_decal == null)
                        rawMaterial._blood_puddle_decal = new _blood_puddle_decal();
                    rawMaterial._blood_puddle_decal.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._blood_puddle_decal.ToString();
                    break;
                case "cable.mt":
                    if (rawMaterial._cable == null)
                        rawMaterial._cable = new _cable();
                    rawMaterial._cable.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cable.ToString();
                    break;
                case "circuit_wires.mt":
                    if (rawMaterial._circuit_wires == null)
                        rawMaterial._circuit_wires = new _circuit_wires();
                    rawMaterial._circuit_wires.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._circuit_wires.ToString();
                    break;
                case "cloth_mov.mt":
                    if (rawMaterial._cloth_mov == null)
                        rawMaterial._cloth_mov = new _cloth_mov();
                    rawMaterial._cloth_mov.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cloth_mov.ToString();
                    break;
                case "cloth_mov_multilayered.mt":
                    if (rawMaterial._cloth_mov_multilayered == null)
                        rawMaterial._cloth_mov_multilayered = new _cloth_mov_multilayered();
                    rawMaterial._cloth_mov_multilayered.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cloth_mov_multilayered.ToString();
                    break;
                case "cyberparticles_base.mt":
                    if (rawMaterial._cyberparticles_base == null)
                        rawMaterial._cyberparticles_base = new _cyberparticles_base();
                    rawMaterial._cyberparticles_base.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberparticles_base.ToString();
                    break;
                case "cyberparticles_blackwall.mt":
                    if (rawMaterial._cyberparticles_blackwall == null)
                        rawMaterial._cyberparticles_blackwall = new _cyberparticles_blackwall();
                    rawMaterial._cyberparticles_blackwall.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberparticles_blackwall.ToString();
                    break;
                case "cyberparticles_blackwall_touch.mt":
                    if (rawMaterial._cyberparticles_blackwall_touch == null)
                        rawMaterial._cyberparticles_blackwall_touch = new _cyberparticles_blackwall_touch();
                    rawMaterial._cyberparticles_blackwall_touch.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberparticles_blackwall_touch.ToString();
                    break;
                case "cyberparticles_braindance.mt":
                    if (rawMaterial._cyberparticles_braindance == null)
                        rawMaterial._cyberparticles_braindance = new _cyberparticles_braindance();
                    rawMaterial._cyberparticles_braindance.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberparticles_braindance.ToString();
                    break;
                case "cyberparticles_dynamic.mt":
                    if (rawMaterial._cyberparticles_dynamic == null)
                        rawMaterial._cyberparticles_dynamic = new _cyberparticles_dynamic();
                    rawMaterial._cyberparticles_dynamic.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberparticles_dynamic.ToString();
                    break;
                case "cyberparticles_platform.mt":
                    if (rawMaterial._cyberparticles_platform == null)
                        rawMaterial._cyberparticles_platform = new _cyberparticles_platform();
                    rawMaterial._cyberparticles_platform.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberparticles_platform.ToString();
                    break;
                case "decal_emissive_color.mt":
                    if (rawMaterial._decal_emissive_color == null)
                        rawMaterial._decal_emissive_color = new _decal_emissive_color();
                    rawMaterial._decal_emissive_color.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_emissive_color.ToString();
                    break;
                case "decal_emissive_only.mt":
                    if (rawMaterial._decal_emissive_only == null)
                        rawMaterial._decal_emissive_only = new _decal_emissive_only();
                    rawMaterial._decal_emissive_only.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_emissive_only.ToString();
                    break;
                case "decal_forward.mt":
                    if (rawMaterial._decal_forward == null)
                        rawMaterial._decal_forward = new _decal_forward();
                    rawMaterial._decal_forward.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_forward.ToString();
                    break;
                case "decal_gradientmap_recolor.mt":
                    if (rawMaterial._decal_gradientmap_recolor == null)
                        rawMaterial._decal_gradientmap_recolor = new _decal_gradientmap_recolor();
                    rawMaterial._decal_gradientmap_recolor.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_gradientmap_recolor.ToString();
                    break;
                case "decal_gradientmap_recolor_emissive.mt":
                    if (rawMaterial._decal_gradientmap_recolor_emissive == null)
                        rawMaterial._decal_gradientmap_recolor_emissive = new _decal_gradientmap_recolor_emissive();
                    rawMaterial._decal_gradientmap_recolor_emissive.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_gradientmap_recolor_emissive.ToString();
                    break;
                case "decal_normal_roughness.mt":
                    if (rawMaterial._decal_normal_roughness == null)
                        rawMaterial._decal_normal_roughness = new _decal_normal_roughness();
                    rawMaterial._decal_normal_roughness.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_normal_roughness.ToString();
                    break;
                case "decal_normal_roughness_metalness.mt":
                    if (rawMaterial._decal_normal_roughness_metalness == null)
                        rawMaterial._decal_normal_roughness_metalness = new _decal_normal_roughness_metalness();
                    rawMaterial._decal_normal_roughness_metalness.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_normal_roughness_metalness.ToString();
                    break;
                case "decal_normal_roughness_metalness_2.mt":
                    if (rawMaterial._decal_normal_roughness_metalness_2 == null)
                        rawMaterial._decal_normal_roughness_metalness_2 = new _decal_normal_roughness_metalness_2();
                    rawMaterial._decal_normal_roughness_metalness_2.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_normal_roughness_metalness_2.ToString();
                    break;
                case "decal_parallax.mt":
                    if (rawMaterial._decal_parallax == null)
                        rawMaterial._decal_parallax = new _decal_parallax();
                    rawMaterial._decal_parallax.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_parallax.ToString();
                    break;
                case "decal_puddle.mt":
                    if (rawMaterial._decal_puddle == null)
                        rawMaterial._decal_puddle = new _decal_puddle();
                    rawMaterial._decal_puddle.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_puddle.ToString();
                    break;
                case "decal_roughness.mt":
                    if (rawMaterial._decal_roughness == null)
                        rawMaterial._decal_roughness = new _decal_roughness();
                    rawMaterial._decal_roughness.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_roughness.ToString();
                    break;
                case "decal_roughness_only.mt":
                    if (rawMaterial._decal_roughness_only == null)
                        rawMaterial._decal_roughness_only = new _decal_roughness_only();
                    rawMaterial._decal_roughness_only.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_roughness_only.ToString();
                    break;
                case "decal_terrain_projected.mt":
                    if (rawMaterial._decal_terrain_projected == null)
                        rawMaterial._decal_terrain_projected = new _decal_terrain_projected();
                    rawMaterial._decal_terrain_projected.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_terrain_projected.ToString();
                    break;
                case "decal_tintable.mt":
                    if (rawMaterial._decal_tintable == null)
                        rawMaterial._decal_tintable = new _decal_tintable();
                    rawMaterial._decal_tintable.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_tintable.ToString();
                    break;
                case "diode_sign.mt":
                    if (rawMaterial._diode_sign == null)
                        rawMaterial._diode_sign = new _diode_sign();
                    rawMaterial._diode_sign.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._diode_sign.ToString();
                    break;
                case "earth_globe.mt":
                    if (rawMaterial._earth_globe == null)
                        rawMaterial._earth_globe = new _earth_globe();
                    rawMaterial._earth_globe.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._earth_globe.ToString();
                    break;
                case "earth_globe_atmosphere.mt":
                    if (rawMaterial._earth_globe_atmosphere == null)
                        rawMaterial._earth_globe_atmosphere = new _earth_globe_atmosphere();
                    rawMaterial._earth_globe_atmosphere.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._earth_globe_atmosphere.ToString();
                    break;
                case "earth_globe_lights.mt":
                    if (rawMaterial._earth_globe_lights == null)
                        rawMaterial._earth_globe_lights = new _earth_globe_lights();
                    rawMaterial._earth_globe_lights.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._earth_globe_lights.ToString();
                    break;
                case "emissive_control.mt":
                    if (rawMaterial._emissive_control == null)
                        rawMaterial._emissive_control = new _emissive_control();
                    rawMaterial._emissive_control.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._emissive_control.ToString();
                    break;
                case "eye.mt":
                    if (rawMaterial._eye == null)
                        rawMaterial._eye = new _eye();
                    rawMaterial._eye.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._eye.ToString();
                    break;
                case "eye_blendable.mt":
                    if (rawMaterial._eye_blendable == null)
                        rawMaterial._eye_blendable = new _eye_blendable();
                    rawMaterial._eye_blendable.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._eye_blendable.ToString();
                    break;
                case "eye_gradient.mt":
                    if (rawMaterial._eye_gradient == null)
                        rawMaterial._eye_gradient = new _eye_gradient();
                    rawMaterial._eye_gradient.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._eye_gradient.ToString();
                    break;
                case "eye_shadow.mt":
                    if (rawMaterial._eye_shadow == null)
                        rawMaterial._eye_shadow = new _eye_shadow();
                    rawMaterial._eye_shadow.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._eye_shadow.ToString();
                    break;
                case "eye_shadow_blendable.mt":
                    if (rawMaterial._eye_shadow_blendable == null)
                        rawMaterial._eye_shadow_blendable = new _eye_shadow_blendable();
                    rawMaterial._eye_shadow_blendable.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._eye_shadow_blendable.ToString();
                    break;
                case "fake_occluder.mt":
                    if (rawMaterial._fake_occluder == null)
                        rawMaterial._fake_occluder = new _fake_occluder();
                    rawMaterial._fake_occluder.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._fake_occluder.ToString();
                    break;
                case "fillable_fluid.mt":
                    if (rawMaterial._fillable_fluid == null)
                        rawMaterial._fillable_fluid = new _fillable_fluid();
                    rawMaterial._fillable_fluid.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._fillable_fluid.ToString();
                    break;
                case "fillable_fluid_vertex.mt":
                    if (rawMaterial._fillable_fluid_vertex == null)
                        rawMaterial._fillable_fluid_vertex = new _fillable_fluid_vertex();
                    rawMaterial._fillable_fluid_vertex.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._fillable_fluid_vertex.ToString();
                    break;
                case "fluid_mov.mt":
                    if (rawMaterial._fluid_mov == null)
                        rawMaterial._fluid_mov = new _fluid_mov();
                    rawMaterial._fluid_mov.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._fluid_mov.ToString();
                    break;
                case "frosted_glass.mt":
                    if (rawMaterial._frosted_glass == null)
                        rawMaterial._frosted_glass = new _frosted_glass();
                    rawMaterial._frosted_glass.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._frosted_glass.ToString();
                    break;
                case "frosted_glass_curtain.mt":
                    if (rawMaterial._frosted_glass_curtain == null)
                        rawMaterial._frosted_glass_curtain = new _frosted_glass_curtain();
                    rawMaterial._frosted_glass_curtain.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._frosted_glass_curtain.ToString();
                    break;
                case "glass.mt":
                    if (rawMaterial._glass == null)
                        rawMaterial._glass = new _glass();
                    rawMaterial._glass.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._glass.ToString();
                    break;
                case "glass_blendable.mt":
                    if (rawMaterial._glass_blendable == null)
                        rawMaterial._glass_blendable = new _glass_blendable();
                    rawMaterial._glass_blendable.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._glass_blendable.ToString();
                    break;
                case "glass_cracked_edge.mt":
                    if (rawMaterial._glass_cracked_edge == null)
                        rawMaterial._glass_cracked_edge = new _glass_cracked_edge();
                    rawMaterial._glass_cracked_edge.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._glass_cracked_edge.ToString();
                    break;
                case "glass_deferred.mt":
                    if (rawMaterial._glass_deferred == null)
                        rawMaterial._glass_deferred = new _glass_deferred();
                    rawMaterial._glass_deferred.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._glass_deferred.ToString();
                    break;
                case "glass_scope.mt":
                    if (rawMaterial._glass_scope == null)
                        rawMaterial._glass_scope = new _glass_scope();
                    rawMaterial._glass_scope.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._glass_scope.ToString();
                    break;
                case "glass_window_rain.mt":
                    if (rawMaterial._glass_window_rain == null)
                        rawMaterial._glass_window_rain = new _glass_window_rain();
                    rawMaterial._glass_window_rain.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._glass_window_rain.ToString();
                    break;
                case "hair.mt":
                    if (rawMaterial._hair == null)
                        rawMaterial._hair = new _hair();
                    rawMaterial._hair.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hair.ToString();
                    break;
                case "hair_blendable.mt":
                    if (rawMaterial._hair_blendable == null)
                        rawMaterial._hair_blendable = new _hair_blendable();
                    rawMaterial._hair_blendable.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hair_blendable.ToString();
                    break;
                case "hair_proxy.mt":
                    if (rawMaterial._hair_proxy == null)
                        rawMaterial._hair_proxy = new _hair_proxy();
                    rawMaterial._hair_proxy.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hair_proxy.ToString();
                    break;
                case "ice_fluid_mov.mt":
                    if (rawMaterial._ice_fluid_mov == null)
                        rawMaterial._ice_fluid_mov = new _ice_fluid_mov();
                    rawMaterial._ice_fluid_mov.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ice_fluid_mov.ToString();
                    break;
                case "ice_ver_mov_translucent.mt":
                    if (rawMaterial._ice_ver_mov_translucent == null)
                        rawMaterial._ice_ver_mov_translucent = new _ice_ver_mov_translucent();
                    rawMaterial._ice_ver_mov_translucent.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ice_ver_mov_translucent.ToString();
                    break;
                case "lights_interactive.mt":
                    if (rawMaterial._lights_interactive == null)
                        rawMaterial._lights_interactive = new _lights_interactive();
                    rawMaterial._lights_interactive.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._lights_interactive.ToString();
                    break;
                case "loot_drop_highlight.mt":
                    if (rawMaterial._loot_drop_highlight == null)
                        rawMaterial._loot_drop_highlight = new _loot_drop_highlight();
                    rawMaterial._loot_drop_highlight.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._loot_drop_highlight.ToString();
                    break;
                case "mesh_decal.mt":
                    if (rawMaterial._mesh_decal == null)
                        rawMaterial._mesh_decal = new _mesh_decal();
                    rawMaterial._mesh_decal.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal.ToString();
                    break;
                case "mesh_decal_blendable.mt":
                    if (rawMaterial._mesh_decal_blendable == null)
                        rawMaterial._mesh_decal_blendable = new _mesh_decal_blendable();
                    rawMaterial._mesh_decal_blendable.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_blendable.ToString();
                    break;
                case "mesh_decal_double_diffuse.mt":
                    if (rawMaterial._mesh_decal_double_diffuse == null)
                        rawMaterial._mesh_decal_double_diffuse = new _mesh_decal_double_diffuse();
                    rawMaterial._mesh_decal_double_diffuse.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_double_diffuse.ToString();
                    break;
                case "mesh_decal_emissive.mt":
                    if (rawMaterial._mesh_decal_emissive == null)
                        rawMaterial._mesh_decal_emissive = new _mesh_decal_emissive();
                    rawMaterial._mesh_decal_emissive.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_emissive.ToString();
                    break;
                case "mesh_decal_emissive_subsurface.mt":
                    if (rawMaterial._mesh_decal_emissive_subsurface == null)
                        rawMaterial._mesh_decal_emissive_subsurface = new _mesh_decal_emissive_subsurface();
                    rawMaterial._mesh_decal_emissive_subsurface.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_emissive_subsurface.ToString();
                    break;
                case "mesh_decal_gradientmap_recolor.mt":
                    if (rawMaterial._mesh_decal_gradientmap_recolor == null)
                        rawMaterial._mesh_decal_gradientmap_recolor = new _mesh_decal_gradientmap_recolor();
                    rawMaterial._mesh_decal_gradientmap_recolor.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_gradientmap_recolor.ToString();
                    break;
                case "mesh_decal_gradientmap_recolor_2.mt":
                    if (rawMaterial._mesh_decal_gradientmap_recolor_2 == null)
                        rawMaterial._mesh_decal_gradientmap_recolor_2 = new _mesh_decal_gradientmap_recolor_2();
                    rawMaterial._mesh_decal_gradientmap_recolor_2.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_gradientmap_recolor_2.ToString();
                    break;
                case "mesh_decal_gradientmap_recolor_emissive.mt":
                    if (rawMaterial._mesh_decal_gradientmap_recolor_emissive == null)
                        rawMaterial._mesh_decal_gradientmap_recolor_emissive = new _mesh_decal_gradientmap_recolor_emissive();
                    rawMaterial._mesh_decal_gradientmap_recolor_emissive.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_gradientmap_recolor_emissive.ToString();
                    break;
                case "mesh_decal_multitinted.mt":
                    if (rawMaterial._mesh_decal_multitinted == null)
                        rawMaterial._mesh_decal_multitinted = new _mesh_decal_multitinted();
                    rawMaterial._mesh_decal_multitinted.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_multitinted.ToString();
                    break;
                case "mesh_decal_parallax.mt":
                    if (rawMaterial._mesh_decal_parallax == null)
                        rawMaterial._mesh_decal_parallax = new _mesh_decal_parallax();
                    rawMaterial._mesh_decal_parallax.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_parallax.ToString();
                    break;
                case "mesh_decal_revealed.mt":
                    if (rawMaterial._mesh_decal_revealed == null)
                        rawMaterial._mesh_decal_revealed = new _mesh_decal_revealed();
                    rawMaterial._mesh_decal_revealed.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_revealed.ToString();
                    break;
                case "mesh_decal_wet_character.mt":
                    if (rawMaterial._mesh_decal_wet_character == null)
                        rawMaterial._mesh_decal_wet_character = new _mesh_decal_wet_character();
                    rawMaterial._mesh_decal_wet_character.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_wet_character.ToString();
                    break;
                case "metal_base_bink.mt":
                    if (rawMaterial._metal_base_bink == null)
                        rawMaterial._metal_base_bink = new _metal_base_bink();
                    rawMaterial._metal_base_bink.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_bink.ToString();
                    break;
                case "metal_base_det.mt":
                    if (rawMaterial._metal_base_det == null)
                        rawMaterial._metal_base_det = new _metal_base_det();
                    rawMaterial._metal_base_det.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_det.ToString();
                    break;
                case "metal_base_det_dithered.mt":
                    if (rawMaterial._metal_base_det_dithered == null)
                        rawMaterial._metal_base_det_dithered = new _metal_base_det_dithered();
                    rawMaterial._metal_base_det_dithered.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_det_dithered.ToString();
                    break;
                case "metal_base_dithered.mt":
                    if (rawMaterial._metal_base_dithered == null)
                        rawMaterial._metal_base_dithered = new _metal_base_dithered();
                    rawMaterial._metal_base_dithered.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_dithered.ToString();
                    break;
                case "metal_base_gradientmap_recolor.mt":
                    if (rawMaterial._metal_base_gradientmap_recolor == null)
                        rawMaterial._metal_base_gradientmap_recolor = new _metal_base_gradientmap_recolor();
                    rawMaterial._metal_base_gradientmap_recolor.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_gradientmap_recolor.ToString();
                    break;
                case "metal_base_parallax.mt":
                    if (rawMaterial._metal_base_parallax == null)
                        rawMaterial._metal_base_parallax = new _metal_base_parallax();
                    rawMaterial._metal_base_parallax.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_parallax.ToString();
                    break;
                case "metal_base_trafficlight_proxy.mt":
                    if (rawMaterial._metal_base_trafficlight_proxy == null)
                        rawMaterial._metal_base_trafficlight_proxy = new _metal_base_trafficlight_proxy();
                    rawMaterial._metal_base_trafficlight_proxy.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_trafficlight_proxy.ToString();
                    break;
                case "metal_base_ui.mt":
                    if (rawMaterial._metal_base_ui == null)
                        rawMaterial._metal_base_ui = new _metal_base_ui();
                    rawMaterial._metal_base_ui.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_ui.ToString();
                    break;
                case "metal_base_vertexcolored.mt":
                    if (rawMaterial._metal_base_vertexcolored == null)
                        rawMaterial._metal_base_vertexcolored = new _metal_base_vertexcolored();
                    rawMaterial._metal_base_vertexcolored.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_vertexcolored.ToString();
                    break;
                case "mikoshi_blocks_big.mt":
                    if (rawMaterial._mikoshi_blocks_big == null)
                        rawMaterial._mikoshi_blocks_big = new _mikoshi_blocks_big();
                    rawMaterial._mikoshi_blocks_big.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mikoshi_blocks_big.ToString();
                    break;
                case "mikoshi_blocks_medium.mt":
                    if (rawMaterial._mikoshi_blocks_medium == null)
                        rawMaterial._mikoshi_blocks_medium = new _mikoshi_blocks_medium();
                    rawMaterial._mikoshi_blocks_medium.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mikoshi_blocks_medium.ToString();
                    break;
                case "mikoshi_blocks_small.mt":
                    if (rawMaterial._mikoshi_blocks_small == null)
                        rawMaterial._mikoshi_blocks_small = new _mikoshi_blocks_small();
                    rawMaterial._mikoshi_blocks_small.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mikoshi_blocks_small.ToString();
                    break;
                case "mikoshi_parallax.mt":
                    if (rawMaterial._mikoshi_parallax == null)
                        rawMaterial._mikoshi_parallax = new _mikoshi_parallax();
                    rawMaterial._mikoshi_parallax.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mikoshi_parallax.ToString();
                    break;
                case "mikoshi_prison_cell.mt":
                    if (rawMaterial._mikoshi_prison_cell == null)
                        rawMaterial._mikoshi_prison_cell = new _mikoshi_prison_cell();
                    rawMaterial._mikoshi_prison_cell.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mikoshi_prison_cell.ToString();
                    break;
                case "multilayered_clear_coat.mt":
                    if (rawMaterial._multilayered_clear_coat == null)
                        rawMaterial._multilayered_clear_coat = new _multilayered_clear_coat();
                    rawMaterial._multilayered_clear_coat.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._multilayered_clear_coat.ToString();
                    break;
                case "multilayered_terrain.mt":
                    if (rawMaterial._multilayered_terrain == null)
                        rawMaterial._multilayered_terrain = new _multilayered_terrain();
                    rawMaterial._multilayered_terrain.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._multilayered_terrain.ToString();
                    break;
                case "neon_parallax.mt":
                    if (rawMaterial._neon_parallax == null)
                        rawMaterial._neon_parallax = new _neon_parallax();
                    rawMaterial._neon_parallax.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._neon_parallax.ToString();
                    break;
                case "presimulated_particles.mt":
                    if (rawMaterial._presimulated_particles == null)
                        rawMaterial._presimulated_particles = new _presimulated_particles();
                    rawMaterial._presimulated_particles.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._presimulated_particles.ToString();
                    break;
                case "proxy_ad.mt":
                    if (rawMaterial._proxy_ad == null)
                        rawMaterial._proxy_ad = new _proxy_ad();
                    rawMaterial._proxy_ad.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._proxy_ad.ToString();
                    break;
                case "proxy_crowd.mt":
                    if (rawMaterial._proxy_crowd == null)
                        rawMaterial._proxy_crowd = new _proxy_crowd();
                    rawMaterial._proxy_crowd.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._proxy_crowd.ToString();
                    break;
                case "q116_mikoshi_cubes.mt":
                    if (rawMaterial._q116_mikoshi_cubes == null)
                        rawMaterial._q116_mikoshi_cubes = new _q116_mikoshi_cubes();
                    rawMaterial._q116_mikoshi_cubes.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._q116_mikoshi_cubes.ToString();
                    break;
                case "q116_mikoshi_floor.mt":
                    if (rawMaterial._q116_mikoshi_floor == null)
                        rawMaterial._q116_mikoshi_floor = new _q116_mikoshi_floor();
                    rawMaterial._q116_mikoshi_floor.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._q116_mikoshi_floor.ToString();
                    break;
                case "q202_lake_surface.mt":
                    if (rawMaterial._q202_lake_surface == null)
                        rawMaterial._q202_lake_surface = new _q202_lake_surface();
                    rawMaterial._q202_lake_surface.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._q202_lake_surface.ToString();
                    break;
                case "rain.mt":
                    if (rawMaterial._rain == null)
                        rawMaterial._rain = new _rain();
                    rawMaterial._rain.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._rain.ToString();
                    break;
                case "road_debug_grid.mt":
                    if (rawMaterial._road_debug_grid == null)
                        rawMaterial._road_debug_grid = new _road_debug_grid();
                    rawMaterial._road_debug_grid.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._road_debug_grid.ToString();
                    break;
                case "set_stencil_3.mt":
                    if (rawMaterial._set_stencil_3 == null)
                        rawMaterial._set_stencil_3 = new _set_stencil_3();
                    rawMaterial._set_stencil_3.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._set_stencil_3.ToString();
                    break;
                case "silverhand_overlay.mt":
                    if (rawMaterial._silverhand_overlay == null)
                        rawMaterial._silverhand_overlay = new _silverhand_overlay();
                    rawMaterial._silverhand_overlay.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._silverhand_overlay.ToString();
                    break;
                case "silverhand_overlay_blendable.mt":
                    if (rawMaterial._silverhand_overlay_blendable == null)
                        rawMaterial._silverhand_overlay_blendable = new _silverhand_overlay_blendable();
                    rawMaterial._silverhand_overlay_blendable.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._silverhand_overlay_blendable.ToString();
                    break;
                case "skin.mt":
                    if (rawMaterial._skin == null)
                        rawMaterial._skin = new _skin();
                    rawMaterial._skin.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._skin.ToString();
                    break;
                case "skin_blendable.mt":
                    if (rawMaterial._skin_blendable == null)
                        rawMaterial._skin_blendable = new _skin_blendable();
                    rawMaterial._skin_blendable.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._skin_blendable.ToString();
                    break;
                case "skybox.mt":
                    if (rawMaterial._skybox == null)
                        rawMaterial._skybox = new _skybox();
                    rawMaterial._skybox.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._skybox.ToString();
                    break;
                case "speedtree_3d_v8_billboard.mt":
                    if (rawMaterial._speedtree_3d_v8_billboard == null)
                        rawMaterial._speedtree_3d_v8_billboard = new _speedtree_3d_v8_billboard();
                    rawMaterial._speedtree_3d_v8_billboard.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._speedtree_3d_v8_billboard.ToString();
                    break;
                case "speedtree_3d_v8_onesided.mt":
                    if (rawMaterial._speedtree_3d_v8_onesided == null)
                        rawMaterial._speedtree_3d_v8_onesided = new _speedtree_3d_v8_onesided();
                    rawMaterial._speedtree_3d_v8_onesided.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._speedtree_3d_v8_onesided.ToString();
                    break;
                case "speedtree_3d_v8_onesided_gradient_recolor.mt":
                    if (rawMaterial._speedtree_3d_v8_onesided_gradient_recolor == null)
                        rawMaterial._speedtree_3d_v8_onesided_gradient_recolor = new _speedtree_3d_v8_onesided_gradient_recolor();
                    rawMaterial._speedtree_3d_v8_onesided_gradient_recolor.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._speedtree_3d_v8_onesided_gradient_recolor.ToString();
                    break;
                case "speedtree_3d_v8_seams.mt":
                    if (rawMaterial._speedtree_3d_v8_seams == null)
                        rawMaterial._speedtree_3d_v8_seams = new _speedtree_3d_v8_seams();
                    rawMaterial._speedtree_3d_v8_seams.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._speedtree_3d_v8_seams.ToString();
                    break;
                case "speedtree_3d_v8_twosided.mt":
                    if (rawMaterial._speedtree_3d_v8_twosided == null)
                        rawMaterial._speedtree_3d_v8_twosided = new _speedtree_3d_v8_twosided();
                    rawMaterial._speedtree_3d_v8_twosided.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._speedtree_3d_v8_twosided.ToString();
                    break;
                case "spline_deformed_metal_base.mt":
                    if (rawMaterial._spline_deformed_metal_base == null)
                        rawMaterial._spline_deformed_metal_base = new _spline_deformed_metal_base();
                    rawMaterial._spline_deformed_metal_base.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._spline_deformed_metal_base.ToString();
                    break;
                case "terrain_simple.mt":
                    if (rawMaterial._terrain_simple == null)
                        rawMaterial._terrain_simple = new _terrain_simple();
                    rawMaterial._terrain_simple.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._terrain_simple.ToString();
                    break;
                case "top_down_car_proxy_depth.mt":
                    if (rawMaterial._top_down_car_proxy_depth == null)
                        rawMaterial._top_down_car_proxy_depth = new _top_down_car_proxy_depth();
                    rawMaterial._top_down_car_proxy_depth.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._top_down_car_proxy_depth.ToString();
                    break;
                case "trail_decal.mt":
                    if (rawMaterial._trail_decal == null)
                        rawMaterial._trail_decal = new _trail_decal();
                    rawMaterial._trail_decal.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._trail_decal.ToString();
                    break;
                case "trail_decal_normal.mt":
                    if (rawMaterial._trail_decal_normal == null)
                        rawMaterial._trail_decal_normal = new _trail_decal_normal();
                    rawMaterial._trail_decal_normal.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._trail_decal_normal.ToString();
                    break;
                case "trail_decal_normal_color.mt":
                    if (rawMaterial._trail_decal_normal_color == null)
                        rawMaterial._trail_decal_normal_color = new _trail_decal_normal_color();
                    rawMaterial._trail_decal_normal_color.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._trail_decal_normal_color.ToString();
                    break;
                case "transparent_liquid.mt":
                    if (rawMaterial._transparent_liquid == null)
                        rawMaterial._transparent_liquid = new _transparent_liquid();
                    rawMaterial._transparent_liquid.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._transparent_liquid.ToString();
                    break;
                case "underwater_blood.mt":
                    if (rawMaterial._underwater_blood == null)
                        rawMaterial._underwater_blood = new _underwater_blood();
                    rawMaterial._underwater_blood.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._underwater_blood.ToString();
                    break;
                case "vehicle_destr_blendshape.mt":
                    if (rawMaterial._vehicle_destr_blendshape == null)
                        rawMaterial._vehicle_destr_blendshape = new _vehicle_destr_blendshape();
                    rawMaterial._vehicle_destr_blendshape.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._vehicle_destr_blendshape.ToString();
                    break;
                case "vehicle_glass.mt":
                    if (rawMaterial._vehicle_glass == null)
                        rawMaterial._vehicle_glass = new _vehicle_glass();
                    rawMaterial._vehicle_glass.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._vehicle_glass.ToString();
                    break;
                case "vehicle_glass_proxy.mt":
                    if (rawMaterial._vehicle_glass_proxy == null)
                        rawMaterial._vehicle_glass_proxy = new _vehicle_glass_proxy();
                    rawMaterial._vehicle_glass_proxy.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._vehicle_glass_proxy.ToString();
                    break;
                case "vehicle_lights.mt":
                    if (rawMaterial._vehicle_lights == null)
                        rawMaterial._vehicle_lights = new _vehicle_lights();
                    rawMaterial._vehicle_lights.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._vehicle_lights.ToString();
                    break;
                case "vehicle_mesh_decal.mt":
                    if (rawMaterial._vehicle_mesh_decal == null)
                        rawMaterial._vehicle_mesh_decal = new _vehicle_mesh_decal();
                    rawMaterial._vehicle_mesh_decal.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._vehicle_mesh_decal.ToString();
                    break;
                case "ver_mov.mt":
                    if (rawMaterial._ver_mov == null)
                        rawMaterial._ver_mov = new _ver_mov();
                    rawMaterial._ver_mov.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ver_mov.ToString();
                    break;
                case "ver_mov_glass.mt":
                    if (rawMaterial._ver_mov_glass == null)
                        rawMaterial._ver_mov_glass = new _ver_mov_glass();
                    rawMaterial._ver_mov_glass.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ver_mov_glass.ToString();
                    break;
                case "ver_mov_multilayered.mt":
                    if (rawMaterial._ver_mov_multilayered == null)
                        rawMaterial._ver_mov_multilayered = new _ver_mov_multilayered();
                    rawMaterial._ver_mov_multilayered.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ver_mov_multilayered.ToString();
                    break;
                case "ver_skinned_mov.mt":
                    if (rawMaterial._ver_skinned_mov == null)
                        rawMaterial._ver_skinned_mov = new _ver_skinned_mov();
                    rawMaterial._ver_skinned_mov.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ver_skinned_mov.ToString();
                    break;
                case "ver_skinned_mov_parade.mt":
                    if (rawMaterial._ver_skinned_mov_parade == null)
                        rawMaterial._ver_skinned_mov_parade = new _ver_skinned_mov_parade();
                    rawMaterial._ver_skinned_mov_parade.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ver_skinned_mov_parade.ToString();
                    break;
                case "window_interior_uv.mt":
                    if (rawMaterial._window_interior_uv == null)
                        rawMaterial._window_interior_uv = new _window_interior_uv();
                    rawMaterial._window_interior_uv.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._window_interior_uv.ToString();
                    break;
                case "window_parallax_interior.mt":
                    if (rawMaterial._window_parallax_interior == null)
                        rawMaterial._window_parallax_interior = new _window_parallax_interior();
                    rawMaterial._window_parallax_interior.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._window_parallax_interior.ToString();
                    break;
                case "window_parallax_interior_proxy.mt":
                    if (rawMaterial._window_parallax_interior_proxy == null)
                        rawMaterial._window_parallax_interior_proxy = new _window_parallax_interior_proxy();
                    rawMaterial._window_parallax_interior_proxy.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._window_parallax_interior_proxy.ToString();
                    break;
                case "window_parallax_interior_proxy_buffer.mt":
                    if (rawMaterial._window_parallax_interior_proxy_buffer == null)
                        rawMaterial._window_parallax_interior_proxy_buffer = new _window_parallax_interior_proxy_buffer();
                    rawMaterial._window_parallax_interior_proxy_buffer.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._window_parallax_interior_proxy_buffer.ToString();
                    break;
                case "window_very_long_distance.mt":
                    if (rawMaterial._window_very_long_distance == null)
                        rawMaterial._window_very_long_distance = new _window_very_long_distance();
                    rawMaterial._window_very_long_distance.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._window_very_long_distance.ToString();
                    break;
                case "worldspace_grid.mt":
                    if (rawMaterial._worldspace_grid == null)
                        rawMaterial._worldspace_grid = new _worldspace_grid();
                    rawMaterial._worldspace_grid.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._worldspace_grid.ToString();
                    break;
                case "bink_simple.mt":
                    if (rawMaterial._bink_simple == null)
                        rawMaterial._bink_simple = new _bink_simple();
                    rawMaterial._bink_simple.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._bink_simple.ToString();
                    break;
                case "cable_strip.mt":
                    if (rawMaterial._cable_strip == null)
                        rawMaterial._cable_strip = new _cable_strip();
                    rawMaterial._cable_strip.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cable_strip.ToString();
                    break;
                case "debugdraw_bias.mt":
                    if (rawMaterial._debugdraw_bias == null)
                        rawMaterial._debugdraw_bias = new _debugdraw_bias();
                    rawMaterial._debugdraw_bias.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._debugdraw_bias.ToString();
                    break;
                case "debugdraw_wireframe.mt":
                    if (rawMaterial._debugdraw_wireframe == null)
                        rawMaterial._debugdraw_wireframe = new _debugdraw_wireframe();
                    rawMaterial._debugdraw_wireframe.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._debugdraw_wireframe.ToString();
                    break;
                case "debugdraw_wireframe_bias.mt":
                    if (rawMaterial._debugdraw_wireframe_bias == null)
                        rawMaterial._debugdraw_wireframe_bias = new _debugdraw_wireframe_bias();
                    rawMaterial._debugdraw_wireframe_bias.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._debugdraw_wireframe_bias.ToString();
                    break;
                case "debug_coloring.mt":
                    if (rawMaterial._debug_coloring == null)
                        rawMaterial._debug_coloring = new _debug_coloring();
                    rawMaterial._debug_coloring.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._debug_coloring.ToString();
                    break;
                case "font.mt":
                    if (rawMaterial._font == null)
                        rawMaterial._font = new _font();
                    rawMaterial._font.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._font.ToString();
                    break;
                case "global_water_patch.mt":
                    if (rawMaterial._global_water_patch == null)
                        rawMaterial._global_water_patch = new _global_water_patch();
                    rawMaterial._global_water_patch.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._global_water_patch.ToString();
                    break;
                case "metal_base_animated_uv.mt":
                    if (rawMaterial._metal_base_animated_uv == null)
                        rawMaterial._metal_base_animated_uv = new _metal_base_animated_uv();
                    rawMaterial._metal_base_animated_uv.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_animated_uv.ToString();
                    break;
                case "metal_base_blendable.mt":
                    if (rawMaterial._metal_base_blendable == null)
                        rawMaterial._metal_base_blendable = new _metal_base_blendable();
                    rawMaterial._metal_base_blendable.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_blendable.ToString();
                    break;
                case "metal_base_fence.mt":
                    if (rawMaterial._metal_base_fence == null)
                        rawMaterial._metal_base_fence = new _metal_base_fence();
                    rawMaterial._metal_base_fence.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_fence.ToString();
                    break;
                case "metal_base_garment.mt":
                    if (rawMaterial._metal_base_garment == null)
                        rawMaterial._metal_base_garment = new _metal_base_garment();
                    rawMaterial._metal_base_garment.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_garment.ToString();
                    break;
                case "metal_base_packed.mt":
                    if (rawMaterial._metal_base_packed == null)
                        rawMaterial._metal_base_packed = new _metal_base_packed();
                    rawMaterial._metal_base_packed.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_packed.ToString();
                    break;
                case "metal_base_proxy.mt":
                    if (rawMaterial._metal_base_proxy == null)
                        rawMaterial._metal_base_proxy = new _metal_base_proxy();
                    rawMaterial._metal_base_proxy.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_proxy.ToString();
                    break;
                case "multilayered.mt":
                    if (rawMaterial._multilayered == null)
                        rawMaterial._multilayered = new _multilayered();
                    rawMaterial._multilayered.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._multilayered.ToString();
                    break;
                case "multilayered_debug.mt":
                    if (rawMaterial._multilayered_debug == null)
                        rawMaterial._multilayered_debug = new _multilayered_debug();
                    rawMaterial._multilayered_debug.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._multilayered_debug.ToString();
                    break;
                case "pbr_simple.mt":
                    if (rawMaterial._pbr_simple == null)
                        rawMaterial._pbr_simple = new _pbr_simple();
                    rawMaterial._pbr_simple.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._pbr_simple.ToString();
                    break;
                case "shadows_debug.mt":
                    if (rawMaterial._shadows_debug == null)
                        rawMaterial._shadows_debug = new _shadows_debug();
                    rawMaterial._shadows_debug.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._shadows_debug.ToString();
                    break;
                case "transparent_notxaa_2.mt":
                    if (rawMaterial._transparent_notxaa_2 == null)
                        rawMaterial._transparent_notxaa_2 = new _transparent_notxaa_2();
                    rawMaterial._transparent_notxaa_2.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._transparent_notxaa_2.ToString();
                    break;
                case "ui_default_element.mt":
                    if (rawMaterial._ui_default_element == null)
                        rawMaterial._ui_default_element = new _ui_default_element();
                    rawMaterial._ui_default_element.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_default_element.ToString();
                    break;
                case "ui_default_nine_slice_element.mt":
                    if (rawMaterial._ui_default_nine_slice_element == null)
                        rawMaterial._ui_default_nine_slice_element = new _ui_default_nine_slice_element();
                    rawMaterial._ui_default_nine_slice_element.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_default_nine_slice_element.ToString();
                    break;
                case "ui_default_tile_element.mt":
                    if (rawMaterial._ui_default_tile_element == null)
                        rawMaterial._ui_default_tile_element = new _ui_default_tile_element();
                    rawMaterial._ui_default_tile_element.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_default_tile_element.ToString();
                    break;
                case "ui_effect_box_blur.mt":
                    if (rawMaterial._ui_effect_box_blur == null)
                        rawMaterial._ui_effect_box_blur = new _ui_effect_box_blur();
                    rawMaterial._ui_effect_box_blur.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_box_blur.ToString();
                    break;
                case "ui_effect_color_correction.mt":
                    if (rawMaterial._ui_effect_color_correction == null)
                        rawMaterial._ui_effect_color_correction = new _ui_effect_color_correction();
                    rawMaterial._ui_effect_color_correction.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_color_correction.ToString();
                    break;
                case "ui_effect_color_fill.mt":
                    if (rawMaterial._ui_effect_color_fill == null)
                        rawMaterial._ui_effect_color_fill = new _ui_effect_color_fill();
                    rawMaterial._ui_effect_color_fill.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_color_fill.ToString();
                    break;
                case "ui_effect_glitch.mt":
                    if (rawMaterial._ui_effect_glitch == null)
                        rawMaterial._ui_effect_glitch = new _ui_effect_glitch();
                    rawMaterial._ui_effect_glitch.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_glitch.ToString();
                    break;
                case "ui_effect_inner_glow.mt":
                    if (rawMaterial._ui_effect_inner_glow == null)
                        rawMaterial._ui_effect_inner_glow = new _ui_effect_inner_glow();
                    rawMaterial._ui_effect_inner_glow.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_inner_glow.ToString();
                    break;
                case "ui_effect_light_sweep.mt":
                    if (rawMaterial._ui_effect_light_sweep == null)
                        rawMaterial._ui_effect_light_sweep = new _ui_effect_light_sweep();
                    rawMaterial._ui_effect_light_sweep.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_light_sweep.ToString();
                    break;
                case "ui_effect_linear_wipe.mt":
                    if (rawMaterial._ui_effect_linear_wipe == null)
                        rawMaterial._ui_effect_linear_wipe = new _ui_effect_linear_wipe();
                    rawMaterial._ui_effect_linear_wipe.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_linear_wipe.ToString();
                    break;
                case "ui_effect_mask.mt":
                    if (rawMaterial._ui_effect_mask == null)
                        rawMaterial._ui_effect_mask = new _ui_effect_mask();
                    rawMaterial._ui_effect_mask.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_mask.ToString();
                    break;
                case "ui_effect_point_cloud.mt":
                    if (rawMaterial._ui_effect_point_cloud == null)
                        rawMaterial._ui_effect_point_cloud = new _ui_effect_point_cloud();
                    rawMaterial._ui_effect_point_cloud.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_point_cloud.ToString();
                    break;
                case "ui_effect_radial_wipe.mt":
                    if (rawMaterial._ui_effect_radial_wipe == null)
                        rawMaterial._ui_effect_radial_wipe = new _ui_effect_radial_wipe();
                    rawMaterial._ui_effect_radial_wipe.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_radial_wipe.ToString();
                    break;
                case "ui_effect_swipe.mt":
                    if (rawMaterial._ui_effect_swipe == null)
                        rawMaterial._ui_effect_swipe = new _ui_effect_swipe();
                    rawMaterial._ui_effect_swipe.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_swipe.ToString();
                    break;
                case "ui_element_depth_texture.mt":
                    if (rawMaterial._ui_element_depth_texture == null)
                        rawMaterial._ui_element_depth_texture = new _ui_element_depth_texture();
                    rawMaterial._ui_element_depth_texture.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_element_depth_texture.ToString();
                    break;
                case "ui_panel.mt":
                    if (rawMaterial._ui_panel == null)
                        rawMaterial._ui_panel = new _ui_panel();
                    rawMaterial._ui_panel.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_panel.ToString();
                    break;
                case "ui_text_element.mt":
                    if (rawMaterial._ui_text_element == null)
                        rawMaterial._ui_text_element = new _ui_text_element();
                    rawMaterial._ui_text_element.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_text_element.ToString();
                    break;
                case "alphablend_glass.mt":
                    if (rawMaterial._alphablend_glass == null)
                        rawMaterial._alphablend_glass = new _alphablend_glass();
                    rawMaterial._alphablend_glass.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._alphablend_glass.ToString();
                    break;
                case "alpha_control_refraction.mt":
                    if (rawMaterial._alpha_control_refraction == null)
                        rawMaterial._alpha_control_refraction = new _alpha_control_refraction();
                    rawMaterial._alpha_control_refraction.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._alpha_control_refraction.ToString();
                    break;
                case "animated_decal.mt":
                    if (rawMaterial._animated_decal == null)
                        rawMaterial._animated_decal = new _animated_decal();
                    rawMaterial._animated_decal.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._animated_decal.ToString();
                    break;
                case "beam_particles.mt":
                    if (rawMaterial._beam_particles == null)
                        rawMaterial._beam_particles = new _beam_particles();
                    rawMaterial._beam_particles.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._beam_particles.ToString();
                    break;
                case "blackbodyradiation.mt":
                    if (rawMaterial._blackbodyradiation == null)
                        rawMaterial._blackbodyradiation = new _blackbodyradiation();
                    rawMaterial._blackbodyradiation.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._blackbodyradiation.ToString();
                    break;
                case "blackbody_simple.mt":
                    if (rawMaterial._blackbody_simple == null)
                        rawMaterial._blackbody_simple = new _blackbody_simple();
                    rawMaterial._blackbody_simple.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._blackbody_simple.ToString();
                    break;
                case "blood_transparent.mt":
                    if (rawMaterial._blood_transparent == null)
                        rawMaterial._blood_transparent = new _blood_transparent();
                    rawMaterial._blood_transparent.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._blood_transparent.ToString();
                    break;
                case "braindance_fog.mt":
                    if (rawMaterial._braindance_fog == null)
                        rawMaterial._braindance_fog = new _braindance_fog();
                    rawMaterial._braindance_fog.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._braindance_fog.ToString();
                    break;
                case "braindance_particle_thermal.mt":
                    if (rawMaterial._braindance_particle_thermal == null)
                        rawMaterial._braindance_particle_thermal = new _braindance_particle_thermal();
                    rawMaterial._braindance_particle_thermal.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._braindance_particle_thermal.ToString();
                    break;
                case "cloak.mt":
                    if (rawMaterial._cloak == null)
                        rawMaterial._cloak = new _cloak();
                    rawMaterial._cloak.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cloak.ToString();
                    break;
                case "cyberspace_pixelsort_stencil.mt":
                    if (rawMaterial._cyberspace_pixelsort_stencil == null)
                        rawMaterial._cyberspace_pixelsort_stencil = new _cyberspace_pixelsort_stencil();
                    rawMaterial._cyberspace_pixelsort_stencil.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberspace_pixelsort_stencil.ToString();
                    break;
                case "cyberspace_pixelsort_stencil_0.mt":
                    if (rawMaterial._cyberspace_pixelsort_stencil_0 == null)
                        rawMaterial._cyberspace_pixelsort_stencil_0 = new _cyberspace_pixelsort_stencil_0();
                    rawMaterial._cyberspace_pixelsort_stencil_0.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberspace_pixelsort_stencil_0.ToString();
                    break;
                case "cyberware_animation.mt":
                    if (rawMaterial._cyberware_animation == null)
                        rawMaterial._cyberware_animation = new _cyberware_animation();
                    rawMaterial._cyberware_animation.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberware_animation.ToString();
                    break;
                case "damage_indicator.mt":
                    if (rawMaterial._damage_indicator == null)
                        rawMaterial._damage_indicator = new _damage_indicator();
                    rawMaterial._damage_indicator.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._damage_indicator.ToString();
                    break;
                case "device_diode.mt":
                    if (rawMaterial._device_diode == null)
                        rawMaterial._device_diode = new _device_diode();
                    rawMaterial._device_diode.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._device_diode.ToString();
                    break;
                case "device_diode_multi_state.mt":
                    if (rawMaterial._device_diode_multi_state == null)
                        rawMaterial._device_diode_multi_state = new _device_diode_multi_state();
                    rawMaterial._device_diode_multi_state.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._device_diode_multi_state.ToString();
                    break;
                case "diode_pavements.mt":
                    if (rawMaterial._diode_pavements == null)
                        rawMaterial._diode_pavements = new _diode_pavements();
                    rawMaterial._diode_pavements.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._diode_pavements.ToString();
                    break;
                case "drugged_sobel.mt":
                    if (rawMaterial._drugged_sobel == null)
                        rawMaterial._drugged_sobel = new _drugged_sobel();
                    rawMaterial._drugged_sobel.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._drugged_sobel.ToString();
                    break;
                case "emissive_basic_transparent.mt":
                    if (rawMaterial._emissive_basic_transparent == null)
                        rawMaterial._emissive_basic_transparent = new _emissive_basic_transparent();
                    rawMaterial._emissive_basic_transparent.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._emissive_basic_transparent.ToString();
                    break;
                case "fog_laser.mt":
                    if (rawMaterial._fog_laser == null)
                        rawMaterial._fog_laser = new _fog_laser();
                    rawMaterial._fog_laser.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._fog_laser.ToString();
                    break;
                case "hologram.mt":
                    if (rawMaterial._hologram == null)
                        rawMaterial._hologram = new _hologram();
                    rawMaterial._hologram.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hologram.ToString();
                    break;
                case "hologram_two_sided.mt":
                    if (rawMaterial._hologram_two_sided == null)
                        rawMaterial._hologram_two_sided = new _hologram_two_sided();
                    rawMaterial._hologram_two_sided.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hologram_two_sided.ToString();
                    break;
                case "holo_projections.mt":
                    if (rawMaterial._holo_projections == null)
                        rawMaterial._holo_projections = new _holo_projections();
                    rawMaterial._holo_projections.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._holo_projections.ToString();
                    break;
                case "hud_focus_mode_scanline.mt":
                    if (rawMaterial._hud_focus_mode_scanline == null)
                        rawMaterial._hud_focus_mode_scanline = new _hud_focus_mode_scanline();
                    rawMaterial._hud_focus_mode_scanline.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hud_focus_mode_scanline.ToString();
                    break;
                case "hud_markers_notxaa.mt":
                    if (rawMaterial._hud_markers_notxaa == null)
                        rawMaterial._hud_markers_notxaa = new _hud_markers_notxaa();
                    rawMaterial._hud_markers_notxaa.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hud_markers_notxaa.ToString();
                    break;
                case "hud_markers_transparent.mt":
                    if (rawMaterial._hud_markers_transparent == null)
                        rawMaterial._hud_markers_transparent = new _hud_markers_transparent();
                    rawMaterial._hud_markers_transparent.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hud_markers_transparent.ToString();
                    break;
                case "hud_markers_vision.mt":
                    if (rawMaterial._hud_markers_vision == null)
                        rawMaterial._hud_markers_vision = new _hud_markers_vision();
                    rawMaterial._hud_markers_vision.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hud_markers_vision.ToString();
                    break;
                case "hud_ui_dot.mt":
                    if (rawMaterial._hud_ui_dot == null)
                        rawMaterial._hud_ui_dot = new _hud_ui_dot();
                    rawMaterial._hud_ui_dot.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hud_ui_dot.ToString();
                    break;
                case "hud_vision_pass.mt":
                    if (rawMaterial._hud_vision_pass == null)
                        rawMaterial._hud_vision_pass = new _hud_vision_pass();
                    rawMaterial._hud_vision_pass.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hud_vision_pass.ToString();
                    break;
                case "johnny_effect.mt":
                    if (rawMaterial._johnny_effect == null)
                        rawMaterial._johnny_effect = new _johnny_effect();
                    rawMaterial._johnny_effect.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._johnny_effect.ToString();
                    break;
                case "johnny_glitch.mt":
                    if (rawMaterial._johnny_glitch == null)
                        rawMaterial._johnny_glitch = new _johnny_glitch();
                    rawMaterial._johnny_glitch.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._johnny_glitch.ToString();
                    break;
                case "metal_base_atlas_animation.mt":
                    if (rawMaterial._metal_base_atlas_animation == null)
                        rawMaterial._metal_base_atlas_animation = new _metal_base_atlas_animation();
                    rawMaterial._metal_base_atlas_animation.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_atlas_animation.ToString();
                    break;
                case "metal_base_blackbody.mt":
                    if (rawMaterial._metal_base_blackbody == null)
                        rawMaterial._metal_base_blackbody = new _metal_base_blackbody();
                    rawMaterial._metal_base_blackbody.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_blackbody.ToString();
                    break;
                case "metal_base_glitter.mt":
                    if (rawMaterial._metal_base_glitter == null)
                        rawMaterial._metal_base_glitter = new _metal_base_glitter();
                    rawMaterial._metal_base_glitter.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_glitter.ToString();
                    break;
                case "neon_tubes.mt":
                    if (rawMaterial._neon_tubes == null)
                        rawMaterial._neon_tubes = new _neon_tubes();
                    rawMaterial._neon_tubes.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._neon_tubes.ToString();
                    break;
                case "noctovision_mode.mt":
                    if (rawMaterial._noctovision_mode == null)
                        rawMaterial._noctovision_mode = new _noctovision_mode();
                    rawMaterial._noctovision_mode.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._noctovision_mode.ToString();
                    break;
                case "parallaxscreen.mt":
                    if (rawMaterial._parallaxscreen == null)
                        rawMaterial._parallaxscreen = new _parallaxscreen();
                    rawMaterial._parallaxscreen.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._parallaxscreen.ToString();
                    break;
                case "parallaxscreen_transparent.mt":
                    if (rawMaterial._parallaxscreen_transparent == null)
                        rawMaterial._parallaxscreen_transparent = new _parallaxscreen_transparent();
                    rawMaterial._parallaxscreen_transparent.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._parallaxscreen_transparent.ToString();
                    break;
                case "parallaxscreen_transparent_ui.mt":
                    if (rawMaterial._parallaxscreen_transparent_ui == null)
                        rawMaterial._parallaxscreen_transparent_ui = new _parallaxscreen_transparent_ui();
                    rawMaterial._parallaxscreen_transparent_ui.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._parallaxscreen_transparent_ui.ToString();
                    break;
                case "parallax_bink.mt":
                    if (rawMaterial._parallax_bink == null)
                        rawMaterial._parallax_bink = new _parallax_bink();
                    rawMaterial._parallax_bink.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._parallax_bink.ToString();
                    break;
                case "particles_generic_expanded.mt":
                    if (rawMaterial._particles_generic_expanded == null)
                        rawMaterial._particles_generic_expanded = new _particles_generic_expanded();
                    rawMaterial._particles_generic_expanded.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._particles_generic_expanded.ToString();
                    break;
                case "particles_hologram.mt":
                    if (rawMaterial._particles_hologram == null)
                        rawMaterial._particles_hologram = new _particles_hologram();
                    rawMaterial._particles_hologram.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._particles_hologram.ToString();
                    break;
                case "pointcloud_source_mesh.mt":
                    if (rawMaterial._pointcloud_source_mesh == null)
                        rawMaterial._pointcloud_source_mesh = new _pointcloud_source_mesh();
                    rawMaterial._pointcloud_source_mesh.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._pointcloud_source_mesh.ToString();
                    break;
                case "postprocess.mt":
                    if (rawMaterial._postprocess == null)
                        rawMaterial._postprocess = new _postprocess();
                    rawMaterial._postprocess.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._postprocess.ToString();
                    break;
                case "postprocess_notxaa.mt":
                    if (rawMaterial._postprocess_notxaa == null)
                        rawMaterial._postprocess_notxaa = new _postprocess_notxaa();
                    rawMaterial._postprocess_notxaa.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._postprocess_notxaa.ToString();
                    break;
                case "radial_blur.mt":
                    if (rawMaterial._radial_blur == null)
                        rawMaterial._radial_blur = new _radial_blur();
                    rawMaterial._radial_blur.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._radial_blur.ToString();
                    break;
                case "reflex_buster.mt":
                    if (rawMaterial._reflex_buster == null)
                        rawMaterial._reflex_buster = new _reflex_buster();
                    rawMaterial._reflex_buster.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._reflex_buster.ToString();
                    break;
                case "refraction.mt":
                    if (rawMaterial._refraction == null)
                        rawMaterial._refraction = new _refraction();
                    rawMaterial._refraction.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._refraction.ToString();
                    break;
                case "sandevistan_trails.mt":
                    if (rawMaterial._sandevistan_trails == null)
                        rawMaterial._sandevistan_trails = new _sandevistan_trails();
                    rawMaterial._sandevistan_trails.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._sandevistan_trails.ToString();
                    break;
                case "screens.mt":
                    if (rawMaterial._screens == null)
                        rawMaterial._screens = new _screens();
                    rawMaterial._screens.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._screens.ToString();
                    break;
                case "screen_artifacts.mt":
                    if (rawMaterial._screen_artifacts == null)
                        rawMaterial._screen_artifacts = new _screen_artifacts();
                    rawMaterial._screen_artifacts.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._screen_artifacts.ToString();
                    break;
                case "screen_artifacts_vision.mt":
                    if (rawMaterial._screen_artifacts_vision == null)
                        rawMaterial._screen_artifacts_vision = new _screen_artifacts_vision();
                    rawMaterial._screen_artifacts_vision.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._screen_artifacts_vision.ToString();
                    break;
                case "screen_black.mt":
                    if (rawMaterial._screen_black == null)
                        rawMaterial._screen_black = new _screen_black();
                    rawMaterial._screen_black.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._screen_black.ToString();
                    break;
                case "screen_fast_travel_glitch.mt":
                    if (rawMaterial._screen_fast_travel_glitch == null)
                        rawMaterial._screen_fast_travel_glitch = new _screen_fast_travel_glitch();
                    rawMaterial._screen_fast_travel_glitch.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._screen_fast_travel_glitch.ToString();
                    break;
                case "screen_glitch.mt":
                    if (rawMaterial._screen_glitch == null)
                        rawMaterial._screen_glitch = new _screen_glitch();
                    rawMaterial._screen_glitch.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._screen_glitch.ToString();
                    break;
                case "screen_glitch_notxaa.mt":
                    if (rawMaterial._screen_glitch_notxaa == null)
                        rawMaterial._screen_glitch_notxaa = new _screen_glitch_notxaa();
                    rawMaterial._screen_glitch_notxaa.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._screen_glitch_notxaa.ToString();
                    break;
                case "screen_glitch_vision.mt":
                    if (rawMaterial._screen_glitch_vision == null)
                        rawMaterial._screen_glitch_vision = new _screen_glitch_vision();
                    rawMaterial._screen_glitch_vision.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._screen_glitch_vision.ToString();
                    break;
                case "signages.mt":
                    if (rawMaterial._signages == null)
                        rawMaterial._signages = new _signages();
                    rawMaterial._signages.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._signages.ToString();
                    break;
                case "signages_transparent_no_txaa.mt":
                    if (rawMaterial._signages_transparent_no_txaa == null)
                        rawMaterial._signages_transparent_no_txaa = new _signages_transparent_no_txaa();
                    rawMaterial._signages_transparent_no_txaa.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._signages_transparent_no_txaa.ToString();
                    break;
                case "silverhand_proxy.mt":
                    if (rawMaterial._silverhand_proxy == null)
                        rawMaterial._silverhand_proxy = new _silverhand_proxy();
                    rawMaterial._silverhand_proxy.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._silverhand_proxy.ToString();
                    break;
                case "simple_additive_ui.mt":
                    if (rawMaterial._simple_additive_ui == null)
                        rawMaterial._simple_additive_ui = new _simple_additive_ui();
                    rawMaterial._simple_additive_ui.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._simple_additive_ui.ToString();
                    break;
                case "simple_emissive_decals.mt":
                    if (rawMaterial._simple_emissive_decals == null)
                        rawMaterial._simple_emissive_decals = new _simple_emissive_decals();
                    rawMaterial._simple_emissive_decals.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._simple_emissive_decals.ToString();
                    break;
                case "simple_fresnel.mt":
                    if (rawMaterial._simple_fresnel == null)
                        rawMaterial._simple_fresnel = new _simple_fresnel();
                    rawMaterial._simple_fresnel.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._simple_fresnel.ToString();
                    break;
                case "simple_refraction.mt":
                    if (rawMaterial._simple_refraction == null)
                        rawMaterial._simple_refraction = new _simple_refraction();
                    rawMaterial._simple_refraction.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._simple_refraction.ToString();
                    break;
                case "sound_clue.mt":
                    if (rawMaterial._sound_clue == null)
                        rawMaterial._sound_clue = new _sound_clue();
                    rawMaterial._sound_clue.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._sound_clue.ToString();
                    break;
                case "television_ad.mt":
                    if (rawMaterial._television_ad == null)
                        rawMaterial._television_ad = new _television_ad();
                    rawMaterial._television_ad.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._television_ad.ToString();
                    break;
                case "triplanar_projection.mt":
                    if (rawMaterial._triplanar_projection == null)
                        rawMaterial._triplanar_projection = new _triplanar_projection();
                    rawMaterial._triplanar_projection.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._triplanar_projection.ToString();
                    break;
                case "water_plane.mt":
                    if (rawMaterial._water_plane == null)
                        rawMaterial._water_plane = new _water_plane();
                    rawMaterial._water_plane.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._water_plane.ToString();
                    break;
                case "zoom.mt":
                    if (rawMaterial._zoom == null)
                        rawMaterial._zoom = new _zoom();
                    rawMaterial._zoom.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._zoom.ToString();
                    break;
                case "alt_halo.mt":
                    if (rawMaterial._alt_halo == null)
                        rawMaterial._alt_halo = new _alt_halo();
                    rawMaterial._alt_halo.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._alt_halo.ToString();
                    break;
                case "blackbodyradiation_distant.mt":
                    if (rawMaterial._blackbodyradiation_distant == null)
                        rawMaterial._blackbodyradiation_distant = new _blackbodyradiation_distant();
                    rawMaterial._blackbodyradiation_distant.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._blackbodyradiation_distant.ToString();
                    break;
                case "blackbodyradiation_notxaa.mt":
                    if (rawMaterial._blackbodyradiation_notxaa == null)
                        rawMaterial._blackbodyradiation_notxaa = new _blackbodyradiation_notxaa();
                    rawMaterial._blackbodyradiation_notxaa.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._blackbodyradiation_notxaa.ToString();
                    break;
                case "blood_metal_base.mt":
                    if (rawMaterial._blood_metal_base == null)
                        rawMaterial._blood_metal_base = new _blood_metal_base();
                    rawMaterial._blood_metal_base.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._blood_metal_base.ToString();
                    break;
                case "caustics.mt":
                    if (rawMaterial._caustics == null)
                        rawMaterial._caustics = new _caustics();
                    rawMaterial._caustics.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._caustics.ToString();
                    break;
                case "character_kerenzikov.mt":
                    if (rawMaterial._character_kerenzikov == null)
                        rawMaterial._character_kerenzikov = new _character_kerenzikov();
                    rawMaterial._character_kerenzikov.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._character_kerenzikov.ToString();
                    break;
                case "character_sandevistan.mt":
                    if (rawMaterial._character_sandevistan == null)
                        rawMaterial._character_sandevistan = new _character_sandevistan();
                    rawMaterial._character_sandevistan.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._character_sandevistan.ToString();
                    break;
                case "crystal_dome.mt":
                    if (rawMaterial._crystal_dome == null)
                        rawMaterial._crystal_dome = new _crystal_dome();
                    rawMaterial._crystal_dome.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._crystal_dome.ToString();
                    break;
                case "crystal_dome_opaque.mt":
                    if (rawMaterial._crystal_dome_opaque == null)
                        rawMaterial._crystal_dome_opaque = new _crystal_dome_opaque();
                    rawMaterial._crystal_dome_opaque.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._crystal_dome_opaque.ToString();
                    break;
                case "cyberspace_gradient.mt":
                    if (rawMaterial._cyberspace_gradient == null)
                        rawMaterial._cyberspace_gradient = new _cyberspace_gradient();
                    rawMaterial._cyberspace_gradient.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberspace_gradient.ToString();
                    break;
                case "cyberspace_teleport_glitch.mt":
                    if (rawMaterial._cyberspace_teleport_glitch == null)
                        rawMaterial._cyberspace_teleport_glitch = new _cyberspace_teleport_glitch();
                    rawMaterial._cyberspace_teleport_glitch.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberspace_teleport_glitch.ToString();
                    break;
                case "decal_caustics.mt":
                    if (rawMaterial._decal_caustics == null)
                        rawMaterial._decal_caustics = new _decal_caustics();
                    rawMaterial._decal_caustics.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_caustics.ToString();
                    break;
                case "decal_glitch.mt":
                    if (rawMaterial._decal_glitch == null)
                        rawMaterial._decal_glitch = new _decal_glitch();
                    rawMaterial._decal_glitch.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_glitch.ToString();
                    break;
                case "decal_glitch_emissive.mt":
                    if (rawMaterial._decal_glitch_emissive == null)
                        rawMaterial._decal_glitch_emissive = new _decal_glitch_emissive();
                    rawMaterial._decal_glitch_emissive.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_glitch_emissive.ToString();
                    break;
                case "depth_based_sobel.mt":
                    if (rawMaterial._depth_based_sobel == null)
                        rawMaterial._depth_based_sobel = new _depth_based_sobel();
                    rawMaterial._depth_based_sobel.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._depth_based_sobel.ToString();
                    break;
                case "diode_pavements_ui.mt":
                    if (rawMaterial._diode_pavements_ui == null)
                        rawMaterial._diode_pavements_ui = new _diode_pavements_ui();
                    rawMaterial._diode_pavements_ui.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._diode_pavements_ui.ToString();
                    break;
                case "dirt_animated_masked.mt":
                    if (rawMaterial._dirt_animated_masked == null)
                        rawMaterial._dirt_animated_masked = new _dirt_animated_masked();
                    rawMaterial._dirt_animated_masked.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._dirt_animated_masked.ToString();
                    break;
                case "e3_prototype_mask.mt":
                    if (rawMaterial._e3_prototype_mask == null)
                        rawMaterial._e3_prototype_mask = new _e3_prototype_mask();
                    rawMaterial._e3_prototype_mask.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._e3_prototype_mask.ToString();
                    break;
                case "fake_flare.mt":
                    if (rawMaterial._fake_flare == null)
                        rawMaterial._fake_flare = new _fake_flare();
                    rawMaterial._fake_flare.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._fake_flare.ToString();
                    break;
                case "fake_flare_simple.mt":
                    if (rawMaterial._fake_flare_simple == null)
                        rawMaterial._fake_flare_simple = new _fake_flare_simple();
                    rawMaterial._fake_flare_simple.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._fake_flare_simple.ToString();
                    break;
                case "flat_fog_masked.mt":
                    if (rawMaterial._flat_fog_masked == null)
                        rawMaterial._flat_fog_masked = new _flat_fog_masked();
                    rawMaterial._flat_fog_masked.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._flat_fog_masked.ToString();
                    break;
                case "flat_fog_masked_notxaa.mt":
                    if (rawMaterial._flat_fog_masked_notxaa == null)
                        rawMaterial._flat_fog_masked_notxaa = new _flat_fog_masked_notxaa();
                    rawMaterial._flat_fog_masked_notxaa.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._flat_fog_masked_notxaa.ToString();
                    break;
                case "highlight_blocker.mt":
                    if (rawMaterial._highlight_blocker == null)
                        rawMaterial._highlight_blocker = new _highlight_blocker();
                    rawMaterial._highlight_blocker.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._highlight_blocker.ToString();
                    break;
                case "hologram_proxy.mt":
                    if (rawMaterial._hologram_proxy == null)
                        rawMaterial._hologram_proxy = new _hologram_proxy();
                    rawMaterial._hologram_proxy.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hologram_proxy.ToString();
                    break;
                case "holo_mask.mt":
                    if (rawMaterial._holo_mask == null)
                        rawMaterial._holo_mask = new _holo_mask();
                    rawMaterial._holo_mask.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._holo_mask.ToString();
                    break;
                case "invisible.mt":
                    if (rawMaterial._invisible == null)
                        rawMaterial._invisible = new _invisible();
                    rawMaterial._invisible.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._invisible.ToString();
                    break;
                case "lightning_plasma.mt":
                    if (rawMaterial._lightning_plasma == null)
                        rawMaterial._lightning_plasma = new _lightning_plasma();
                    rawMaterial._lightning_plasma.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._lightning_plasma.ToString();
                    break;
                case "light_gradients.mt":
                    if (rawMaterial._light_gradients == null)
                        rawMaterial._light_gradients = new _light_gradients();
                    rawMaterial._light_gradients.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._light_gradients.ToString();
                    break;
                case "low_health.mt":
                    if (rawMaterial._low_health == null)
                        rawMaterial._low_health = new _low_health();
                    rawMaterial._low_health.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._low_health.ToString();
                    break;
                case "mesh_decal__blackbody.mt":
                    if (rawMaterial._mesh_decal__blackbody == null)
                        rawMaterial._mesh_decal__blackbody = new _mesh_decal__blackbody();
                    rawMaterial._mesh_decal__blackbody.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal__blackbody.ToString();
                    break;
                case "metal_base_scrolling.mt":
                    if (rawMaterial._metal_base_scrolling == null)
                        rawMaterial._metal_base_scrolling = new _metal_base_scrolling();
                    rawMaterial._metal_base_scrolling.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_scrolling.ToString();
                    break;
                case "multilayer_blackbody_inject.mt":
                    if (rawMaterial._multilayer_blackbody_inject == null)
                        rawMaterial._multilayer_blackbody_inject = new _multilayer_blackbody_inject();
                    rawMaterial._multilayer_blackbody_inject.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._multilayer_blackbody_inject.ToString();
                    break;
                case "nanowire_string.mt":
                    if (rawMaterial._nanowire_string == null)
                        rawMaterial._nanowire_string = new _nanowire_string();
                    rawMaterial._nanowire_string.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._nanowire_string.ToString();
                    break;
                case "oda_helm.mt":
                    if (rawMaterial._oda_helm == null)
                        rawMaterial._oda_helm = new _oda_helm();
                    rawMaterial._oda_helm.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._oda_helm.ToString();
                    break;
                case "rift_noise.mt":
                    if (rawMaterial._rift_noise == null)
                        rawMaterial._rift_noise = new _rift_noise();
                    rawMaterial._rift_noise.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._rift_noise.ToString();
                    break;
                case "screen_wave.mt":
                    if (rawMaterial._screen_wave == null)
                        rawMaterial._screen_wave = new _screen_wave();
                    rawMaterial._screen_wave.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._screen_wave.ToString();
                    break;
                case "simple_fog.mt":
                    if (rawMaterial._simple_fog == null)
                        rawMaterial._simple_fog = new _simple_fog();
                    rawMaterial._simple_fog.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._simple_fog.ToString();
                    break;
                case "simple_refraction_mask.mt":
                    if (rawMaterial._simple_refraction_mask == null)
                        rawMaterial._simple_refraction_mask = new _simple_refraction_mask();
                    rawMaterial._simple_refraction_mask.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._simple_refraction_mask.ToString();
                    break;
                case "transparent_flowmap.mt":
                    if (rawMaterial._transparent_flowmap == null)
                        rawMaterial._transparent_flowmap = new _transparent_flowmap();
                    rawMaterial._transparent_flowmap.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._transparent_flowmap.ToString();
                    break;
                case "transparent_liquid_notxaa.mt":
                    if (rawMaterial._transparent_liquid_notxaa == null)
                        rawMaterial._transparent_liquid_notxaa = new _transparent_liquid_notxaa();
                    rawMaterial._transparent_liquid_notxaa.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._transparent_liquid_notxaa.ToString();
                    break;
                case "world_to_screen_glitch.mt":
                    if (rawMaterial._world_to_screen_glitch == null)
                        rawMaterial._world_to_screen_glitch = new _world_to_screen_glitch();
                    rawMaterial._world_to_screen_glitch.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._world_to_screen_glitch.ToString();
                    break;
                case "hit_proxy.mt":
                    if (rawMaterial._hit_proxy == null)
                        rawMaterial._hit_proxy = new _hit_proxy();
                    rawMaterial._hit_proxy.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hit_proxy.ToString();
                    break;
                case "lod_coloring.mt":
                    if (rawMaterial._lod_coloring == null)
                        rawMaterial._lod_coloring = new _lod_coloring();
                    rawMaterial._lod_coloring.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._lod_coloring.ToString();
                    break;
                case "overdraw.mt":
                    if (rawMaterial._overdraw == null)
                        rawMaterial._overdraw = new _overdraw();
                    rawMaterial._overdraw.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._overdraw.ToString();
                    break;
                case "overdraw_seethrough.mt":
                    if (rawMaterial._overdraw_seethrough == null)
                        rawMaterial._overdraw_seethrough = new _overdraw_seethrough();
                    rawMaterial._overdraw_seethrough.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._overdraw_seethrough.ToString();
                    break;
                case "selection.mt":
                    if (rawMaterial._selection == null)
                        rawMaterial._selection = new _selection();
                    rawMaterial._selection.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._selection.ToString();
                    break;
                case "uv_density.mt":
                    if (rawMaterial._uv_density == null)
                        rawMaterial._uv_density = new _uv_density();
                    rawMaterial._uv_density.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._uv_density.ToString();
                    break;
                case "wireframe.mt":
                    if (rawMaterial._wireframe == null)
                        rawMaterial._wireframe = new _wireframe();
                    rawMaterial._wireframe.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._wireframe.ToString();
                    break;
                case "editor_mlmask_preview.mt":
                    if (rawMaterial._editor_mlmask_preview == null)
                        rawMaterial._editor_mlmask_preview = new _editor_mlmask_preview();
                    rawMaterial._editor_mlmask_preview.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._editor_mlmask_preview.ToString();
                    break;
                case "editor_mltemplate_preview.mt":
                    if (rawMaterial._editor_mltemplate_preview == null)
                        rawMaterial._editor_mltemplate_preview = new _editor_mltemplate_preview();
                    rawMaterial._editor_mltemplate_preview.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._editor_mltemplate_preview.ToString();
                    break;
                case "gi_backface_debug.mt":
                    if (rawMaterial._gi_backface_debug == null)
                        rawMaterial._gi_backface_debug = new _gi_backface_debug();
                    rawMaterial._gi_backface_debug.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._gi_backface_debug.ToString();
                    break;
                case "multilayered_baked.mt":
                    if (rawMaterial._multilayered_baked == null)
                        rawMaterial._multilayered_baked = new _multilayered_baked();
                    rawMaterial._multilayered_baked.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._multilayered_baked.ToString();
                    break;
                case "silverhand_props_overlay.mt":
                    if (rawMaterial._silverhand_props_overlay == null)
                        rawMaterial._silverhand_props_overlay = new _silverhand_props_overlay();
                    rawMaterial._silverhand_props_overlay.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._silverhand_props_overlay.ToString();
                    break;
                case "mikoshi_fullscr_transition.mt":
                    if (rawMaterial._mikoshi_fullscr_transition == null)
                        rawMaterial._mikoshi_fullscr_transition = new _mikoshi_fullscr_transition();
                    rawMaterial._mikoshi_fullscr_transition.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mikoshi_fullscr_transition.ToString();
                    break;
                case "decal.remt":
                    if (rawMaterial._decal == null)
                        rawMaterial._decal = new _decal();
                    rawMaterial._decal.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal.ToString();
                    break;
                case "decal_normal.remt":
                    if (rawMaterial._decal_normal == null)
                        rawMaterial._decal_normal = new _decal_normal();
                    rawMaterial._decal_normal.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_normal.ToString();
                    break;
                case "pbr_layer.remt":
                    if (rawMaterial._pbr_layer == null)
                        rawMaterial._pbr_layer = new _pbr_layer();
                    rawMaterial._pbr_layer.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._pbr_layer.ToString();
                    break;
                case "debugdraw.remt":
                    if (rawMaterial._debugdraw == null)
                        rawMaterial._debugdraw = new _debugdraw();
                    rawMaterial._debugdraw.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._debugdraw.ToString();
                    break;
                case "fallback.remt":
                    if (rawMaterial._fallback == null)
                        rawMaterial._fallback = new _fallback();
                    rawMaterial._fallback.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._fallback.ToString();
                    break;
                case "metal_base.remt":
                    if (rawMaterial._metal_base == null)
                        rawMaterial._metal_base = new _metal_base();
                    rawMaterial._metal_base.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base.ToString();
                    break;
                case "mirror.remt":
                    if (rawMaterial._mirror == null)
                        rawMaterial._mirror = new _mirror();
                    rawMaterial._mirror.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mirror.ToString();
                    break;
                case "particles_generic.remt":
                    if (rawMaterial._particles_generic == null)
                        rawMaterial._particles_generic = new _particles_generic();
                    rawMaterial._particles_generic.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._particles_generic.ToString();
                    break;
                case "particles_liquid.remt":
                    if (rawMaterial._particles_liquid == null)
                        rawMaterial._particles_liquid = new _particles_liquid();
                    rawMaterial._particles_liquid.Read(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._particles_liquid.ToString();
                    break;
            }
        }
    }
    public class RawMaterial
    {
        public string Name { get; set; }
        public string BaseMaterial { get; set; }
        public string MaterialType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _3d_map _3d_map { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _3d_map_cubes _3d_map_cubes { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _3d_map_solid _3d_map_solid { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _beyondblackwall _beyondblackwall { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _beyondblackwall_chars _beyondblackwall_chars { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _beyondblackwall_sky _beyondblackwall_sky { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _beyondblackwall_sky_raymarch _beyondblackwall_sky_raymarch { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _blood_puddle_decal _blood_puddle_decal { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _cable _cable { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _circuit_wires _circuit_wires { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _cloth_mov _cloth_mov { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _cloth_mov_multilayered _cloth_mov_multilayered { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _cyberparticles_base _cyberparticles_base { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _cyberparticles_blackwall _cyberparticles_blackwall { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _cyberparticles_blackwall_touch _cyberparticles_blackwall_touch { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _cyberparticles_braindance _cyberparticles_braindance { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _cyberparticles_dynamic _cyberparticles_dynamic { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _cyberparticles_platform _cyberparticles_platform { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _decal_emissive_color _decal_emissive_color { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _decal_emissive_only _decal_emissive_only { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _decal_forward _decal_forward { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _decal_gradientmap_recolor _decal_gradientmap_recolor { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _decal_gradientmap_recolor_emissive _decal_gradientmap_recolor_emissive { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _decal_normal_roughness _decal_normal_roughness { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _decal_normal_roughness_metalness _decal_normal_roughness_metalness { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _decal_normal_roughness_metalness_2 _decal_normal_roughness_metalness_2 { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _decal_parallax _decal_parallax { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _decal_puddle _decal_puddle { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _decal_roughness _decal_roughness { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _decal_roughness_only _decal_roughness_only { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _decal_terrain_projected _decal_terrain_projected { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _decal_tintable _decal_tintable { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _diode_sign _diode_sign { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _earth_globe _earth_globe { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _earth_globe_atmosphere _earth_globe_atmosphere { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _earth_globe_lights _earth_globe_lights { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _emissive_control _emissive_control { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _eye _eye { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _eye_blendable _eye_blendable { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _eye_gradient _eye_gradient { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _eye_shadow _eye_shadow { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _eye_shadow_blendable _eye_shadow_blendable { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _fake_occluder _fake_occluder { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _fillable_fluid _fillable_fluid { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _fillable_fluid_vertex _fillable_fluid_vertex { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _fluid_mov _fluid_mov { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _frosted_glass _frosted_glass { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _frosted_glass_curtain _frosted_glass_curtain { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _glass _glass { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _glass_blendable _glass_blendable { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _glass_cracked_edge _glass_cracked_edge { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _glass_deferred _glass_deferred { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _glass_scope _glass_scope { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _glass_window_rain _glass_window_rain { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _hair _hair { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _hair_blendable _hair_blendable { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _hair_proxy _hair_proxy { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ice_fluid_mov _ice_fluid_mov { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ice_ver_mov_translucent _ice_ver_mov_translucent { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _lights_interactive _lights_interactive { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _loot_drop_highlight _loot_drop_highlight { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mesh_decal _mesh_decal { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mesh_decal_blendable _mesh_decal_blendable { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mesh_decal_double_diffuse _mesh_decal_double_diffuse { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mesh_decal_emissive _mesh_decal_emissive { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mesh_decal_emissive_subsurface _mesh_decal_emissive_subsurface { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mesh_decal_gradientmap_recolor _mesh_decal_gradientmap_recolor { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mesh_decal_gradientmap_recolor_2 _mesh_decal_gradientmap_recolor_2 { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mesh_decal_gradientmap_recolor_emissive _mesh_decal_gradientmap_recolor_emissive { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mesh_decal_multitinted _mesh_decal_multitinted { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mesh_decal_parallax _mesh_decal_parallax { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mesh_decal_revealed _mesh_decal_revealed { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mesh_decal_wet_character _mesh_decal_wet_character { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base_bink _metal_base_bink { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base_det _metal_base_det { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base_det_dithered _metal_base_det_dithered { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base_dithered _metal_base_dithered { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base_gradientmap_recolor _metal_base_gradientmap_recolor { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base_parallax _metal_base_parallax { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base_trafficlight_proxy _metal_base_trafficlight_proxy { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base_ui _metal_base_ui { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base_vertexcolored _metal_base_vertexcolored { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mikoshi_blocks_big _mikoshi_blocks_big { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mikoshi_blocks_medium _mikoshi_blocks_medium { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mikoshi_blocks_small _mikoshi_blocks_small { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mikoshi_parallax _mikoshi_parallax { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mikoshi_prison_cell _mikoshi_prison_cell { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _multilayered_clear_coat _multilayered_clear_coat { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _multilayered_terrain _multilayered_terrain { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _neon_parallax _neon_parallax { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _presimulated_particles _presimulated_particles { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _proxy_ad _proxy_ad { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _proxy_crowd _proxy_crowd { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _q116_mikoshi_cubes _q116_mikoshi_cubes { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _q116_mikoshi_floor _q116_mikoshi_floor { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _q202_lake_surface _q202_lake_surface { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _rain _rain { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _road_debug_grid _road_debug_grid { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _set_stencil_3 _set_stencil_3 { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _silverhand_overlay _silverhand_overlay { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _silverhand_overlay_blendable _silverhand_overlay_blendable { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _skin _skin { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _skin_blendable _skin_blendable { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _skybox _skybox { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _speedtree_3d_v8_billboard _speedtree_3d_v8_billboard { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _speedtree_3d_v8_onesided _speedtree_3d_v8_onesided { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _speedtree_3d_v8_onesided_gradient_recolor _speedtree_3d_v8_onesided_gradient_recolor { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _speedtree_3d_v8_seams _speedtree_3d_v8_seams { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _speedtree_3d_v8_twosided _speedtree_3d_v8_twosided { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _spline_deformed_metal_base _spline_deformed_metal_base { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _terrain_simple _terrain_simple { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _top_down_car_proxy_depth _top_down_car_proxy_depth { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _trail_decal _trail_decal { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _trail_decal_normal _trail_decal_normal { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _trail_decal_normal_color _trail_decal_normal_color { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _transparent_liquid _transparent_liquid { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _underwater_blood _underwater_blood { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _vehicle_destr_blendshape _vehicle_destr_blendshape { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _vehicle_glass _vehicle_glass { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _vehicle_glass_proxy _vehicle_glass_proxy { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _vehicle_lights _vehicle_lights { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _vehicle_mesh_decal _vehicle_mesh_decal { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ver_mov _ver_mov { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ver_mov_glass _ver_mov_glass { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ver_mov_multilayered _ver_mov_multilayered { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ver_skinned_mov _ver_skinned_mov { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ver_skinned_mov_parade _ver_skinned_mov_parade { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _window_interior_uv _window_interior_uv { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _window_parallax_interior _window_parallax_interior { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _window_parallax_interior_proxy _window_parallax_interior_proxy { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _window_parallax_interior_proxy_buffer _window_parallax_interior_proxy_buffer { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _window_very_long_distance _window_very_long_distance { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _worldspace_grid _worldspace_grid { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _bink_simple _bink_simple { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _cable_strip _cable_strip { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _debugdraw_bias _debugdraw_bias { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _debugdraw_wireframe _debugdraw_wireframe { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _debugdraw_wireframe_bias _debugdraw_wireframe_bias { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _debug_coloring _debug_coloring { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _font _font { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _global_water_patch _global_water_patch { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base_animated_uv _metal_base_animated_uv { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base_blendable _metal_base_blendable { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base_fence _metal_base_fence { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base_garment _metal_base_garment { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base_packed _metal_base_packed { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base_proxy _metal_base_proxy { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _multilayered _multilayered { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _multilayered_debug _multilayered_debug { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _pbr_simple _pbr_simple { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _shadows_debug _shadows_debug { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _transparent_notxaa_2 _transparent_notxaa_2 { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ui_default_element _ui_default_element { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ui_default_nine_slice_element _ui_default_nine_slice_element { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ui_default_tile_element _ui_default_tile_element { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ui_effect_box_blur _ui_effect_box_blur { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ui_effect_color_correction _ui_effect_color_correction { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ui_effect_color_fill _ui_effect_color_fill { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ui_effect_glitch _ui_effect_glitch { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ui_effect_inner_glow _ui_effect_inner_glow { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ui_effect_light_sweep _ui_effect_light_sweep { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ui_effect_linear_wipe _ui_effect_linear_wipe { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ui_effect_mask _ui_effect_mask { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ui_effect_point_cloud _ui_effect_point_cloud { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ui_effect_radial_wipe _ui_effect_radial_wipe { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ui_effect_swipe _ui_effect_swipe { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ui_element_depth_texture _ui_element_depth_texture { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ui_panel _ui_panel { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _ui_text_element _ui_text_element { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _alphablend_glass _alphablend_glass { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _alpha_control_refraction _alpha_control_refraction { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _animated_decal _animated_decal { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _beam_particles _beam_particles { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _blackbodyradiation _blackbodyradiation { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _blackbody_simple _blackbody_simple { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _blood_transparent _blood_transparent { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _braindance_fog _braindance_fog { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _braindance_particle_thermal _braindance_particle_thermal { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _cloak _cloak { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _cyberspace_pixelsort_stencil _cyberspace_pixelsort_stencil { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _cyberspace_pixelsort_stencil_0 _cyberspace_pixelsort_stencil_0 { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _cyberware_animation _cyberware_animation { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _damage_indicator _damage_indicator { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _device_diode _device_diode { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _device_diode_multi_state _device_diode_multi_state { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _diode_pavements _diode_pavements { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _drugged_sobel _drugged_sobel { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _emissive_basic_transparent _emissive_basic_transparent { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _fog_laser _fog_laser { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _hologram _hologram { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _hologram_two_sided _hologram_two_sided { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _holo_projections _holo_projections { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _hud_focus_mode_scanline _hud_focus_mode_scanline { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _hud_markers_notxaa _hud_markers_notxaa { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _hud_markers_transparent _hud_markers_transparent { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _hud_markers_vision _hud_markers_vision { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _hud_ui_dot _hud_ui_dot { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _hud_vision_pass _hud_vision_pass { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _johnny_effect _johnny_effect { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _johnny_glitch _johnny_glitch { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base_atlas_animation _metal_base_atlas_animation { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base_blackbody _metal_base_blackbody { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base_glitter _metal_base_glitter { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _neon_tubes _neon_tubes { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _noctovision_mode _noctovision_mode { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _parallaxscreen _parallaxscreen { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _parallaxscreen_transparent _parallaxscreen_transparent { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _parallaxscreen_transparent_ui _parallaxscreen_transparent_ui { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _parallax_bink _parallax_bink { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _particles_generic_expanded _particles_generic_expanded { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _particles_hologram _particles_hologram { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _pointcloud_source_mesh _pointcloud_source_mesh { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _postprocess _postprocess { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _postprocess_notxaa _postprocess_notxaa { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _radial_blur _radial_blur { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _reflex_buster _reflex_buster { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _refraction _refraction { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _sandevistan_trails _sandevistan_trails { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _screens _screens { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _screen_artifacts _screen_artifacts { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _screen_artifacts_vision _screen_artifacts_vision { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _screen_black _screen_black { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _screen_fast_travel_glitch _screen_fast_travel_glitch { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _screen_glitch _screen_glitch { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _screen_glitch_notxaa _screen_glitch_notxaa { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _screen_glitch_vision _screen_glitch_vision { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _signages _signages { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _signages_transparent_no_txaa _signages_transparent_no_txaa { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _silverhand_proxy _silverhand_proxy { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _simple_additive_ui _simple_additive_ui { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _simple_emissive_decals _simple_emissive_decals { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _simple_fresnel _simple_fresnel { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _simple_refraction _simple_refraction { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _sound_clue _sound_clue { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _television_ad _television_ad { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _triplanar_projection _triplanar_projection { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _water_plane _water_plane { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _zoom _zoom { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _alt_halo _alt_halo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _blackbodyradiation_distant _blackbodyradiation_distant { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _blackbodyradiation_notxaa _blackbodyradiation_notxaa { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _blood_metal_base _blood_metal_base { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _caustics _caustics { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _character_kerenzikov _character_kerenzikov { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _character_sandevistan _character_sandevistan { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _crystal_dome _crystal_dome { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _crystal_dome_opaque _crystal_dome_opaque { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _cyberspace_gradient _cyberspace_gradient { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _cyberspace_teleport_glitch _cyberspace_teleport_glitch { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _decal_caustics _decal_caustics { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _decal_glitch _decal_glitch { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _decal_glitch_emissive _decal_glitch_emissive { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _depth_based_sobel _depth_based_sobel { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _diode_pavements_ui _diode_pavements_ui { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _dirt_animated_masked _dirt_animated_masked { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _e3_prototype_mask _e3_prototype_mask { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _fake_flare _fake_flare { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _fake_flare_simple _fake_flare_simple { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _flat_fog_masked _flat_fog_masked { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _flat_fog_masked_notxaa _flat_fog_masked_notxaa { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _highlight_blocker _highlight_blocker { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _hologram_proxy _hologram_proxy { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _holo_mask _holo_mask { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _invisible _invisible { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _lightning_plasma _lightning_plasma { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _light_gradients _light_gradients { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _low_health _low_health { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mesh_decal__blackbody _mesh_decal__blackbody { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base_scrolling _metal_base_scrolling { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _multilayer_blackbody_inject _multilayer_blackbody_inject { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _nanowire_string _nanowire_string { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _oda_helm _oda_helm { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _rift_noise _rift_noise { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _screen_wave _screen_wave { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _simple_fog _simple_fog { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _simple_refraction_mask _simple_refraction_mask { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _transparent_flowmap _transparent_flowmap { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _transparent_liquid_notxaa _transparent_liquid_notxaa { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _world_to_screen_glitch _world_to_screen_glitch { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _hit_proxy _hit_proxy { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _lod_coloring _lod_coloring { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _overdraw _overdraw { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _overdraw_seethrough _overdraw_seethrough { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _selection _selection { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _uv_density _uv_density { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _wireframe _wireframe { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _editor_mlmask_preview _editor_mlmask_preview { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _editor_mltemplate_preview _editor_mltemplate_preview { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _gi_backface_debug _gi_backface_debug { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _multilayered_baked _multilayered_baked { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _silverhand_props_overlay _silverhand_props_overlay { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mikoshi_fullscr_transition _mikoshi_fullscr_transition { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _decal _decal { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _decal_normal _decal_normal { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _pbr_layer _pbr_layer { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _debugdraw _debugdraw { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _fallback _fallback { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _metal_base _metal_base { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _mirror _mirror { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _particles_generic _particles_generic { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _particles_liquid _particles_liquid { get; set; }
    }
    public enum MaterialTypes
    {
        _3d_map,
        _3d_map_cubes,
        _3d_map_solid,
        _beyondblackwall,
        _beyondblackwall_chars,
        _beyondblackwall_sky,
        _beyondblackwall_sky_raymarch,
        _blood_puddle_decal,
        _cable,
        _circuit_wires,
        _cloth_mov,
        _cloth_mov_multilayered,
        _cyberparticles_base,
        _cyberparticles_blackwall,
        _cyberparticles_blackwall_touch,
        _cyberparticles_braindance,
        _cyberparticles_dynamic,
        _cyberparticles_platform,
        _decal_emissive_color,
        _decal_emissive_only,
        _decal_forward,
        _decal_gradientmap_recolor,
        _decal_gradientmap_recolor_emissive,
        _decal_normal_roughness,
        _decal_normal_roughness_metalness,
        _decal_normal_roughness_metalness_2,
        _decal_parallax,
        _decal_puddle,
        _decal_roughness,
        _decal_roughness_only,
        _decal_terrain_projected,
        _decal_tintable,
        _diode_sign,
        _earth_globe,
        _earth_globe_atmosphere,
        _earth_globe_lights,
        _emissive_control,
        _eye,
        _eye_blendable,
        _eye_gradient,
        _eye_shadow,
        _eye_shadow_blendable,
        _fake_occluder,
        _fillable_fluid,
        _fillable_fluid_vertex,
        _fluid_mov,
        _frosted_glass,
        _frosted_glass_curtain,
        _glass,
        _glass_blendable,
        _glass_cracked_edge,
        _glass_deferred,
        _glass_scope,
        _glass_window_rain,
        _hair,
        _hair_blendable,
        _hair_proxy,
        _ice_fluid_mov,
        _ice_ver_mov_translucent,
        _lights_interactive,
        _loot_drop_highlight,
        _mesh_decal,
        _mesh_decal_blendable,
        _mesh_decal_double_diffuse,
        _mesh_decal_emissive,
        _mesh_decal_emissive_subsurface,
        _mesh_decal_gradientmap_recolor,
        _mesh_decal_gradientmap_recolor_2,
        _mesh_decal_gradientmap_recolor_emissive,
        _mesh_decal_multitinted,
        _mesh_decal_parallax,
        _mesh_decal_revealed,
        _mesh_decal_wet_character,
        _metal_base_bink,
        _metal_base_det,
        _metal_base_det_dithered,
        _metal_base_dithered,
        _metal_base_gradientmap_recolor,
        _metal_base_parallax,
        _metal_base_trafficlight_proxy,
        _metal_base_ui,
        _metal_base_vertexcolored,
        _mikoshi_blocks_big,
        _mikoshi_blocks_medium,
        _mikoshi_blocks_small,
        _mikoshi_parallax,
        _mikoshi_prison_cell,
        _multilayered_clear_coat,
        _multilayered_terrain,
        _neon_parallax,
        _presimulated_particles,
        _proxy_ad,
        _proxy_crowd,
        _q116_mikoshi_cubes,
        _q116_mikoshi_floor,
        _q202_lake_surface,
        _rain,
        _road_debug_grid,
        _set_stencil_3,
        _silverhand_overlay,
        _silverhand_overlay_blendable,
        _skin,
        _skin_blendable,
        _skybox,
        _speedtree_3d_v8_billboard,
        _speedtree_3d_v8_onesided,
        _speedtree_3d_v8_onesided_gradient_recolor,
        _speedtree_3d_v8_seams,
        _speedtree_3d_v8_twosided,
        _spline_deformed_metal_base,
        _terrain_simple,
        _top_down_car_proxy_depth,
        _trail_decal,
        _trail_decal_normal,
        _trail_decal_normal_color,
        _transparent_liquid,
        _underwater_blood,
        _vehicle_destr_blendshape,
        _vehicle_glass,
        _vehicle_glass_proxy,
        _vehicle_lights,
        _vehicle_mesh_decal,
        _ver_mov,
        _ver_mov_glass,
        _ver_mov_multilayered,
        _ver_skinned_mov,
        _ver_skinned_mov_parade,
        _window_interior_uv,
        _window_parallax_interior,
        _window_parallax_interior_proxy,
        _window_parallax_interior_proxy_buffer,
        _window_very_long_distance,
        _worldspace_grid,
        _bink_simple,
        _cable_strip,
        _debugdraw_bias,
        _debugdraw_wireframe,
        _debugdraw_wireframe_bias,
        _debug_coloring,
        _font,
        _global_water_patch,
        _metal_base_animated_uv,
        _metal_base_blendable,
        _metal_base_fence,
        _metal_base_garment,
        _metal_base_packed,
        _metal_base_proxy,
        _multilayered,
        _multilayered_debug,
        _pbr_simple,
        _shadows_debug,
        _transparent_notxaa_2,
        _ui_default_element,
        _ui_default_nine_slice_element,
        _ui_default_tile_element,
        _ui_effect_box_blur,
        _ui_effect_color_correction,
        _ui_effect_color_fill,
        _ui_effect_glitch,
        _ui_effect_inner_glow,
        _ui_effect_light_sweep,
        _ui_effect_linear_wipe,
        _ui_effect_mask,
        _ui_effect_point_cloud,
        _ui_effect_radial_wipe,
        _ui_effect_swipe,
        _ui_element_depth_texture,
        _ui_panel,
        _ui_text_element,
        _alphablend_glass,
        _alpha_control_refraction,
        _animated_decal,
        _beam_particles,
        _blackbodyradiation,
        _blackbody_simple,
        _blood_transparent,
        _braindance_fog,
        _braindance_particle_thermal,
        _cloak,
        _cyberspace_pixelsort_stencil,
        _cyberspace_pixelsort_stencil_0,
        _cyberware_animation,
        _damage_indicator,
        _device_diode,
        _device_diode_multi_state,
        _diode_pavements,
        _drugged_sobel,
        _emissive_basic_transparent,
        _fog_laser,
        _hologram,
        _hologram_two_sided,
        _holo_projections,
        _hud_focus_mode_scanline,
        _hud_markers_notxaa,
        _hud_markers_transparent,
        _hud_markers_vision,
        _hud_ui_dot,
        _hud_vision_pass,
        _johnny_effect,
        _johnny_glitch,
        _metal_base_atlas_animation,
        _metal_base_blackbody,
        _metal_base_glitter,
        _neon_tubes,
        _noctovision_mode,
        _parallaxscreen,
        _parallaxscreen_transparent,
        _parallaxscreen_transparent_ui,
        _parallax_bink,
        _particles_generic_expanded,
        _particles_hologram,
        _pointcloud_source_mesh,
        _postprocess,
        _postprocess_notxaa,
        _radial_blur,
        _reflex_buster,
        _refraction,
        _sandevistan_trails,
        _screens,
        _screen_artifacts,
        _screen_artifacts_vision,
        _screen_black,
        _screen_fast_travel_glitch,
        _screen_glitch,
        _screen_glitch_notxaa,
        _screen_glitch_vision,
        _signages,
        _signages_transparent_no_txaa,
        _silverhand_proxy,
        _simple_additive_ui,
        _simple_emissive_decals,
        _simple_fresnel,
        _simple_refraction,
        _sound_clue,
        _television_ad,
        _triplanar_projection,
        _water_plane,
        _zoom,
        _alt_halo,
        _blackbodyradiation_distant,
        _blackbodyradiation_notxaa,
        _blood_metal_base,
        _caustics,
        _character_kerenzikov,
        _character_sandevistan,
        _crystal_dome,
        _crystal_dome_opaque,
        _cyberspace_gradient,
        _cyberspace_teleport_glitch,
        _decal_caustics,
        _decal_glitch,
        _decal_glitch_emissive,
        _depth_based_sobel,
        _diode_pavements_ui,
        _dirt_animated_masked,
        _e3_prototype_mask,
        _fake_flare,
        _fake_flare_simple,
        _flat_fog_masked,
        _flat_fog_masked_notxaa,
        _highlight_blocker,
        _hologram_proxy,
        _holo_mask,
        _invisible,
        _lightning_plasma,
        _light_gradients,
        _low_health,
        _mesh_decal__blackbody,
        _metal_base_scrolling,
        _multilayer_blackbody_inject,
        _nanowire_string,
        _oda_helm,
        _rift_noise,
        _screen_wave,
        _simple_fog,
        _simple_refraction_mask,
        _transparent_flowmap,
        _transparent_liquid_notxaa,
        _world_to_screen_glitch,
        _hit_proxy,
        _lod_coloring,
        _overdraw,
        _overdraw_seethrough,
        _selection,
        _uv_density,
        _wireframe,
        _editor_mlmask_preview,
        _editor_mltemplate_preview,
        _gi_backface_debug,
        _multilayered_baked,
        _silverhand_props_overlay,
        _mikoshi_fullscr_transition,
        _decal,
        _decal_normal,
        _pbr_layer,
        _debugdraw,
        _fallback,
        _metal_base,
        _mirror,
        _particles_generic,
        _particles_liquid,
    }
}
