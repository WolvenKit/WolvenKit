using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeStanceStateAbstract : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("changeStateOnDeactivate")] public CBool ChangeStateOnDeactivate { get; set; }

		public ChangeStanceStateAbstract(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
