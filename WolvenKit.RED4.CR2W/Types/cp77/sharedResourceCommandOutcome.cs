using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sharedResourceCommandOutcome : CVariable
	{
		[Ordinal(0)] [RED("result")] public CEnum<sharedCommandResult> Result { get; set; }
		[Ordinal(1)] [RED("modifiedFiles")] public CArray<CString> ModifiedFiles { get; set; }
		[Ordinal(2)] [RED("message")] public CString Message { get; set; }

		public sharedResourceCommandOutcome(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
