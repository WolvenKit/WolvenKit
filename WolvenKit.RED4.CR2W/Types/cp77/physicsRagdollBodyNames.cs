using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsRagdollBodyNames : CVariable
	{
		[Ordinal(0)] [RED("ParentAnimName")] public CName ParentAnimName { get; set; }
		[Ordinal(1)] [RED("ChildAnimName")] public CName ChildAnimName { get; set; }

		public physicsRagdollBodyNames(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
