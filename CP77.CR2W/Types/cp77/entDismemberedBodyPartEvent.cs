using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entDismemberedBodyPartEvent : redEvent
	{
		[Ordinal(0)]  [RED("bones")] public CStatic<32,CName> Bones { get; set; }

		public entDismemberedBodyPartEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
