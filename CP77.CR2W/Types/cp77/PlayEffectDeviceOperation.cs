using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PlayEffectDeviceOperation : DeviceOperationBase
	{
		[Ordinal(0)]  [RED("VFXs")] public CArray<SVFXOperationData> VFXs { get; set; }
		[Ordinal(1)]  [RED("fxInstances")] public CArray<SVfxInstanceData> FxInstances { get; set; }

		public PlayEffectDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
