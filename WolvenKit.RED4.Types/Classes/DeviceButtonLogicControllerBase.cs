using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceButtonLogicControllerBase : inkButtonController
	{
		private inkWidgetReference _targetWidgetRef;
		private inkTextWidgetReference _displayNameWidget;
		private inkImageWidgetReference _iconWidget;
		private inkImageWidgetReference _toggleSwitchWidget;
		private inkWidgetReference _sizeProviderWidget;
		private inkWidgetReference _selectionMarkerWidget;
		private CHandle<WidgetAnimationManager> _onReleaseAnimations;
		private CHandle<WidgetAnimationManager> _onPressAnimations;
		private CHandle<WidgetAnimationManager> _onHoverOverAnimations;
		private CHandle<WidgetAnimationManager> _onHoverOutAnimations;
		private redResourceReferenceScriptToken _defaultStyle;
		private redResourceReferenceScriptToken _selectionStyle;
		private SSoundData _soundData;
		private CBool _isInitialized;
		private CWeakHandle<inkWidget> _targetWidget;
		private CBool _isSelected;

		[Ordinal(10)] 
		[RED("targetWidgetRef")] 
		public inkWidgetReference TargetWidgetRef
		{
			get => GetProperty(ref _targetWidgetRef);
			set => SetProperty(ref _targetWidgetRef, value);
		}

		[Ordinal(11)] 
		[RED("displayNameWidget")] 
		public inkTextWidgetReference DisplayNameWidget
		{
			get => GetProperty(ref _displayNameWidget);
			set => SetProperty(ref _displayNameWidget, value);
		}

		[Ordinal(12)] 
		[RED("iconWidget")] 
		public inkImageWidgetReference IconWidget
		{
			get => GetProperty(ref _iconWidget);
			set => SetProperty(ref _iconWidget, value);
		}

		[Ordinal(13)] 
		[RED("toggleSwitchWidget")] 
		public inkImageWidgetReference ToggleSwitchWidget
		{
			get => GetProperty(ref _toggleSwitchWidget);
			set => SetProperty(ref _toggleSwitchWidget, value);
		}

		[Ordinal(14)] 
		[RED("sizeProviderWidget")] 
		public inkWidgetReference SizeProviderWidget
		{
			get => GetProperty(ref _sizeProviderWidget);
			set => SetProperty(ref _sizeProviderWidget, value);
		}

		[Ordinal(15)] 
		[RED("selectionMarkerWidget")] 
		public inkWidgetReference SelectionMarkerWidget
		{
			get => GetProperty(ref _selectionMarkerWidget);
			set => SetProperty(ref _selectionMarkerWidget, value);
		}

		[Ordinal(16)] 
		[RED("onReleaseAnimations")] 
		public CHandle<WidgetAnimationManager> OnReleaseAnimations
		{
			get => GetProperty(ref _onReleaseAnimations);
			set => SetProperty(ref _onReleaseAnimations, value);
		}

		[Ordinal(17)] 
		[RED("onPressAnimations")] 
		public CHandle<WidgetAnimationManager> OnPressAnimations
		{
			get => GetProperty(ref _onPressAnimations);
			set => SetProperty(ref _onPressAnimations, value);
		}

		[Ordinal(18)] 
		[RED("onHoverOverAnimations")] 
		public CHandle<WidgetAnimationManager> OnHoverOverAnimations
		{
			get => GetProperty(ref _onHoverOverAnimations);
			set => SetProperty(ref _onHoverOverAnimations, value);
		}

		[Ordinal(19)] 
		[RED("onHoverOutAnimations")] 
		public CHandle<WidgetAnimationManager> OnHoverOutAnimations
		{
			get => GetProperty(ref _onHoverOutAnimations);
			set => SetProperty(ref _onHoverOutAnimations, value);
		}

		[Ordinal(20)] 
		[RED("defaultStyle")] 
		public redResourceReferenceScriptToken DefaultStyle
		{
			get => GetProperty(ref _defaultStyle);
			set => SetProperty(ref _defaultStyle, value);
		}

		[Ordinal(21)] 
		[RED("selectionStyle")] 
		public redResourceReferenceScriptToken SelectionStyle
		{
			get => GetProperty(ref _selectionStyle);
			set => SetProperty(ref _selectionStyle, value);
		}

		[Ordinal(22)] 
		[RED("soundData")] 
		public SSoundData SoundData
		{
			get => GetProperty(ref _soundData);
			set => SetProperty(ref _soundData, value);
		}

		[Ordinal(23)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetProperty(ref _isInitialized);
			set => SetProperty(ref _isInitialized, value);
		}

		[Ordinal(24)] 
		[RED("targetWidget")] 
		public CWeakHandle<inkWidget> TargetWidget
		{
			get => GetProperty(ref _targetWidget);
			set => SetProperty(ref _targetWidget, value);
		}

		[Ordinal(25)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetProperty(ref _isSelected);
			set => SetProperty(ref _isSelected, value);
		}
	}
}
