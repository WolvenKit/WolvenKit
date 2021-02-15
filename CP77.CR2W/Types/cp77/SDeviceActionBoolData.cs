using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SDeviceActionBoolData : SDeviceActionData
	{
		[Ordinal(10)] [RED("nameOnTrueRecord")] public TweakDBID NameOnTrueRecord { get; set; }
		[Ordinal(11)] [RED("nameOnTrue")] public CString NameOnTrue { get; set; }
		[Ordinal(12)] [RED("nameOnFalseRecord")] public TweakDBID NameOnFalseRecord { get; set; }
		[Ordinal(13)] [RED("nameOnFalse")] public CString NameOnFalse { get; set; }

		public SDeviceActionBoolData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
