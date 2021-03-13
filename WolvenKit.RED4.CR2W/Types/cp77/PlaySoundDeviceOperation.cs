using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlaySoundDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] [RED("SFXs")] public CArray<SSFXOperationData> SFXs { get; set; }

		public PlaySoundDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
