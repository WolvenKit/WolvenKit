using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class communityCommunityEntryPhaseTimePeriodData : RedBaseClass
	{
		private CName _periodName;
		private CArray<worldGlobalNodeID> _spotNodeIds;
		private CBool _isSequence;

		[Ordinal(0)] 
		[RED("periodName")] 
		public CName PeriodName
		{
			get => GetProperty(ref _periodName);
			set => SetProperty(ref _periodName, value);
		}

		[Ordinal(1)] 
		[RED("spotNodeIds")] 
		public CArray<worldGlobalNodeID> SpotNodeIds
		{
			get => GetProperty(ref _spotNodeIds);
			set => SetProperty(ref _spotNodeIds, value);
		}

		[Ordinal(2)] 
		[RED("isSequence")] 
		public CBool IsSequence
		{
			get => GetProperty(ref _isSequence);
			set => SetProperty(ref _isSequence, value);
		}
	}
}
