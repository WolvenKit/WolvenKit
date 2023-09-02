using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkCursorInfo : inkUserData
	{
		[Ordinal(0)] 
		[RED("pos")] 
		public Vector2 Pos
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(1)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("cursorForDevice")] 
		public CName CursorForDevice
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkCursorInfo()
		{
			Pos = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
