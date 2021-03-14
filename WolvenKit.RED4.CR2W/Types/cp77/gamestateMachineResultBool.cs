using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineResultBool : CVariable
	{
		[Ordinal(0)] [RED("value")] public CBool Value { get; set; }
		[Ordinal(1)] [RED("valid")] public CBool Valid { get; set; }

		public gamestateMachineResultBool(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
