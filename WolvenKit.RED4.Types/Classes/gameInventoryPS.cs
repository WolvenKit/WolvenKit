using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameInventoryPS : gameComponentPS
	{
		private CBool _isRegisteredShared;
		private CBool _accessible;

		[Ordinal(0)] 
		[RED("isRegisteredShared")] 
		public CBool IsRegisteredShared
		{
			get => GetProperty(ref _isRegisteredShared);
			set => SetProperty(ref _isRegisteredShared, value);
		}

		[Ordinal(1)] 
		[RED("accessible")] 
		public CBool Accessible
		{
			get => GetProperty(ref _accessible);
			set => SetProperty(ref _accessible, value);
		}
	}
}
