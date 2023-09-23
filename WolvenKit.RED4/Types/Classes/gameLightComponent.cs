using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameLightComponent : entLightComponent
	{
		[Ordinal(60)] 
		[RED("emissiveOnly")] 
		public CBool EmissiveOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(61)] 
		[RED("materialZone")] 
		public CEnum<gameEMaterialZone> MaterialZone
		{
			get => GetPropertyValue<CEnum<gameEMaterialZone>>();
			set => SetPropertyValue<CEnum<gameEMaterialZone>>(value);
		}

		[Ordinal(62)] 
		[RED("meshBrokenAppearance")] 
		public CName MeshBrokenAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(63)] 
		[RED("onStrength")] 
		public CFloat OnStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(64)] 
		[RED("turnOnByDefault")] 
		public CBool TurnOnByDefault
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(65)] 
		[RED("turnOnTime")] 
		public CFloat TurnOnTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(66)] 
		[RED("turnOnCurve")] 
		public CName TurnOnCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(67)] 
		[RED("turnOffTime")] 
		public CFloat TurnOffTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(68)] 
		[RED("turnOffCurve")] 
		public CName TurnOffCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(69)] 
		[RED("loopTime")] 
		public CFloat LoopTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(70)] 
		[RED("loopCurve")] 
		public CName LoopCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(71)] 
		[RED("synchronizedLoop")] 
		public CBool SynchronizedLoop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
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

		[Ordinal(76)] 
		[RED("genericCurveSetOverride")] 
		public CResourceReference<CurveSet> GenericCurveSetOverride
		{
			get => GetPropertyValue<CResourceReference<CurveSet>>();
			set => SetPropertyValue<CResourceReference<CurveSet>>(value);
		}

		public gameLightComponent()
		{
			OnStrength = 1.000000F;
			TurnOnTime = 0.300000F;
			TurnOffTime = 0.300000F;
			IsDestructible = true;
			DestructionEffect = new CResourceAsyncReference<worldEffect>(8977575342678214539);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
