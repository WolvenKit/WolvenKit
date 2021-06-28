using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TeleportDeviceOperation : DeviceOperationBase
	{
		private STeleportOperationData _teleport;

		[Ordinal(5)] 
		[RED("teleport")] 
		public STeleportOperationData Teleport
		{
			get => GetProperty(ref _teleport);
			set => SetProperty(ref _teleport, value);
		}

		public TeleportDeviceOperation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
