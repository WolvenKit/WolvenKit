using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMinimapDynamicEventMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(14)] 
		[RED("pulseEnabled")] 
		public CBool PulseEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("pulseWidget")] 
		public inkWidgetReference PulseWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("hideAtDistance")] 
		public CFloat HideAtDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("hideInCombat")] 
		public CBool HideInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("pulseAnim")] 
		public CHandle<inkanimProxy> PulseAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public gameuiMinimapDynamicEventMappinController()
		{
			PulseWidget = new inkWidgetReference();
			HideAtDistance = 25.000000F;
			HideInCombat = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
