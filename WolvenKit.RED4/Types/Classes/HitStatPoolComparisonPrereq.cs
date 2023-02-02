using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HitStatPoolComparisonPrereq : GenericHitPrereq
	{
		[Ordinal(5)] 
		[RED("comparisonSource")] 
		public CString ComparisonSource
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("comparisonTarget")] 
		public CString ComparisonTarget
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}

		[Ordinal(8)] 
		[RED("statPoolToCompare")] 
		public CEnum<gamedataStatPoolType> StatPoolToCompare
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		public HitStatPoolComparisonPrereq()
		{
			IsSync = true;
			PipelineStage = Enums.gameDamagePipelineStage.Process;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
