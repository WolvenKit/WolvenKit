using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipWeaponInfoModule : ItemTooltipModuleController
	{
		private inkWidgetReference _wrapper;
		private inkImageWidgetReference _arrow;
		private inkTextWidgetReference _dpsText;
		private inkTextWidgetReference _perHitText;
		private inkTextWidgetReference _attacksPerSecondText;
		private inkTextWidgetReference _nonLethal;
		private inkWidgetReference _scopeIndicator;
		private inkWidgetReference _silencerIndicator;
		private inkTextWidgetReference _ammoText;
		private inkWidgetReference _ammoWrapper;

		[Ordinal(2)] 
		[RED("wrapper")] 
		public inkWidgetReference Wrapper
		{
			get => GetProperty(ref _wrapper);
			set => SetProperty(ref _wrapper, value);
		}

		[Ordinal(3)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get => GetProperty(ref _arrow);
			set => SetProperty(ref _arrow, value);
		}

		[Ordinal(4)] 
		[RED("dpsText")] 
		public inkTextWidgetReference DpsText
		{
			get => GetProperty(ref _dpsText);
			set => SetProperty(ref _dpsText, value);
		}

		[Ordinal(5)] 
		[RED("perHitText")] 
		public inkTextWidgetReference PerHitText
		{
			get => GetProperty(ref _perHitText);
			set => SetProperty(ref _perHitText, value);
		}

		[Ordinal(6)] 
		[RED("attacksPerSecondText")] 
		public inkTextWidgetReference AttacksPerSecondText
		{
			get => GetProperty(ref _attacksPerSecondText);
			set => SetProperty(ref _attacksPerSecondText, value);
		}

		[Ordinal(7)] 
		[RED("nonLethal")] 
		public inkTextWidgetReference NonLethal
		{
			get => GetProperty(ref _nonLethal);
			set => SetProperty(ref _nonLethal, value);
		}

		[Ordinal(8)] 
		[RED("scopeIndicator")] 
		public inkWidgetReference ScopeIndicator
		{
			get => GetProperty(ref _scopeIndicator);
			set => SetProperty(ref _scopeIndicator, value);
		}

		[Ordinal(9)] 
		[RED("silencerIndicator")] 
		public inkWidgetReference SilencerIndicator
		{
			get => GetProperty(ref _silencerIndicator);
			set => SetProperty(ref _silencerIndicator, value);
		}

		[Ordinal(10)] 
		[RED("ammoText")] 
		public inkTextWidgetReference AmmoText
		{
			get => GetProperty(ref _ammoText);
			set => SetProperty(ref _ammoText, value);
		}

		[Ordinal(11)] 
		[RED("ammoWrapper")] 
		public inkWidgetReference AmmoWrapper
		{
			get => GetProperty(ref _ammoWrapper);
			set => SetProperty(ref _ammoWrapper, value);
		}
	}
}
