using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRaceChunk : CVariable
	{
		private CArray<gameuiRoachRaceObstacle> _obstacles;

		[Ordinal(0)] 
		[RED("obstacles")] 
		public CArray<gameuiRoachRaceObstacle> Obstacles
		{
			get
			{
				if (_obstacles == null)
				{
					_obstacles = (CArray<gameuiRoachRaceObstacle>) CR2WTypeManager.Create("array:gameuiRoachRaceObstacle", "obstacles", cr2w, this);
				}
				return _obstacles;
			}
			set
			{
				if (_obstacles == value)
				{
					return;
				}
				_obstacles = value;
				PropertySet(this);
			}
		}

		public gameuiRoachRaceChunk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
