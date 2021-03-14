using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SPerformedActions : CVariable
	{
		[Ordinal(0)] [RED("ID")] public CName ID { get; set; }
		[Ordinal(1)] [RED("ActionContext")] public CArray<CEnum<EActionContext>> ActionContext { get; set; }

		public SPerformedActions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
