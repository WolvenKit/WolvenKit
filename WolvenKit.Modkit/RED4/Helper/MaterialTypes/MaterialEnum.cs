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
                case MaterialTypes._skin:
                    mat._skin.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = "base\\materials\\skin.mt";
                    break;
                case MaterialTypes._multilayered:
                    mat._multilayered.write(ref mi);
                    if (mat.BaseMaterial == null)
                        mat.BaseMaterial = "engine\\materials\\multilayered.mt";
                    break;
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
                default:
                    break;
            }
        }
        public static void ContainRawMaterialEnum(ref RawMaterial rawMaterial, CMaterialInstance cMaterialInstance, string path)
        {
            switch (Path.GetFileName(path))
            {
                case "skin.mt":
                    rawMaterial._skin = new _skin(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._skin.ToString();
                    break;
                case "multilayered.mt":
                    rawMaterial._multilayered = new _multilayered(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._multilayered.ToString();
                    break;
                case "3d_map.mt":
                    rawMaterial._3d_map = new _3d_map(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._3d_map.ToString();
                    break;
                case "3d_map_cubes.mt":
                    rawMaterial._3d_map_cubes = new _3d_map_cubes(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._3d_map_cubes.ToString();
                    break;
                case "3d_map_solid.mt":
                    rawMaterial._3d_map_solid = new _3d_map_solid(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._3d_map_solid.ToString();
                    break;
                case "beyondblackwall.mt":
                    rawMaterial._beyondblackwall = new _beyondblackwall(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._beyondblackwall.ToString();
                    break;
                case "beyondblackwall_chars.mt":
                    rawMaterial._beyondblackwall_chars = new _beyondblackwall_chars(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._beyondblackwall_chars.ToString();
                    break;
                case "beyondblackwall_sky.mt":
                    rawMaterial._beyondblackwall_sky = new _beyondblackwall_sky(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._beyondblackwall_sky.ToString();
                    break;
                case "beyondblackwall_sky_raymarch.mt":
                    rawMaterial._beyondblackwall_sky_raymarch = new _beyondblackwall_sky_raymarch(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._beyondblackwall_sky_raymarch.ToString();
                    break;
                case "blood_puddle_decal.mt":
                    rawMaterial._blood_puddle_decal = new _blood_puddle_decal(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._blood_puddle_decal.ToString();
                    break;
                case "cable.mt":
                    rawMaterial._cable = new _cable(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cable.ToString();
                    break;
                case "circuit_wires.mt":
                    rawMaterial._circuit_wires = new _circuit_wires(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._circuit_wires.ToString();
                    break;
                case "cloth_mov.mt":
                    rawMaterial._cloth_mov = new _cloth_mov(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cloth_mov.ToString();
                    break;
                case "cloth_mov_multilayered.mt":
                    rawMaterial._cloth_mov_multilayered = new _cloth_mov_multilayered(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cloth_mov_multilayered.ToString();
                    break;
                case "cyberparticles_base.mt":
                    rawMaterial._cyberparticles_base = new _cyberparticles_base(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberparticles_base.ToString();
                    break;
                case "cyberparticles_blackwall.mt":
                    rawMaterial._cyberparticles_blackwall = new _cyberparticles_blackwall(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberparticles_blackwall.ToString();
                    break;
                case "cyberparticles_blackwall_touch.mt":
                    rawMaterial._cyberparticles_blackwall_touch = new _cyberparticles_blackwall_touch(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberparticles_blackwall_touch.ToString();
                    break;
                case "cyberparticles_braindance.mt":
                    rawMaterial._cyberparticles_braindance = new _cyberparticles_braindance(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberparticles_braindance.ToString();
                    break;
                case "cyberparticles_dynamic.mt":
                    rawMaterial._cyberparticles_dynamic = new _cyberparticles_dynamic(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberparticles_dynamic.ToString();
                    break;
                case "cyberparticles_platform.mt":
                    rawMaterial._cyberparticles_platform = new _cyberparticles_platform(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberparticles_platform.ToString();
                    break;
                case "decal_emissive_color.mt":
                    rawMaterial._decal_emissive_color = new _decal_emissive_color(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_emissive_color.ToString();
                    break;
                case "decal_emissive_only.mt":
                    rawMaterial._decal_emissive_only = new _decal_emissive_only(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_emissive_only.ToString();
                    break;
                case "decal_forward.mt":
                    rawMaterial._decal_forward = new _decal_forward(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_forward.ToString();
                    break;
                case "decal_gradientmap_recolor.mt":
                    rawMaterial._decal_gradientmap_recolor = new _decal_gradientmap_recolor(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_gradientmap_recolor.ToString();
                    break;
                case "decal_gradientmap_recolor_emissive.mt":
                    rawMaterial._decal_gradientmap_recolor_emissive = new _decal_gradientmap_recolor_emissive(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_gradientmap_recolor_emissive.ToString();
                    break;
                case "decal_normal_roughness.mt":
                    rawMaterial._decal_normal_roughness = new _decal_normal_roughness(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_normal_roughness.ToString();
                    break;
                case "decal_normal_roughness_metalness.mt":
                    rawMaterial._decal_normal_roughness_metalness = new _decal_normal_roughness_metalness(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_normal_roughness_metalness.ToString();
                    break;
                case "decal_normal_roughness_metalness_2.mt":
                    rawMaterial._decal_normal_roughness_metalness_2 = new _decal_normal_roughness_metalness_2(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_normal_roughness_metalness_2.ToString();
                    break;
                case "decal_parallax.mt":
                    rawMaterial._decal_parallax = new _decal_parallax(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_parallax.ToString();
                    break;
                case "decal_puddle.mt":
                    rawMaterial._decal_puddle = new _decal_puddle(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_puddle.ToString();
                    break;
                case "decal_roughness.mt":
                    rawMaterial._decal_roughness = new _decal_roughness(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_roughness.ToString();
                    break;
                case "decal_roughness_only.mt":
                    rawMaterial._decal_roughness_only = new _decal_roughness_only(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_roughness_only.ToString();
                    break;
                case "decal_terrain_projected.mt":
                    rawMaterial._decal_terrain_projected = new _decal_terrain_projected(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_terrain_projected.ToString();
                    break;
                case "decal_tintable.mt":
                    rawMaterial._decal_tintable = new _decal_tintable(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_tintable.ToString();
                    break;
                case "diode_sign.mt":
                    rawMaterial._diode_sign = new _diode_sign(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._diode_sign.ToString();
                    break;
                case "earth_globe.mt":
                    rawMaterial._earth_globe = new _earth_globe(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._earth_globe.ToString();
                    break;
                case "earth_globe_atmosphere.mt":
                    rawMaterial._earth_globe_atmosphere = new _earth_globe_atmosphere(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._earth_globe_atmosphere.ToString();
                    break;
                case "earth_globe_lights.mt":
                    rawMaterial._earth_globe_lights = new _earth_globe_lights(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._earth_globe_lights.ToString();
                    break;
                case "emissive_control.mt":
                    rawMaterial._emissive_control = new _emissive_control(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._emissive_control.ToString();
                    break;
                case "eye.mt":
                    rawMaterial._eye = new _eye(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._eye.ToString();
                    break;
                case "eye_blendable.mt":
                    rawMaterial._eye_blendable = new _eye_blendable(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._eye_blendable.ToString();
                    break;
                case "eye_gradient.mt":
                    rawMaterial._eye_gradient = new _eye_gradient(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._eye_gradient.ToString();
                    break;
                case "eye_shadow.mt":
                    rawMaterial._eye_shadow = new _eye_shadow(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._eye_shadow.ToString();
                    break;
                case "eye_shadow_blendable.mt":
                    rawMaterial._eye_shadow_blendable = new _eye_shadow_blendable(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._eye_shadow_blendable.ToString();
                    break;
                case "fake_occluder.mt":
                    rawMaterial._fake_occluder = new _fake_occluder(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._fake_occluder.ToString();
                    break;
                case "fillable_fluid.mt":
                    rawMaterial._fillable_fluid = new _fillable_fluid(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._fillable_fluid.ToString();
                    break;
                case "fillable_fluid_vertex.mt":
                    rawMaterial._fillable_fluid_vertex = new _fillable_fluid_vertex(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._fillable_fluid_vertex.ToString();
                    break;
                case "fluid_mov.mt":
                    rawMaterial._fluid_mov = new _fluid_mov(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._fluid_mov.ToString();
                    break;
                case "frosted_glass.mt":
                    rawMaterial._frosted_glass = new _frosted_glass(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._frosted_glass.ToString();
                    break;
                case "frosted_glass_curtain.mt":
                    rawMaterial._frosted_glass_curtain = new _frosted_glass_curtain(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._frosted_glass_curtain.ToString();
                    break;
                case "glass.mt":
                    rawMaterial._glass = new _glass(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._glass.ToString();
                    break;
                case "glass_blendable.mt":
                    rawMaterial._glass_blendable = new _glass_blendable(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._glass_blendable.ToString();
                    break;
                case "glass_cracked_edge.mt":
                    rawMaterial._glass_cracked_edge = new _glass_cracked_edge(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._glass_cracked_edge.ToString();
                    break;
                case "glass_deferred.mt":
                    rawMaterial._glass_deferred = new _glass_deferred(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._glass_deferred.ToString();
                    break;
                case "glass_scope.mt":
                    rawMaterial._glass_scope = new _glass_scope(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._glass_scope.ToString();
                    break;
                case "glass_window_rain.mt":
                    rawMaterial._glass_window_rain = new _glass_window_rain(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._glass_window_rain.ToString();
                    break;
                case "hair.mt":
                    rawMaterial._hair = new _hair(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hair.ToString();
                    break;
                case "hair_blendable.mt":
                    rawMaterial._hair_blendable = new _hair_blendable(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hair_blendable.ToString();
                    break;
                case "hair_proxy.mt":
                    rawMaterial._hair_proxy = new _hair_proxy(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hair_proxy.ToString();
                    break;
                case "ice_fluid_mov.mt":
                    rawMaterial._ice_fluid_mov = new _ice_fluid_mov(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ice_fluid_mov.ToString();
                    break;
                case "ice_ver_mov_translucent.mt":
                    rawMaterial._ice_ver_mov_translucent = new _ice_ver_mov_translucent(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ice_ver_mov_translucent.ToString();
                    break;
                case "lights_interactive.mt":
                    rawMaterial._lights_interactive = new _lights_interactive(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._lights_interactive.ToString();
                    break;
                case "loot_drop_highlight.mt":
                    rawMaterial._loot_drop_highlight = new _loot_drop_highlight(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._loot_drop_highlight.ToString();
                    break;
                case "mesh_decal.mt":
                    rawMaterial._mesh_decal = new _mesh_decal(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal.ToString();
                    break;
                case "mesh_decal_blendable.mt":
                    rawMaterial._mesh_decal_blendable = new _mesh_decal_blendable(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_blendable.ToString();
                    break;
                case "mesh_decal_double_diffuse.mt":
                    rawMaterial._mesh_decal_double_diffuse = new _mesh_decal_double_diffuse(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_double_diffuse.ToString();
                    break;
                case "mesh_decal_emissive.mt":
                    rawMaterial._mesh_decal_emissive = new _mesh_decal_emissive(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_emissive.ToString();
                    break;
                case "mesh_decal_emissive_subsurface.mt":
                    rawMaterial._mesh_decal_emissive_subsurface = new _mesh_decal_emissive_subsurface(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_emissive_subsurface.ToString();
                    break;
                case "mesh_decal_gradientmap_recolor.mt":
                    rawMaterial._mesh_decal_gradientmap_recolor = new _mesh_decal_gradientmap_recolor(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_gradientmap_recolor.ToString();
                    break;
                case "mesh_decal_gradientmap_recolor_2.mt":
                    rawMaterial._mesh_decal_gradientmap_recolor_2 = new _mesh_decal_gradientmap_recolor_2(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_gradientmap_recolor_2.ToString();
                    break;
                case "mesh_decal_gradientmap_recolor_emissive.mt":
                    rawMaterial._mesh_decal_gradientmap_recolor_emissive = new _mesh_decal_gradientmap_recolor_emissive(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_gradientmap_recolor_emissive.ToString();
                    break;
                case "mesh_decal_multitinted.mt":
                    rawMaterial._mesh_decal_multitinted = new _mesh_decal_multitinted(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_multitinted.ToString();
                    break;
                case "mesh_decal_parallax.mt":
                    rawMaterial._mesh_decal_parallax = new _mesh_decal_parallax(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_parallax.ToString();
                    break;
                case "mesh_decal_revealed.mt":
                    rawMaterial._mesh_decal_revealed = new _mesh_decal_revealed(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_revealed.ToString();
                    break;
                case "mesh_decal_wet_character.mt":
                    rawMaterial._mesh_decal_wet_character = new _mesh_decal_wet_character(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal_wet_character.ToString();
                    break;
                case "metal_base_bink.mt":
                    rawMaterial._metal_base_bink = new _metal_base_bink(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_bink.ToString();
                    break;
                case "metal_base_det.mt":
                    rawMaterial._metal_base_det = new _metal_base_det(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_det.ToString();
                    break;
                case "metal_base_det_dithered.mt":
                    rawMaterial._metal_base_det_dithered = new _metal_base_det_dithered(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_det_dithered.ToString();
                    break;
                case "metal_base_dithered.mt":
                    rawMaterial._metal_base_dithered = new _metal_base_dithered(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_dithered.ToString();
                    break;
                case "metal_base_gradientmap_recolor.mt":
                    rawMaterial._metal_base_gradientmap_recolor = new _metal_base_gradientmap_recolor(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_gradientmap_recolor.ToString();
                    break;
                case "metal_base_parallax.mt":
                    rawMaterial._metal_base_parallax = new _metal_base_parallax(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_parallax.ToString();
                    break;
                case "metal_base_trafficlight_proxy.mt":
                    rawMaterial._metal_base_trafficlight_proxy = new _metal_base_trafficlight_proxy(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_trafficlight_proxy.ToString();
                    break;
                case "metal_base_ui.mt":
                    rawMaterial._metal_base_ui = new _metal_base_ui(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_ui.ToString();
                    break;
                case "metal_base_vertexcolored.mt":
                    rawMaterial._metal_base_vertexcolored = new _metal_base_vertexcolored(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_vertexcolored.ToString();
                    break;
                case "mikoshi_blocks_big.mt":
                    rawMaterial._mikoshi_blocks_big = new _mikoshi_blocks_big(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mikoshi_blocks_big.ToString();
                    break;
                case "mikoshi_blocks_medium.mt":
                    rawMaterial._mikoshi_blocks_medium = new _mikoshi_blocks_medium(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mikoshi_blocks_medium.ToString();
                    break;
                case "mikoshi_blocks_small.mt":
                    rawMaterial._mikoshi_blocks_small = new _mikoshi_blocks_small(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mikoshi_blocks_small.ToString();
                    break;
                case "mikoshi_parallax.mt":
                    rawMaterial._mikoshi_parallax = new _mikoshi_parallax(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mikoshi_parallax.ToString();
                    break;
                case "mikoshi_prison_cell.mt":
                    rawMaterial._mikoshi_prison_cell = new _mikoshi_prison_cell(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mikoshi_prison_cell.ToString();
                    break;
                case "multilayered_clear_coat.mt":
                    rawMaterial._multilayered_clear_coat = new _multilayered_clear_coat(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._multilayered_clear_coat.ToString();
                    break;
                case "multilayered_terrain.mt":
                    rawMaterial._multilayered_terrain = new _multilayered_terrain(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._multilayered_terrain.ToString();
                    break;
                case "neon_parallax.mt":
                    rawMaterial._neon_parallax = new _neon_parallax(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._neon_parallax.ToString();
                    break;
                case "presimulated_particles.mt":
                    rawMaterial._presimulated_particles = new _presimulated_particles(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._presimulated_particles.ToString();
                    break;
                case "proxy_ad.mt":
                    rawMaterial._proxy_ad = new _proxy_ad(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._proxy_ad.ToString();
                    break;
                case "proxy_crowd.mt":
                    rawMaterial._proxy_crowd = new _proxy_crowd(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._proxy_crowd.ToString();
                    break;
                case "q116_mikoshi_cubes.mt":
                    rawMaterial._q116_mikoshi_cubes = new _q116_mikoshi_cubes(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._q116_mikoshi_cubes.ToString();
                    break;
                case "q116_mikoshi_floor.mt":
                    rawMaterial._q116_mikoshi_floor = new _q116_mikoshi_floor(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._q116_mikoshi_floor.ToString();
                    break;
                case "q202_lake_surface.mt":
                    rawMaterial._q202_lake_surface = new _q202_lake_surface(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._q202_lake_surface.ToString();
                    break;
                case "rain.mt":
                    rawMaterial._rain = new _rain(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._rain.ToString();
                    break;
                case "road_debug_grid.mt":
                    rawMaterial._road_debug_grid = new _road_debug_grid(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._road_debug_grid.ToString();
                    break;
                case "set_stencil_3.mt":
                    rawMaterial._set_stencil_3 = new _set_stencil_3(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._set_stencil_3.ToString();
                    break;
                case "silverhand_overlay.mt":
                    rawMaterial._silverhand_overlay = new _silverhand_overlay(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._silverhand_overlay.ToString();
                    break;
                case "silverhand_overlay_blendable.mt":
                    rawMaterial._silverhand_overlay_blendable = new _silverhand_overlay_blendable(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._silverhand_overlay_blendable.ToString();
                    break;
                case "skin_blendable.mt":
                    rawMaterial._skin_blendable = new _skin_blendable(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._skin_blendable.ToString();
                    break;
                case "skybox.mt":
                    rawMaterial._skybox = new _skybox(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._skybox.ToString();
                    break;
                case "speedtree_3d_v8_billboard.mt":
                    rawMaterial._speedtree_3d_v8_billboard = new _speedtree_3d_v8_billboard(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._speedtree_3d_v8_billboard.ToString();
                    break;
                case "speedtree_3d_v8_onesided.mt":
                    rawMaterial._speedtree_3d_v8_onesided = new _speedtree_3d_v8_onesided(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._speedtree_3d_v8_onesided.ToString();
                    break;
                case "speedtree_3d_v8_onesided_gradient_recolor.mt":
                    rawMaterial._speedtree_3d_v8_onesided_gradient_recolor = new _speedtree_3d_v8_onesided_gradient_recolor(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._speedtree_3d_v8_onesided_gradient_recolor.ToString();
                    break;
                case "speedtree_3d_v8_seams.mt":
                    rawMaterial._speedtree_3d_v8_seams = new _speedtree_3d_v8_seams(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._speedtree_3d_v8_seams.ToString();
                    break;
                case "speedtree_3d_v8_twosided.mt":
                    rawMaterial._speedtree_3d_v8_twosided = new _speedtree_3d_v8_twosided(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._speedtree_3d_v8_twosided.ToString();
                    break;
                case "spline_deformed_metal_base.mt":
                    rawMaterial._spline_deformed_metal_base = new _spline_deformed_metal_base(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._spline_deformed_metal_base.ToString();
                    break;
                case "terrain_simple.mt":
                    rawMaterial._terrain_simple = new _terrain_simple(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._terrain_simple.ToString();
                    break;
                case "top_down_car_proxy_depth.mt":
                    rawMaterial._top_down_car_proxy_depth = new _top_down_car_proxy_depth(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._top_down_car_proxy_depth.ToString();
                    break;
                case "trail_decal.mt":
                    rawMaterial._trail_decal = new _trail_decal(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._trail_decal.ToString();
                    break;
                case "trail_decal_normal.mt":
                    rawMaterial._trail_decal_normal = new _trail_decal_normal(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._trail_decal_normal.ToString();
                    break;
                case "trail_decal_normal_color.mt":
                    rawMaterial._trail_decal_normal_color = new _trail_decal_normal_color(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._trail_decal_normal_color.ToString();
                    break;
                case "transparent_liquid.mt":
                    rawMaterial._transparent_liquid = new _transparent_liquid(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._transparent_liquid.ToString();
                    break;
                case "underwater_blood.mt":
                    rawMaterial._underwater_blood = new _underwater_blood(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._underwater_blood.ToString();
                    break;
                case "vehicle_destr_blendshape.mt":
                    rawMaterial._vehicle_destr_blendshape = new _vehicle_destr_blendshape(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._vehicle_destr_blendshape.ToString();
                    break;
                case "vehicle_glass.mt":
                    rawMaterial._vehicle_glass = new _vehicle_glass(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._vehicle_glass.ToString();
                    break;
                case "vehicle_glass_proxy.mt":
                    rawMaterial._vehicle_glass_proxy = new _vehicle_glass_proxy(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._vehicle_glass_proxy.ToString();
                    break;
                case "vehicle_lights.mt":
                    rawMaterial._vehicle_lights = new _vehicle_lights(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._vehicle_lights.ToString();
                    break;
                case "vehicle_mesh_decal.mt":
                    rawMaterial._vehicle_mesh_decal = new _vehicle_mesh_decal(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._vehicle_mesh_decal.ToString();
                    break;
                case "ver_mov.mt":
                    rawMaterial._ver_mov = new _ver_mov(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ver_mov.ToString();
                    break;
                case "ver_mov_glass.mt":
                    rawMaterial._ver_mov_glass = new _ver_mov_glass(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ver_mov_glass.ToString();
                    break;
                case "ver_mov_multilayered.mt":
                    rawMaterial._ver_mov_multilayered = new _ver_mov_multilayered(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ver_mov_multilayered.ToString();
                    break;
                case "ver_skinned_mov.mt":
                    rawMaterial._ver_skinned_mov = new _ver_skinned_mov(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ver_skinned_mov.ToString();
                    break;
                case "ver_skinned_mov_parade.mt":
                    rawMaterial._ver_skinned_mov_parade = new _ver_skinned_mov_parade(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ver_skinned_mov_parade.ToString();
                    break;
                case "window_interior_uv.mt":
                    rawMaterial._window_interior_uv = new _window_interior_uv(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._window_interior_uv.ToString();
                    break;
                case "window_parallax_interior.mt":
                    rawMaterial._window_parallax_interior = new _window_parallax_interior(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._window_parallax_interior.ToString();
                    break;
                case "window_parallax_interior_proxy.mt":
                    rawMaterial._window_parallax_interior_proxy = new _window_parallax_interior_proxy(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._window_parallax_interior_proxy.ToString();
                    break;
                case "window_parallax_interior_proxy_buffer.mt":
                    rawMaterial._window_parallax_interior_proxy_buffer = new _window_parallax_interior_proxy_buffer(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._window_parallax_interior_proxy_buffer.ToString();
                    break;
                case "window_very_long_distance.mt":
                    rawMaterial._window_very_long_distance = new _window_very_long_distance(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._window_very_long_distance.ToString();
                    break;
                case "worldspace_grid.mt":
                    rawMaterial._worldspace_grid = new _worldspace_grid(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._worldspace_grid.ToString();
                    break;
                case "bink_simple.mt":
                    rawMaterial._bink_simple = new _bink_simple(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._bink_simple.ToString();
                    break;
                case "cable_strip.mt":
                    rawMaterial._cable_strip = new _cable_strip(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cable_strip.ToString();
                    break;
                case "debugdraw_bias.mt":
                    rawMaterial._debugdraw_bias = new _debugdraw_bias(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._debugdraw_bias.ToString();
                    break;
                case "debugdraw_wireframe.mt":
                    rawMaterial._debugdraw_wireframe = new _debugdraw_wireframe(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._debugdraw_wireframe.ToString();
                    break;
                case "debugdraw_wireframe_bias.mt":
                    rawMaterial._debugdraw_wireframe_bias = new _debugdraw_wireframe_bias(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._debugdraw_wireframe_bias.ToString();
                    break;
                case "debug_coloring.mt":
                    rawMaterial._debug_coloring = new _debug_coloring(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._debug_coloring.ToString();
                    break;
                case "font.mt":
                    rawMaterial._font = new _font(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._font.ToString();
                    break;
                case "global_water_patch.mt":
                    rawMaterial._global_water_patch = new _global_water_patch(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._global_water_patch.ToString();
                    break;
                case "metal_base_animated_uv.mt":
                    rawMaterial._metal_base_animated_uv = new _metal_base_animated_uv(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_animated_uv.ToString();
                    break;
                case "metal_base_blendable.mt":
                    rawMaterial._metal_base_blendable = new _metal_base_blendable(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_blendable.ToString();
                    break;
                case "metal_base_fence.mt":
                    rawMaterial._metal_base_fence = new _metal_base_fence(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_fence.ToString();
                    break;
                case "metal_base_garment.mt":
                    rawMaterial._metal_base_garment = new _metal_base_garment(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_garment.ToString();
                    break;
                case "metal_base_packed.mt":
                    rawMaterial._metal_base_packed = new _metal_base_packed(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_packed.ToString();
                    break;
                case "metal_base_proxy.mt":
                    rawMaterial._metal_base_proxy = new _metal_base_proxy(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_proxy.ToString();
                    break;
                case "multilayered_debug.mt":
                    rawMaterial._multilayered_debug = new _multilayered_debug(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._multilayered_debug.ToString();
                    break;
                case "pbr_simple.mt":
                    rawMaterial._pbr_simple = new _pbr_simple(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._pbr_simple.ToString();
                    break;
                case "shadows_debug.mt":
                    rawMaterial._shadows_debug = new _shadows_debug(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._shadows_debug.ToString();
                    break;
                case "transparent_notxaa_2.mt":
                    rawMaterial._transparent_notxaa_2 = new _transparent_notxaa_2(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._transparent_notxaa_2.ToString();
                    break;
                case "ui_default_element.mt":
                    rawMaterial._ui_default_element = new _ui_default_element(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_default_element.ToString();
                    break;
                case "ui_default_nine_slice_element.mt":
                    rawMaterial._ui_default_nine_slice_element = new _ui_default_nine_slice_element(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_default_nine_slice_element.ToString();
                    break;
                case "ui_default_tile_element.mt":
                    rawMaterial._ui_default_tile_element = new _ui_default_tile_element(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_default_tile_element.ToString();
                    break;
                case "ui_effect_box_blur.mt":
                    rawMaterial._ui_effect_box_blur = new _ui_effect_box_blur(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_box_blur.ToString();
                    break;
                case "ui_effect_color_correction.mt":
                    rawMaterial._ui_effect_color_correction = new _ui_effect_color_correction(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_color_correction.ToString();
                    break;
                case "ui_effect_color_fill.mt":
                    rawMaterial._ui_effect_color_fill = new _ui_effect_color_fill(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_color_fill.ToString();
                    break;
                case "ui_effect_glitch.mt":
                    rawMaterial._ui_effect_glitch = new _ui_effect_glitch(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_glitch.ToString();
                    break;
                case "ui_effect_inner_glow.mt":
                    rawMaterial._ui_effect_inner_glow = new _ui_effect_inner_glow(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_inner_glow.ToString();
                    break;
                case "ui_effect_light_sweep.mt":
                    rawMaterial._ui_effect_light_sweep = new _ui_effect_light_sweep(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_light_sweep.ToString();
                    break;
                case "ui_effect_linear_wipe.mt":
                    rawMaterial._ui_effect_linear_wipe = new _ui_effect_linear_wipe(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_linear_wipe.ToString();
                    break;
                case "ui_effect_mask.mt":
                    rawMaterial._ui_effect_mask = new _ui_effect_mask(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_mask.ToString();
                    break;
                case "ui_effect_point_cloud.mt":
                    rawMaterial._ui_effect_point_cloud = new _ui_effect_point_cloud(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_point_cloud.ToString();
                    break;
                case "ui_effect_radial_wipe.mt":
                    rawMaterial._ui_effect_radial_wipe = new _ui_effect_radial_wipe(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_radial_wipe.ToString();
                    break;
                case "ui_effect_swipe.mt":
                    rawMaterial._ui_effect_swipe = new _ui_effect_swipe(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_effect_swipe.ToString();
                    break;
                case "ui_element_depth_texture.mt":
                    rawMaterial._ui_element_depth_texture = new _ui_element_depth_texture(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_element_depth_texture.ToString();
                    break;
                case "ui_panel.mt":
                    rawMaterial._ui_panel = new _ui_panel(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_panel.ToString();
                    break;
                case "ui_text_element.mt":
                    rawMaterial._ui_text_element = new _ui_text_element(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._ui_text_element.ToString();
                    break;
                case "alphablend_glass.mt":
                    rawMaterial._alphablend_glass = new _alphablend_glass(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._alphablend_glass.ToString();
                    break;
                case "alpha_control_refraction.mt":
                    rawMaterial._alpha_control_refraction = new _alpha_control_refraction(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._alpha_control_refraction.ToString();
                    break;
                case "animated_decal.mt":
                    rawMaterial._animated_decal = new _animated_decal(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._animated_decal.ToString();
                    break;
                case "beam_particles.mt":
                    rawMaterial._beam_particles = new _beam_particles(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._beam_particles.ToString();
                    break;
                case "blackbodyradiation.mt":
                    rawMaterial._blackbodyradiation = new _blackbodyradiation(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._blackbodyradiation.ToString();
                    break;
                case "blackbody_simple.mt":
                    rawMaterial._blackbody_simple = new _blackbody_simple(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._blackbody_simple.ToString();
                    break;
                case "blood_transparent.mt":
                    rawMaterial._blood_transparent = new _blood_transparent(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._blood_transparent.ToString();
                    break;
                case "braindance_fog.mt":
                    rawMaterial._braindance_fog = new _braindance_fog(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._braindance_fog.ToString();
                    break;
                case "braindance_particle_thermal.mt":
                    rawMaterial._braindance_particle_thermal = new _braindance_particle_thermal(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._braindance_particle_thermal.ToString();
                    break;
                case "cloak.mt":
                    rawMaterial._cloak = new _cloak(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cloak.ToString();
                    break;
                case "cyberspace_pixelsort_stencil.mt":
                    rawMaterial._cyberspace_pixelsort_stencil = new _cyberspace_pixelsort_stencil(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberspace_pixelsort_stencil.ToString();
                    break;
                case "cyberspace_pixelsort_stencil_0.mt":
                    rawMaterial._cyberspace_pixelsort_stencil_0 = new _cyberspace_pixelsort_stencil_0(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberspace_pixelsort_stencil_0.ToString();
                    break;
                case "cyberware_animation.mt":
                    rawMaterial._cyberware_animation = new _cyberware_animation(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberware_animation.ToString();
                    break;
                case "damage_indicator.mt":
                    rawMaterial._damage_indicator = new _damage_indicator(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._damage_indicator.ToString();
                    break;
                case "device_diode.mt":
                    rawMaterial._device_diode = new _device_diode(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._device_diode.ToString();
                    break;
                case "device_diode_multi_state.mt":
                    rawMaterial._device_diode_multi_state = new _device_diode_multi_state(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._device_diode_multi_state.ToString();
                    break;
                case "diode_pavements.mt":
                    rawMaterial._diode_pavements = new _diode_pavements(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._diode_pavements.ToString();
                    break;
                case "drugged_sobel.mt":
                    rawMaterial._drugged_sobel = new _drugged_sobel(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._drugged_sobel.ToString();
                    break;
                case "emissive_basic_transparent.mt":
                    rawMaterial._emissive_basic_transparent = new _emissive_basic_transparent(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._emissive_basic_transparent.ToString();
                    break;
                case "fog_laser.mt":
                    rawMaterial._fog_laser = new _fog_laser(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._fog_laser.ToString();
                    break;
                case "hologram.mt":
                    rawMaterial._hologram = new _hologram(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hologram.ToString();
                    break;
                case "hologram_two_sided.mt":
                    rawMaterial._hologram_two_sided = new _hologram_two_sided(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hologram_two_sided.ToString();
                    break;
                case "holo_projections.mt":
                    rawMaterial._holo_projections = new _holo_projections(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._holo_projections.ToString();
                    break;
                case "hud_focus_mode_scanline.mt":
                    rawMaterial._hud_focus_mode_scanline = new _hud_focus_mode_scanline(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hud_focus_mode_scanline.ToString();
                    break;
                case "hud_markers_notxaa.mt":
                    rawMaterial._hud_markers_notxaa = new _hud_markers_notxaa(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hud_markers_notxaa.ToString();
                    break;
                case "hud_markers_transparent.mt":
                    rawMaterial._hud_markers_transparent = new _hud_markers_transparent(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hud_markers_transparent.ToString();
                    break;
                case "hud_markers_vision.mt":
                    rawMaterial._hud_markers_vision = new _hud_markers_vision(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hud_markers_vision.ToString();
                    break;
                case "hud_ui_dot.mt":
                    rawMaterial._hud_ui_dot = new _hud_ui_dot(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hud_ui_dot.ToString();
                    break;
                case "hud_vision_pass.mt":
                    rawMaterial._hud_vision_pass = new _hud_vision_pass(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hud_vision_pass.ToString();
                    break;
                case "johnny_effect.mt":
                    rawMaterial._johnny_effect = new _johnny_effect(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._johnny_effect.ToString();
                    break;
                case "johnny_glitch.mt":
                    rawMaterial._johnny_glitch = new _johnny_glitch(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._johnny_glitch.ToString();
                    break;
                case "metal_base_atlas_animation.mt":
                    rawMaterial._metal_base_atlas_animation = new _metal_base_atlas_animation(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_atlas_animation.ToString();
                    break;
                case "metal_base_blackbody.mt":
                    rawMaterial._metal_base_blackbody = new _metal_base_blackbody(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_blackbody.ToString();
                    break;
                case "metal_base_glitter.mt":
                    rawMaterial._metal_base_glitter = new _metal_base_glitter(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_glitter.ToString();
                    break;
                case "neon_tubes.mt":
                    rawMaterial._neon_tubes = new _neon_tubes(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._neon_tubes.ToString();
                    break;
                case "noctovision_mode.mt":
                    rawMaterial._noctovision_mode = new _noctovision_mode(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._noctovision_mode.ToString();
                    break;
                case "parallaxscreen.mt":
                    rawMaterial._parallaxscreen = new _parallaxscreen(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._parallaxscreen.ToString();
                    break;
                case "parallaxscreen_transparent.mt":
                    rawMaterial._parallaxscreen_transparent = new _parallaxscreen_transparent(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._parallaxscreen_transparent.ToString();
                    break;
                case "parallaxscreen_transparent_ui.mt":
                    rawMaterial._parallaxscreen_transparent_ui = new _parallaxscreen_transparent_ui(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._parallaxscreen_transparent_ui.ToString();
                    break;
                case "parallax_bink.mt":
                    rawMaterial._parallax_bink = new _parallax_bink(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._parallax_bink.ToString();
                    break;
                case "particles_generic_expanded.mt":
                    rawMaterial._particles_generic_expanded = new _particles_generic_expanded(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._particles_generic_expanded.ToString();
                    break;
                case "particles_hologram.mt":
                    rawMaterial._particles_hologram = new _particles_hologram(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._particles_hologram.ToString();
                    break;
                case "pointcloud_source_mesh.mt":
                    rawMaterial._pointcloud_source_mesh = new _pointcloud_source_mesh(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._pointcloud_source_mesh.ToString();
                    break;
                case "postprocess.mt":
                    rawMaterial._postprocess = new _postprocess(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._postprocess.ToString();
                    break;
                case "postprocess_notxaa.mt":
                    rawMaterial._postprocess_notxaa = new _postprocess_notxaa(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._postprocess_notxaa.ToString();
                    break;
                case "radial_blur.mt":
                    rawMaterial._radial_blur = new _radial_blur(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._radial_blur.ToString();
                    break;
                case "reflex_buster.mt":
                    rawMaterial._reflex_buster = new _reflex_buster(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._reflex_buster.ToString();
                    break;
                case "refraction.mt":
                    rawMaterial._refraction = new _refraction(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._refraction.ToString();
                    break;
                case "sandevistan_trails.mt":
                    rawMaterial._sandevistan_trails = new _sandevistan_trails(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._sandevistan_trails.ToString();
                    break;
                case "screens.mt":
                    rawMaterial._screens = new _screens(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._screens.ToString();
                    break;
                case "screen_artifacts.mt":
                    rawMaterial._screen_artifacts = new _screen_artifacts(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._screen_artifacts.ToString();
                    break;
                case "screen_artifacts_vision.mt":
                    rawMaterial._screen_artifacts_vision = new _screen_artifacts_vision(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._screen_artifacts_vision.ToString();
                    break;
                case "screen_black.mt":
                    rawMaterial._screen_black = new _screen_black(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._screen_black.ToString();
                    break;
                case "screen_fast_travel_glitch.mt":
                    rawMaterial._screen_fast_travel_glitch = new _screen_fast_travel_glitch(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._screen_fast_travel_glitch.ToString();
                    break;
                case "screen_glitch.mt":
                    rawMaterial._screen_glitch = new _screen_glitch(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._screen_glitch.ToString();
                    break;
                case "screen_glitch_notxaa.mt":
                    rawMaterial._screen_glitch_notxaa = new _screen_glitch_notxaa(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._screen_glitch_notxaa.ToString();
                    break;
                case "screen_glitch_vision.mt":
                    rawMaterial._screen_glitch_vision = new _screen_glitch_vision(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._screen_glitch_vision.ToString();
                    break;
                case "signages.mt":
                    rawMaterial._signages = new _signages(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._signages.ToString();
                    break;
                case "signages_transparent_no_txaa.mt":
                    rawMaterial._signages_transparent_no_txaa = new _signages_transparent_no_txaa(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._signages_transparent_no_txaa.ToString();
                    break;
                case "silverhand_proxy.mt":
                    rawMaterial._silverhand_proxy = new _silverhand_proxy(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._silverhand_proxy.ToString();
                    break;
                case "simple_additive_ui.mt":
                    rawMaterial._simple_additive_ui = new _simple_additive_ui(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._simple_additive_ui.ToString();
                    break;
                case "simple_emissive_decals.mt":
                    rawMaterial._simple_emissive_decals = new _simple_emissive_decals(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._simple_emissive_decals.ToString();
                    break;
                case "simple_fresnel.mt":
                    rawMaterial._simple_fresnel = new _simple_fresnel(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._simple_fresnel.ToString();
                    break;
                case "simple_refraction.mt":
                    rawMaterial._simple_refraction = new _simple_refraction(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._simple_refraction.ToString();
                    break;
                case "sound_clue.mt":
                    rawMaterial._sound_clue = new _sound_clue(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._sound_clue.ToString();
                    break;
                case "television_ad.mt":
                    rawMaterial._television_ad = new _television_ad(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._television_ad.ToString();
                    break;
                case "triplanar_projection.mt":
                    rawMaterial._triplanar_projection = new _triplanar_projection(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._triplanar_projection.ToString();
                    break;
                case "zoom.mt":
                    rawMaterial._zoom = new _zoom(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._zoom.ToString();
                    break;
                case "alt_halo.mt":
                    rawMaterial._alt_halo = new _alt_halo(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._alt_halo.ToString();
                    break;
                case "blackbodyradiation_distant.mt":
                    rawMaterial._blackbodyradiation_distant = new _blackbodyradiation_distant(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._blackbodyradiation_distant.ToString();
                    break;
                case "blackbodyradiation_notxaa.mt":
                    rawMaterial._blackbodyradiation_notxaa = new _blackbodyradiation_notxaa(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._blackbodyradiation_notxaa.ToString();
                    break;
                case "blood_metal_base.mt":
                    rawMaterial._blood_metal_base = new _blood_metal_base(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._blood_metal_base.ToString();
                    break;
                case "caustics.mt":
                    rawMaterial._caustics = new _caustics(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._caustics.ToString();
                    break;
                case "character_kerenzikov.mt":
                    rawMaterial._character_kerenzikov = new _character_kerenzikov(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._character_kerenzikov.ToString();
                    break;
                case "character_sandevistan.mt":
                    rawMaterial._character_sandevistan = new _character_sandevistan(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._character_sandevistan.ToString();
                    break;
                case "crystal_dome.mt":
                    rawMaterial._crystal_dome = new _crystal_dome(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._crystal_dome.ToString();
                    break;
                case "crystal_dome_opaque.mt":
                    rawMaterial._crystal_dome_opaque = new _crystal_dome_opaque(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._crystal_dome_opaque.ToString();
                    break;
                case "cyberspace_gradient.mt":
                    rawMaterial._cyberspace_gradient = new _cyberspace_gradient(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberspace_gradient.ToString();
                    break;
                case "cyberspace_teleport_glitch.mt":
                    rawMaterial._cyberspace_teleport_glitch = new _cyberspace_teleport_glitch(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._cyberspace_teleport_glitch.ToString();
                    break;
                case "decal_caustics.mt":
                    rawMaterial._decal_caustics = new _decal_caustics(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_caustics.ToString();
                    break;
                case "decal_glitch.mt":
                    rawMaterial._decal_glitch = new _decal_glitch(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_glitch.ToString();
                    break;
                case "decal_glitch_emissive.mt":
                    rawMaterial._decal_glitch_emissive = new _decal_glitch_emissive(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_glitch_emissive.ToString();
                    break;
                case "depth_based_sobel.mt":
                    rawMaterial._depth_based_sobel = new _depth_based_sobel(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._depth_based_sobel.ToString();
                    break;
                case "diode_pavements_ui.mt":
                    rawMaterial._diode_pavements_ui = new _diode_pavements_ui(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._diode_pavements_ui.ToString();
                    break;
                case "dirt_animated_masked.mt":
                    rawMaterial._dirt_animated_masked = new _dirt_animated_masked(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._dirt_animated_masked.ToString();
                    break;
                case "e3_prototype_mask.mt":
                    rawMaterial._e3_prototype_mask = new _e3_prototype_mask(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._e3_prototype_mask.ToString();
                    break;
                case "fake_flare.mt":
                    rawMaterial._fake_flare = new _fake_flare(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._fake_flare.ToString();
                    break;
                case "fake_flare_simple.mt":
                    rawMaterial._fake_flare_simple = new _fake_flare_simple(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._fake_flare_simple.ToString();
                    break;
                case "flat_fog_masked.mt":
                    rawMaterial._flat_fog_masked = new _flat_fog_masked(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._flat_fog_masked.ToString();
                    break;
                case "flat_fog_masked_notxaa.mt":
                    rawMaterial._flat_fog_masked_notxaa = new _flat_fog_masked_notxaa(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._flat_fog_masked_notxaa.ToString();
                    break;
                case "highlight_blocker.mt":
                    rawMaterial._highlight_blocker = new _highlight_blocker(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._highlight_blocker.ToString();
                    break;
                case "hologram_proxy.mt":
                    rawMaterial._hologram_proxy = new _hologram_proxy(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hologram_proxy.ToString();
                    break;
                case "holo_mask.mt":
                    rawMaterial._holo_mask = new _holo_mask(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._holo_mask.ToString();
                    break;
                case "invisible.mt":
                    rawMaterial._invisible = new _invisible(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._invisible.ToString();
                    break;
                case "lightning_plasma.mt":
                    rawMaterial._lightning_plasma = new _lightning_plasma(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._lightning_plasma.ToString();
                    break;
                case "light_gradients.mt":
                    rawMaterial._light_gradients = new _light_gradients(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._light_gradients.ToString();
                    break;
                case "low_health.mt":
                    rawMaterial._low_health = new _low_health(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._low_health.ToString();
                    break;
                case "mesh_decal__blackbody.mt":
                    rawMaterial._mesh_decal__blackbody = new _mesh_decal__blackbody(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mesh_decal__blackbody.ToString();
                    break;
                case "metal_base_scrolling.mt":
                    rawMaterial._metal_base_scrolling = new _metal_base_scrolling(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base_scrolling.ToString();
                    break;
                case "multilayer_blackbody_inject.mt":
                    rawMaterial._multilayer_blackbody_inject = new _multilayer_blackbody_inject(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._multilayer_blackbody_inject.ToString();
                    break;
                case "nanowire_string.mt":
                    rawMaterial._nanowire_string = new _nanowire_string(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._nanowire_string.ToString();
                    break;
                case "oda_helm.mt":
                    rawMaterial._oda_helm = new _oda_helm(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._oda_helm.ToString();
                    break;
                case "rift_noise.mt":
                    rawMaterial._rift_noise = new _rift_noise(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._rift_noise.ToString();
                    break;
                case "screen_wave.mt":
                    rawMaterial._screen_wave = new _screen_wave(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._screen_wave.ToString();
                    break;
                case "simple_fog.mt":
                    rawMaterial._simple_fog = new _simple_fog(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._simple_fog.ToString();
                    break;
                case "simple_refraction_mask.mt":
                    rawMaterial._simple_refraction_mask = new _simple_refraction_mask(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._simple_refraction_mask.ToString();
                    break;
                case "transparent_flowmap.mt":
                    rawMaterial._transparent_flowmap = new _transparent_flowmap(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._transparent_flowmap.ToString();
                    break;
                case "transparent_liquid_notxaa.mt":
                    rawMaterial._transparent_liquid_notxaa = new _transparent_liquid_notxaa(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._transparent_liquid_notxaa.ToString();
                    break;
                case "world_to_screen_glitch.mt":
                    rawMaterial._world_to_screen_glitch = new _world_to_screen_glitch(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._world_to_screen_glitch.ToString();
                    break;
                case "hit_proxy.mt":
                    rawMaterial._hit_proxy = new _hit_proxy(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._hit_proxy.ToString();
                    break;
                case "lod_coloring.mt":
                    rawMaterial._lod_coloring = new _lod_coloring(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._lod_coloring.ToString();
                    break;
                case "overdraw.mt":
                    rawMaterial._overdraw = new _overdraw(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._overdraw.ToString();
                    break;
                case "overdraw_seethrough.mt":
                    rawMaterial._overdraw_seethrough = new _overdraw_seethrough(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._overdraw_seethrough.ToString();
                    break;
                case "selection.mt":
                    rawMaterial._selection = new _selection(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._selection.ToString();
                    break;
                case "uv_density.mt":
                    rawMaterial._uv_density = new _uv_density(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._uv_density.ToString();
                    break;
                case "wireframe.mt":
                    rawMaterial._wireframe = new _wireframe(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._wireframe.ToString();
                    break;
                case "editor_mlmask_preview.mt":
                    rawMaterial._editor_mlmask_preview = new _editor_mlmask_preview(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._editor_mlmask_preview.ToString();
                    break;
                case "editor_mltemplate_preview.mt":
                    rawMaterial._editor_mltemplate_preview = new _editor_mltemplate_preview(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._editor_mltemplate_preview.ToString();
                    break;
                case "gi_backface_debug.mt":
                    rawMaterial._gi_backface_debug = new _gi_backface_debug(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._gi_backface_debug.ToString();
                    break;
                case "multilayered_baked.mt":
                    rawMaterial._multilayered_baked = new _multilayered_baked(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._multilayered_baked.ToString();
                    break;
                case "mikoshi_fullscr_transition.mt":
                    rawMaterial._mikoshi_fullscr_transition = new _mikoshi_fullscr_transition(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mikoshi_fullscr_transition.ToString();
                    break;
                case "decal.remt":
                    rawMaterial._decal = new _decal(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal.ToString();
                    break;
                case "decal_normal.remt":
                    rawMaterial._decal_normal = new _decal_normal(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._decal_normal.ToString();
                    break;
                case "pbr_layer.remt":
                    rawMaterial._pbr_layer = new _pbr_layer(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._pbr_layer.ToString();
                    break;
                case "debugdraw.remt":
                    rawMaterial._debugdraw = new _debugdraw(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._debugdraw.ToString();
                    break;
                case "fallback.remt":
                    rawMaterial._fallback = new _fallback(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._fallback.ToString();
                    break;
                case "metal_base.remt":
                    rawMaterial._metal_base = new _metal_base(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._metal_base.ToString();
                    break;
                case "mirror.remt":
                    rawMaterial._mirror = new _mirror(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._mirror.ToString();
                    break;
                case "particles_generic.remt":
                    rawMaterial._particles_generic = new _particles_generic(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._particles_generic.ToString();
                    break;
                case "particles_liquid.remt":
                    rawMaterial._particles_liquid = new _particles_liquid(cMaterialInstance);
                    rawMaterial.MaterialType = MaterialTypes._particles_liquid.ToString();
                    break;
                default:
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
        public _skin _skin { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public _multilayered _multilayered { get; set; }
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
        unknown,
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
        _water_test,
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
        _mikoshi_fullscr_transition,
        _decal,
        _decal_normal,
        _pbr_layer,
        _debugdraw,
        _fallback,
        _metal_base,
        _mirror,
        _particles_generic,
        _particles_liquid
    }
}
