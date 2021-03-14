using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetControllerSnapshot : CVariable
	{
		[Ordinal(0)] [RED("controllerId")] public CName ControllerId { get; set; }
		[Ordinal(1)] [RED("isActive")] public CBool IsActive { get; set; }

		public gameMuppetControllerSnapshot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
