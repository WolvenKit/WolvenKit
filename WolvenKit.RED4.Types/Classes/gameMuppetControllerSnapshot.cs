using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetControllerSnapshot : RedBaseClass
	{
		private CName _controllerId;
		private CBool _isActive;

		[Ordinal(0)] 
		[RED("controllerId")] 
		public CName ControllerId
		{
			get => GetProperty(ref _controllerId);
			set => SetProperty(ref _controllerId, value);
		}

		[Ordinal(1)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}
	}
}
