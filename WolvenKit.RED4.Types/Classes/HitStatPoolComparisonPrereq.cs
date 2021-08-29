using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitStatPoolComparisonPrereq : GenericHitPrereq
	{
		private CString _comparisonSource;
		private CString _comparisonTarget;
		private CEnum<EComparisonType> _comparisonType;
		private CEnum<gamedataStatPoolType> _statPoolToCompare;

		[Ordinal(5)] 
		[RED("comparisonSource")] 
		public CString ComparisonSource
		{
			get => GetProperty(ref _comparisonSource);
			set => SetProperty(ref _comparisonSource, value);
		}

		[Ordinal(6)] 
		[RED("comparisonTarget")] 
		public CString ComparisonTarget
		{
			get => GetProperty(ref _comparisonTarget);
			set => SetProperty(ref _comparisonTarget, value);
		}

		[Ordinal(7)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}

		[Ordinal(8)] 
		[RED("statPoolToCompare")] 
		public CEnum<gamedataStatPoolType> StatPoolToCompare
		{
			get => GetProperty(ref _statPoolToCompare);
			set => SetProperty(ref _statPoolToCompare, value);
		}
	}
}
