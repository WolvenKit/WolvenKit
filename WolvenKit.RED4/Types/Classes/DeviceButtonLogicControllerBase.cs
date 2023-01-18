using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceButtonLogicControllerBase : inkButtonController
	{
		[Ordinal(10)] 
		[RED("targetWidgetRef")] 
		public inkWidgetReference TargetWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("displayNameWidget")] 
		public inkTextWidgetReference DisplayNameWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("iconWidget")] 
		public inkImageWidgetReference IconWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("toggleSwitchWidget")] 
		public inkImageWidgetReference ToggleSwitchWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("sizeProviderWidget")] 
		public inkWidgetReference SizeProviderWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("selectionMarkerWidget")] 
		public inkWidgetReference SelectionMarkerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("onReleaseAnimations")] 
		public CHandle<WidgetAnimationManager> OnReleaseAnimations
		{
			get => GetPropertyValue<CHandle<WidgetAnimationManager>>();
			set => SetPropertyValue<CHandle<WidgetAnimationManager>>(value);
		}

		[Ordinal(17)] 
		[RED("onPressAnimations")] 
		public CHandle<WidgetAnimationManager> OnPressAnimations
		{
			get => GetPropertyValue<CHandle<WidgetAnimationManager>>();
			set => SetPropertyValue<CHandle<WidgetAnimationManager>>(value);
		}

		[Ordinal(18)] 
		[RED("onHoverOverAnimations")] 
		public CHandle<WidgetAnimationManager> OnHoverOverAnimations
		{
			get => GetPropertyValue<CHandle<WidgetAnimationManager>>();
			set => SetPropertyValue<CHandle<WidgetAnimationManager>>(value);
		}

		[Ordinal(19)] 
		[RED("onHoverOutAnimations")] 
		public CHandle<WidgetAnimationManager> OnHoverOutAnimations
		{
			get => GetPropertyValue<CHandle<WidgetAnimationManager>>();
			set => SetPropertyValue<CHandle<WidgetAnimationManager>>(value);
		}

		[Ordinal(20)] 
		[RED("defaultStyle")] 
		public redResourceReferenceScriptToken DefaultStyle
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(21)] 
		[RED("selectionStyle")] 
		public redResourceReferenceScriptToken SelectionStyle
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(22)] 
		[RED("soundData")] 
		public SSoundData SoundData
		{
			get => GetPropertyValue<SSoundData>();
			set => SetPropertyValue<SSoundData>(value);
		}

		[Ordinal(23)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("targetWidget")] 
		public CWeakHandle<inkWidget> TargetWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(25)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DeviceButtonLogicControllerBase()
		{
			TargetWidgetRef = new();
			DisplayNameWidget = new();
			IconWidget = new();
			ToggleSwitchWidget = new();
			SizeProviderWidget = new();
			SelectionMarkerWidget = new();
			DefaultStyle = new();
			SelectionStyle = new();
			SoundData = new() { WidgetAudioName = "Button" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
