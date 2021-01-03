using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vehicleForbiddenAreaState : CVariable
	{
		[Ordinal(0)]  [RED("dismount")] public CBool Dismount { get; set; }
		[Ordinal(1)]  [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(2)]  [RED("globalNodeIDHash")] public CUInt64 GlobalNodeIDHash { get; set; }

		public vehicleForbiddenAreaState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
