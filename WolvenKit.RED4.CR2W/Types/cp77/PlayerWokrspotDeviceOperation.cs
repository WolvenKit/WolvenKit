using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerWokrspotDeviceOperation : DeviceOperationBase
	{
		private SWorkspotData _playerWorkspot;

		[Ordinal(5)] 
		[RED("playerWorkspot")] 
		public SWorkspotData PlayerWorkspot
		{
			get => GetProperty(ref _playerWorkspot);
			set => SetProperty(ref _playerWorkspot, value);
		}

		public PlayerWokrspotDeviceOperation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
