using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WorldMapPreloader : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("splashAnim")] 
		public CName SplashAnim
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("spinnerAnim")] 
		public CName SpinnerAnim
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("spinnerFadeOutAnim")] 
		public CName SpinnerFadeOutAnim
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("spinnerFadeInAnim")] 
		public CName SpinnerFadeInAnim
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("mapFadeOutAnim")] 
		public CName MapFadeOutAnim
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("isMapLoaded")] 
		public CBool IsMapLoaded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("isMapFadeOutStarted")] 
		public CBool IsMapFadeOutStarted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("isSpinnerVisible")] 
		public CBool IsSpinnerVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("splashProxy")] 
		public CHandle<inkanimProxy> SplashProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(10)] 
		[RED("spinnerFadeOutProxy")] 
		public CHandle<inkanimProxy> SpinnerFadeOutProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public WorldMapPreloader()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
