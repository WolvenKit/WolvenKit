using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_HumanIk : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("ikTargetsControllers")] public CArray<animTEMP_IKTargetsControllerBodyType> IkTargetsControllers { get; set; }

		public animAnimNode_HumanIk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
