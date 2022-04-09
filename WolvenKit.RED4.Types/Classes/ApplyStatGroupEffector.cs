using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyStatGroupEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("target")] 
		public gameStatsObjectID Target
		{
			get => GetPropertyValue<gameStatsObjectID>();
			set => SetPropertyValue<gameStatsObjectID>(value);
		}

		[Ordinal(1)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("applicationTarget")] 
		public CName ApplicationTarget
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("modGroupID")] 
		public CUInt64 ModGroupID
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public ApplyStatGroupEffector()
		{
			Target = new() { IdType = Enums.gameStatIDType.Invalid };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
