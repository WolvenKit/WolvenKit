using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayLibraryAnimationButtonView : BaseButtonView
	{
		[Ordinal(5)] 
		[RED("ToHoverAnimationName")] 
		public CName ToHoverAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("ToPressedAnimationName")] 
		public CName ToPressedAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("ToDefaultAnimationName")] 
		public CName ToDefaultAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("ToDisabledAnimationName")] 
		public CName ToDisabledAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("InputAnimation")] 
		public CHandle<inkanimProxy> InputAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public PlayLibraryAnimationButtonView()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
