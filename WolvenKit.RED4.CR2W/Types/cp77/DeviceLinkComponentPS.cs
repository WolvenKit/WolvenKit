using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceLinkComponentPS : SharedGameplayPS
	{
		private DeviceLink _parentDevice;
		private CBool _isConnected;
		private entEntityID _ownerEntityID;

		[Ordinal(22)] 
		[RED("parentDevice")] 
		public DeviceLink ParentDevice
		{
			get => GetProperty(ref _parentDevice);
			set => SetProperty(ref _parentDevice, value);
		}

		[Ordinal(23)] 
		[RED("isConnected")] 
		public CBool IsConnected
		{
			get => GetProperty(ref _isConnected);
			set => SetProperty(ref _isConnected, value);
		}

		[Ordinal(24)] 
		[RED("ownerEntityID")] 
		public entEntityID OwnerEntityID
		{
			get => GetProperty(ref _ownerEntityID);
			set => SetProperty(ref _ownerEntityID, value);
		}

		public DeviceLinkComponentPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
