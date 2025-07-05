using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AOEAreaSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("areaEffect")] 
		public TweakDBID AreaEffect
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("actionName")] 
		public TweakDBID ActionName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("blocksVisibility")] 
		public CBool BlocksVisibility
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isDangerous")] 
		public CBool IsDangerous
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("activateOnStartup")] 
		public CBool ActivateOnStartup
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("effectsOnlyActiveInArea")] 
		public CBool EffectsOnlyActiveInArea
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("actionWidgetRecord")] 
		public TweakDBID ActionWidgetRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(8)] 
		[RED("deviceWidgetRecord")] 
		public TweakDBID DeviceWidgetRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(9)] 
		[RED("thumbnailWidgetRecord")] 
		public TweakDBID ThumbnailWidgetRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public AOEAreaSetup()
		{
			Duration = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
