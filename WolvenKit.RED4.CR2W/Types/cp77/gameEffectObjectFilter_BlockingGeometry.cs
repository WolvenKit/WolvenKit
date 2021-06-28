using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_BlockingGeometry : gameEffectObjectGroupFilter
	{
		private CBool _inclusive;
		private CBool _sortQueryResultsByDistance;

		[Ordinal(0)] 
		[RED("inclusive")] 
		public CBool Inclusive
		{
			get => GetProperty(ref _inclusive);
			set => SetProperty(ref _inclusive, value);
		}

		[Ordinal(1)] 
		[RED("sortQueryResultsByDistance")] 
		public CBool SortQueryResultsByDistance
		{
			get => GetProperty(ref _sortQueryResultsByDistance);
			set => SetProperty(ref _sortQueryResultsByDistance, value);
		}

		public gameEffectObjectFilter_BlockingGeometry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
