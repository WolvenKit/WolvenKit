using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SDeviceActionBoolData : SDeviceActionData
	{
		[Ordinal(0)]  [RED("nameOnFalse")] public CString NameOnFalse { get; set; }
		[Ordinal(1)]  [RED("nameOnFalseRecord")] public TweakDBID NameOnFalseRecord { get; set; }
		[Ordinal(2)]  [RED("nameOnTrue")] public CString NameOnTrue { get; set; }
		[Ordinal(3)]  [RED("nameOnTrueRecord")] public TweakDBID NameOnTrueRecord { get; set; }

		public SDeviceActionBoolData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
