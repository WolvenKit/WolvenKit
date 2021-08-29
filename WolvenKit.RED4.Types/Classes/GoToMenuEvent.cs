using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GoToMenuEvent : redEvent
	{
		private CEnum<EComputerMenuType> _menuType;
		private CBool _wakeUp;
		private entEntityID _ownerID;

		[Ordinal(0)] 
		[RED("menuType")] 
		public CEnum<EComputerMenuType> MenuType
		{
			get => GetProperty(ref _menuType);
			set => SetProperty(ref _menuType, value);
		}

		[Ordinal(1)] 
		[RED("wakeUp")] 
		public CBool WakeUp
		{
			get => GetProperty(ref _wakeUp);
			set => SetProperty(ref _wakeUp, value);
		}

		[Ordinal(2)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}
	}
}
