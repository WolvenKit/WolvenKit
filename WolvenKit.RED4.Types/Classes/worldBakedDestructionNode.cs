using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldBakedDestructionNode : worldMeshNode
	{
		[Ordinal(15)] 
		[RED("meshFractured")] 
		public CResourceAsyncReference<CMesh> MeshFractured
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(16)] 
		[RED("meshFracturedAppearance")] 
		public CName MeshFracturedAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("numFrames")] 
		public CFloat NumFrames
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("frameRate")] 
		public CFloat FrameRate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("playOnlyOnce")] 
		public CBool PlayOnlyOnce
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("restartOnTrigger")] 
		public CBool RestartOnTrigger
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("disableCollidersOnTrigger")] 
		public CBool DisableCollidersOnTrigger
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("filterDataSource")] 
		public CEnum<physicsFilterDataSource> FilterDataSource
		{
			get => GetPropertyValue<CEnum<physicsFilterDataSource>>();
			set => SetPropertyValue<CEnum<physicsFilterDataSource>>(value);
		}

		[Ordinal(23)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		[Ordinal(24)] 
		[RED("damageThreshold")] 
		public CFloat DamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("damageEndurance")] 
		public CFloat DamageEndurance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("impulseToDamage")] 
		public CFloat ImpulseToDamage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("contactToDamage")] 
		public CFloat ContactToDamage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(28)] 
		[RED("accumulateDamage")] 
		public CBool AccumulateDamage
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("destructionEffect")] 
		public CResourceAsyncReference<worldEffect> DestructionEffect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		[Ordinal(30)] 
		[RED("audioMetadata")] 
		public CName AudioMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(31)] 
		[RED("navigationSetting")] 
		public NavGenNavigationSetting NavigationSetting
		{
			get => GetPropertyValue<NavGenNavigationSetting>();
			set => SetPropertyValue<NavGenNavigationSetting>(value);
		}

		[Ordinal(32)] 
		[RED("useMeshNavmeshSettings")] 
		public CBool UseMeshNavmeshSettings
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldBakedDestructionNode()
		{
			FrameRate = 24.000000F;
			PlayOnlyOnce = true;
			DisableCollidersOnTrigger = true;
			DamageThreshold = 10.000000F;
			DamageEndurance = 20.000000F;
			ImpulseToDamage = 1.000000F;
			ContactToDamage = 1.000000F;
			AccumulateDamage = true;
			NavigationSetting = new() { NavmeshImpact = Enums.NavGenNavmeshImpact.Blocking };
			UseMeshNavmeshSettings = true;
		}
	}
}
