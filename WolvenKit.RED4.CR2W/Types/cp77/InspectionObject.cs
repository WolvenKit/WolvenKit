using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InspectionObject : gameObject
	{
		[Ordinal(40)] [RED("interaction")] public CHandle<gameinteractionsComponent> Interaction { get; set; }

		public InspectionObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
