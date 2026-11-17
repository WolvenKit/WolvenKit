using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChaosWeaponCustomEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("effectorOwnerID")] 
		public entEntityID EffectorOwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("targets")] 
		public CArray<gameStatsObjectID> Targets
		{
			get => GetPropertyValue<CArray<gameStatsObjectID>>();
			set => SetPropertyValue<CArray<gameStatsObjectID>>(value);
		}

		[Ordinal(2)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("applicationTarget")] 
		public CName ApplicationTarget
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("modGroupID")] 
		public CUInt64 ModGroupID
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public ChaosWeaponCustomEffector()
		{
			EffectorOwnerID = new entEntityID();
			Targets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
