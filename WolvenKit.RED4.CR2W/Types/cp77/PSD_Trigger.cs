using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSD_Trigger : gameObject
	{
		[Ordinal(40)] [RED("ref")] public NodeRef Ref { get; set; }
		[Ordinal(41)] [RED("className")] public CName ClassName { get; set; }

		public PSD_Trigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
