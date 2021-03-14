using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class redResourceReferenceScriptToken : CVariable
	{
		[Ordinal(0)] [RED("resource")] public raRef<CResource> Resource { get; set; }

		public redResourceReferenceScriptToken(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
