using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class redResourceReferenceScriptToken : CVariable
	{
		[Ordinal(0)]  [RED("resource")] public raRef<CResource> Resource { get; set; }

		public redResourceReferenceScriptToken(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
