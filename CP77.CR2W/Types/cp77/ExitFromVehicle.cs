using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ExitFromVehicle : AIVehicleTaskAbstract
	{
		[Ordinal(0)]  [RED("tryBlendToWalk")] public CBool TryBlendToWalk { get; set; }
		[Ordinal(1)]  [RED("useFastExit")] public CBool UseFastExit { get; set; }

		public ExitFromVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
