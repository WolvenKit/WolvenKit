using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineResultString : CVariable
	{
		[Ordinal(0)] [RED("value")] public CString Value { get; set; }
		[Ordinal(1)] [RED("valid")] public CBool Valid { get; set; }

		public gamestateMachineResultString(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
