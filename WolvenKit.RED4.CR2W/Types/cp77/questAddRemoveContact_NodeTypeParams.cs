using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAddRemoveContact_NodeTypeParams : CVariable
	{
		[Ordinal(0)] [RED("contact")] public CName Contact { get; set; }
		[Ordinal(1)] [RED("addContact")] public CBool AddContact { get; set; }

		public questAddRemoveContact_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
