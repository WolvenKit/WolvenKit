using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleOffMeshConnectionsDeviceOperation : DeviceOperationBase
	{
		private CBool _enable;
		private CBool _affectsPlayer;
		private CBool _affectsNPCs;

		[Ordinal(5)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(6)] 
		[RED("affectsPlayer")] 
		public CBool AffectsPlayer
		{
			get => GetProperty(ref _affectsPlayer);
			set => SetProperty(ref _affectsPlayer, value);
		}

		[Ordinal(7)] 
		[RED("affectsNPCs")] 
		public CBool AffectsNPCs
		{
			get => GetProperty(ref _affectsNPCs);
			set => SetProperty(ref _affectsNPCs, value);
		}

		public ToggleOffMeshConnectionsDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
