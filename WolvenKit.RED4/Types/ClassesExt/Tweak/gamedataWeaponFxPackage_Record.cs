
namespace WolvenKit.RED4.Types
{
	public partial class gamedataWeaponFxPackage_Record
	{
		[RED("character_pseudo_piercing")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> Character_pseudo_piercing
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
		
		[RED("character_surrounding_decals")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> Character_surrounding_decals
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
		
		[RED("NPC_vfx_hitscan_trail")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> NPC_vfx_hitscan_trail
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("NPC_vfx_hitscan_trail_chemical")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> NPC_vfx_hitscan_trail_chemical
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("NPC_vfx_hitscan_trail_electric")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> NPC_vfx_hitscan_trail_electric
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("NPC_vfx_hitscan_trail_thermal")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> NPC_vfx_hitscan_trail_thermal
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("npc_vfx_set")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Npc_vfx_set
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("player_vfx_set")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Player_vfx_set
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("preloadWaterEffects")]
		[REDProperty(IsIgnored = true)]
		public CBool PreloadWaterEffects
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("sfx_impact_context")]
		[REDProperty(IsIgnored = true)]
		public CName Sfx_impact_context
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_ground_throw")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Vfx_ground_throw
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("vfx_hitscan_trail")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Vfx_hitscan_trail
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("vfx_hitscan_trail_chemical")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Vfx_hitscan_trail_chemical
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("vfx_hitscan_trail_electric")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Vfx_hitscan_trail_electric
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("vfx_hitscan_trail_ricochet")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Vfx_hitscan_trail_ricochet
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("vfx_hitscan_trail_slowmo")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Vfx_hitscan_trail_slowmo
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("vfx_hitscan_trail_thermal")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Vfx_hitscan_trail_thermal
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("vfx_impact_add")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Vfx_impact_add
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("vfx_impact_add_enable")]
		[REDProperty(IsIgnored = true)]
		public CBool Vfx_impact_add_enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("vfx_impact_add_names")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> Vfx_impact_add_names
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("vfx_impact_add_names_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_add_names_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_asphalt")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_asphalt
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_asphalt_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_asphalt_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_brick")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_brick
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_brick_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_brick_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_camouflage")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_camouflage
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_camouflage_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_camouflage_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_cardboard")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_cardboard
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_cardboard_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_cardboard_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_carpet")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_carpet
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_carpet_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_carpet_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_ceramic")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_ceramic
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_ceramic_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_ceramic_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_character_armor")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_character_armor
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_character_armor_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_character_armor_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_character_cyberflesh")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_character_cyberflesh
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_character_cyberflesh_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_character_cyberflesh_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_character_flesh")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_character_flesh
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_character_flesh_head")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_character_flesh_head
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_character_flesh_head_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_character_flesh_head_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_character_flesh_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_character_flesh_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_character_metal")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_character_metal
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_character_metal_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_character_metal_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_character_vr")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_character_vr
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_character_vr_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_character_vr_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_concrete")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_concrete
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_concrete_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_concrete_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_concrete_water_puddles")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_concrete_water_puddles
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_concrete_water_puddles_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_concrete_water_puddles_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_cyberware_flesh")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_cyberware_flesh
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_cyberware_flesh_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_cyberware_flesh_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_cyberware_metal")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_cyberware_metal
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_cyberware_metal_head")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_cyberware_metal_head
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_cyberware_metal_head_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_cyberware_metal_head_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_cyberware_metal_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_cyberware_metal_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_damage_chemical")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Vfx_impact_damage_chemical
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("vfx_impact_damage_electric")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Vfx_impact_damage_electric
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("vfx_impact_damage_thermal")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Vfx_impact_damage_thermal
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("vfx_impact_default")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_default
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_dirt")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_dirt
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_dirt_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_dirt_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_fabrics")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_fabrics
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_fabrics_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_fabrics_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_flesh")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_flesh
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_flesh_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_flesh_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_food")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_food
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_food_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_food_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_furniture_leather")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_furniture_leather
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_furniture_leather_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_furniture_leather_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_furniture_upholstery")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_furniture_upholstery
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_furniture_upholstery_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_furniture_upholstery_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_glass")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_glass
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_glass_bulletproof")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_glass_bulletproof
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_glass_bulletproof_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_glass_bulletproof_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_glass_car")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_glass_car
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_glass_car_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_glass_car_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_glass_dst")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_glass_dst
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_glass_dst_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_glass_dst_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_glass_electronics")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_glass_electronics
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_glass_electronics_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_glass_electronics_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_glass_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_glass_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_glass_opaque")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_glass_opaque
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_glass_opaque_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_glass_opaque_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_glass_semitransparent")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_glass_semitransparent
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_glass_semitransparent_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_glass_semitransparent_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_grass")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_grass
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_grass_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_grass_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_leather")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_leather
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_leather_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_leather_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_leaves")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_leaves
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_leaves_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_leaves_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_leaves_semitransparent")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_leaves_semitransparent
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_leaves_semitransparent_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_leaves_semitransparent_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_linoleum")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_linoleum
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_linoleum_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_linoleum_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_meat")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_meat
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_meat_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_meat_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_meatbag")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_meatbag
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_meatbag_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_meatbag_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_metal")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_metal
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_metal_car")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_metal_car
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_metal_car_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_metal_car_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_metal_catwalk")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_metal_catwalk
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_metal_catwalk_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_metal_catwalk_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_metal_hollow")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_metal_hollow
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_metal_hollow_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_metal_hollow_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_metal_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_metal_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_metal_painted")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_metal_painted
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_metal_painted_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_metal_painted_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_metal_pipe_steam")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_metal_pipe_steam
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_metal_pipe_steam_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_metal_pipe_steam_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_metal_pipe_water")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_metal_pipe_water
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_metal_pipe_water_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_metal_pipe_water_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_metal_road")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_metal_road
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_metal_road_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_metal_road_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_metal_semitransparent")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_metal_semitransparent
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_metal_semitransparent_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_metal_semitransparent_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_metal_transparent")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_metal_transparent
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_metal_transparent_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_metal_transparent_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_mud")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_mud
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_mud_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_mud_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_neon")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_neon
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_neon_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_neon_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_paper")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_paper
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_paper_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_paper_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_plaster")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_plaster
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_plaster_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_plaster_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_plastic")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_plastic
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_plastic_car")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_plastic_car
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_plastic_car_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_plastic_car_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_plastic_electronics")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_plastic_electronics
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_plastic_electronics_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_plastic_electronics_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_plastic_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_plastic_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_plastic_road")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_plastic_road
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_plastic_road_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_plastic_road_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_plexiglass")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_plexiglass
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_plexiglass_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_plexiglass_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_rubber")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_rubber
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_rubber_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_rubber_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_sand")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_sand
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_sand_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_sand_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_stone")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_stone
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_stone_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_stone_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_tiles")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_tiles
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_tiles_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_tiles_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_tire_car")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_tire_car
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_tire_car_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_tire_car_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_trash")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_trash
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_trash_bag")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_trash_bag
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_trash_bag_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_trash_bag_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_trash_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_trash_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_upholstery_car")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_upholstery_car
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_upholstery_car_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_upholstery_car_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_vehicle_chassis")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_vehicle_chassis
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_vehicle_chassis_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_vehicle_chassis_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_water")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_water
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_water_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_water_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_wood")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_wood
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_wood_bamboo_poles")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_wood_bamboo_poles
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_wood_bamboo_poles_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_wood_bamboo_poles_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_wood_crown")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_wood_crown
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_wood_crown_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_wood_crown_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_wood_hedge")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_wood_hedge
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_wood_hedge_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_wood_hedge_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_wood_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_wood_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_impact_wood_tree")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vfx_impact_wood_tree
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vfx_impact_wood_tree_material")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_impact_wood_tree_material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_projectile_trail_name")]
		[REDProperty(IsIgnored = true)]
		public CName Vfx_projectile_trail_name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfx_ricochet")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Vfx_ricochet
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("waterImpulseFrames")]
		[REDProperty(IsIgnored = true)]
		public CInt32 WaterImpulseFrames
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("waterImpulseRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat WaterImpulseRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("waterImpulseStrength")]
		[REDProperty(IsIgnored = true)]
		public CFloat WaterImpulseStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
