using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameMuppetControllerSnapshot : CVariable
	{
		[Ordinal(0)]  [RED("controllerId")] public CName ControllerId { get; set; }
		[Ordinal(1)]  [RED("isActive")] public CBool IsActive { get; set; }

		public gameMuppetControllerSnapshot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
