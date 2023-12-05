using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChargedHotkeyItemBaseController : HotkeyItemController
	{
		[Ordinal(34)] 
		[RED("chargebarSizeWidget")] 
		public inkWidgetReference ChargebarSizeWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("chargebarOpacityWidget")] 
		public inkWidgetReference ChargebarOpacityWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("startSize")] 
		public Vector2 StartSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(37)] 
		[RED("endSize")] 
		public Vector2 EndSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(38)] 
		[RED("chargebarOpacity")] 
		public CFloat ChargebarOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("statListener")] 
		public CHandle<ChargedHotkeyItemStatListener> StatListener
		{
			get => GetPropertyValue<CHandle<ChargedHotkeyItemStatListener>>();
			set => SetPropertyValue<CHandle<ChargedHotkeyItemStatListener>>(value);
		}

		[Ordinal(40)] 
		[RED("currentProgress")] 
		public CFloat CurrentProgress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(41)] 
		[RED("hideChargesAnimProxy")] 
		public CHandle<inkanimProxy> HideChargesAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(42)] 
		[RED("showChargesAnimProxy")] 
		public CHandle<inkanimProxy> ShowChargesAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(43)] 
		[RED("chargeThreshold")] 
		public CFloat ChargeThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ChargedHotkeyItemBaseController()
		{
			ChargebarSizeWidget = new inkWidgetReference();
			ChargebarOpacityWidget = new inkWidgetReference();
			StartSize = new Vector2();
			EndSize = new Vector2();
			ChargeThreshold = 0.980000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
