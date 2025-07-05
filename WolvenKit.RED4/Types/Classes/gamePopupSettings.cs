using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePopupSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("closeAtInput")] 
		public CBool CloseAtInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("pauseGame")] 
		public CBool PauseGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("position")] 
		public CEnum<gamePopupPosition> Position
		{
			get => GetPropertyValue<CEnum<gamePopupPosition>>();
			set => SetPropertyValue<CEnum<gamePopupPosition>>(value);
		}

		[Ordinal(3)] 
		[RED("fullscreen")] 
		public CBool Fullscreen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("hideInMenu")] 
		public CBool HideInMenu
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		public gamePopupSettings()
		{
			CloseAtInput = true;
			Position = Enums.gamePopupPosition.Center;
			Margin = new inkMargin();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
