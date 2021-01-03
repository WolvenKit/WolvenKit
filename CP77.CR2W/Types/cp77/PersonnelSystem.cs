using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PersonnelSystem : DeviceSystemBase
	{
		[Ordinal(0)]  [RED("EnableE3QuickHacks")] public CBool EnableE3QuickHacks { get; set; }

		public PersonnelSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
