using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ProgressBarSimpleWidgetLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("currentValue")] 
		public CFloat CurrentValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("previousValue")] 
		public CFloat PreviousValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("MaxCNBarFlashSize")] 
		public CFloat MaxCNBarFlashSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("fullBar")] 
		public inkWidgetReference FullBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("changePBar")] 
		public inkWidgetReference ChangePBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("changeNBar")] 
		public inkWidgetReference ChangeNBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("emptyBar")] 
		public inkWidgetReference EmptyBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("barCap")] 
		public inkWidgetReference BarCap
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("damagePreviewBar")] 
		public inkWidgetReference DamagePreviewBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("showBarCap")] 
		public CBool ShowBarCap
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("animDuration")] 
		public CFloat AnimDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("full_anim_proxy")] 
		public CHandle<inkanimProxy> Full_anim_proxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(15)] 
		[RED("full_anim")] 
		public CHandle<inkanimDefinition> Full_anim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(16)] 
		[RED("empty_anim_proxy")] 
		public CHandle<inkanimProxy> Empty_anim_proxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(17)] 
		[RED("empty_anim")] 
		public CHandle<inkanimDefinition> Empty_anim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(18)] 
		[RED("changeP_anim_proxy")] 
		public CHandle<inkanimProxy> ChangeP_anim_proxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(19)] 
		[RED("changeP_anim")] 
		public CHandle<inkanimDefinition> ChangeP_anim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(20)] 
		[RED("changeN_anim_proxy")] 
		public CHandle<inkanimProxy> ChangeN_anim_proxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(21)] 
		[RED("changeN_anim")] 
		public CHandle<inkanimDefinition> ChangeN_anim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(22)] 
		[RED("barCap_anim_proxy")] 
		public CHandle<inkanimProxy> BarCap_anim_proxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(23)] 
		[RED("barCap_anim")] 
		public CHandle<inkanimDefinition> BarCap_anim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(24)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCompoundWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		public ProgressBarSimpleWidgetLogicController()
		{
			CurrentValue = 1.000000F;
			PreviousValue = 1.000000F;
			MaxCNBarFlashSize = 500.000000F;
			FullBar = new inkWidgetReference();
			ChangePBar = new inkWidgetReference();
			ChangeNBar = new inkWidgetReference();
			EmptyBar = new inkWidgetReference();
			BarCap = new inkWidgetReference();
			DamagePreviewBar = new inkWidgetReference();
			AnimDuration = 2.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
