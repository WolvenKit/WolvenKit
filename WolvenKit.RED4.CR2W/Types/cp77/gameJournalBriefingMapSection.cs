using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalBriefingMapSection : gameJournalBriefingBaseSection
	{
		private Vector3 _mapLocation;

		[Ordinal(1)] 
		[RED("mapLocation")] 
		public Vector3 MapLocation
		{
			get => GetProperty(ref _mapLocation);
			set => SetProperty(ref _mapLocation, value);
		}

		public gameJournalBriefingMapSection(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
