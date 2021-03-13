using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TogglePower : ActionBool
	{
		[Ordinal(25)] [RED("TrueRecordName")] public CString TrueRecordName { get; set; }
		[Ordinal(26)] [RED("FalseRecordName")] public CString FalseRecordName { get; set; }

		public TogglePower(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
