using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomActionOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(1)] [RED("actionID")] public CName ActionID { get; set; }

		public CustomActionOperationTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
