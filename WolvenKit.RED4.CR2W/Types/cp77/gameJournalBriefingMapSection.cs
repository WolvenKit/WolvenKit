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
			get
			{
				if (_mapLocation == null)
				{
					_mapLocation = (Vector3) CR2WTypeManager.Create("Vector3", "mapLocation", cr2w, this);
				}
				return _mapLocation;
			}
			set
			{
				if (_mapLocation == value)
				{
					return;
				}
				_mapLocation = value;
				PropertySet(this);
			}
		}

		public gameJournalBriefingMapSection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
