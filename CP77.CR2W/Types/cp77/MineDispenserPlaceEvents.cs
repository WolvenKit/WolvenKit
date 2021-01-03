using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MineDispenserPlaceEvents : MineDispenserEventsTransition
	{
		[Ordinal(0)]  [RED("spawnNormal")] public Vector4 SpawnNormal { get; set; }
		[Ordinal(1)]  [RED("spawnPosition")] public Vector4 SpawnPosition { get; set; }

		public MineDispenserPlaceEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
