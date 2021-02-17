using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DebugInteractionObject : gameObject
	{
		[Ordinal(40)] [RED("choices")] public CArray<SDebugChoice> Choices { get; set; }
		[Ordinal(41)] [RED("interaction")] public CHandle<gameinteractionsComponent> Interaction { get; set; }

		public DebugInteractionObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
