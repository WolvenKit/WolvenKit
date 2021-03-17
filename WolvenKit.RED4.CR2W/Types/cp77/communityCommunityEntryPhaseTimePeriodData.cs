using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communityCommunityEntryPhaseTimePeriodData : CVariable
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

		public communityCommunityEntryPhaseTimePeriodData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
