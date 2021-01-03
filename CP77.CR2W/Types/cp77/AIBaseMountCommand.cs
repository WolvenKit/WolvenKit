using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIBaseMountCommand : AICommand
	{
		[Ordinal(0)]  [RED("mountData")] public CHandle<gameMountEventData> MountData { get; set; }

		public AIBaseMountCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
