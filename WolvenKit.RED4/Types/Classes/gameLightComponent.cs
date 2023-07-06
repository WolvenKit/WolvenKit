using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameLightComponent : entLightComponent
	{
		[Ordinal(61)] 
		[RED("emissiveOnly")] 
		public CBool EmissiveOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(62)] 
		[RED("materialZone")] 
		public CEnum<gameEMaterialZone> MaterialZone
		{
			get => GetPropertyValue<CEnum<gameEMaterialZone>>();
			set => SetPropertyValue<CEnum<gameEMaterialZone>>(value);
		}

		[Ordinal(63)] 
		[RED("meshBrokenAppearance")] 
		public CName MeshBrokenAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(64)] 
		[RED("onStrength")] 
		public CFloat OnStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(65)] 
		[RED("turnOnByDefault")] 
		public CBool TurnOnByDefault
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(66)] 
		[RED("turnOnTime")] 
		public CFloat TurnOnTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(67)] 
		[RED("turnOnCurve")] 
		public CName TurnOnCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(68)] 
		[RED("turnOffTime")] 
		public CFloat TurnOffTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(69)] 
		[RED("turnOffCurve")] 
		public CName TurnOffCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(70)] 
		[RED("loopTime")] 
		public CFloat LoopTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(71)] 
		[RED("loopCurve")] 
		public CName LoopCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(72)] 
		[RED("isDestructible")] 
		public CBool IsDestructible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(73)] 
		[RED("colliderName")] 
		public CName ColliderName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(74)] 
		[RED("colliderTag")] 
		public CName ColliderTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(75)] 
		[RED("destructionEffect")] 
		public CResourceAsyncReference<worldEffect> DestructionEffect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		public gameLightComponent()
		{
			OnStrength = 1.000000F;
			TurnOnTime = 0.300000F;
			TurnOffTime = 0.300000F;
			IsDestructible = true;
			DestructionEffect = new CResourceAsyncReference<worldEffect>(@"base\fx\devices\_damage\street_lamps\d_damage_street_lamp_destruction_01.effect");

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
