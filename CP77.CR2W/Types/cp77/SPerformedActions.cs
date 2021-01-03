using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SPerformedActions : CVariable
	{
		[Ordinal(0)]  [RED("ActionContext")] public CArray<CEnum<EActionContext>> ActionContext { get; set; }
		[Ordinal(1)]  [RED("ID")] public CName ID { get; set; }

		public SPerformedActions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
