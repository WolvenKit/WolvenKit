using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] [RED("stims")] public CArray<SStimOperationData> Stims { get; set; }

		public StimDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
