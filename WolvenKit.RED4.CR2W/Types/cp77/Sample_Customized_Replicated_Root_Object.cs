using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Customized_Replicated_Root_Object : Sample_Replicated_Root_Object
	{
		[Ordinal(1)] [RED("bool2")] public CBool Bool2 { get; set; }

		public Sample_Customized_Replicated_Root_Object(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
