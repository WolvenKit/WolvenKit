using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayEffectDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)]  [RED("VFXs")] public CArray<SVFXOperationData> VFXs { get; set; }
		[Ordinal(6)]  [RED("fxInstances")] public CArray<SVfxInstanceData> FxInstances { get; set; }

		public PlayEffectDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
