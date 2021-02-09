using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SDeviceActionBoolData : SDeviceActionData
	{
		[Ordinal(0)]  [RED("nameOnTrueRecord")] public TweakDBID NameOnTrueRecord { get; set; }
		[Ordinal(1)]  [RED("nameOnTrue")] public CString NameOnTrue { get; set; }
		[Ordinal(2)]  [RED("nameOnFalseRecord")] public TweakDBID NameOnFalseRecord { get; set; }
		[Ordinal(3)]  [RED("nameOnFalse")] public CString NameOnFalse { get; set; }

		public SDeviceActionBoolData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
