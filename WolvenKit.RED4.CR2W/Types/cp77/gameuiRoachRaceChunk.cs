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
			get => GetProperty(ref _obstacles);
			set => SetProperty(ref _obstacles, value);
		}

		public gameuiRoachRaceChunk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
