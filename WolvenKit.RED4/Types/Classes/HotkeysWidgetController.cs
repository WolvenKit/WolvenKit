using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HotkeysWidgetController : gameuiNewPhoneRelatedHUDGameController
	{
		[Ordinal(15)] 
		[RED("phoneSlot")] 
		public inkCompoundWidgetReference PhoneSlot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("carSlot")] 
		public inkCompoundWidgetReference CarSlot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("radioSlot")] 
		public inkCompoundWidgetReference RadioSlot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("dpadHintsPanel")] 
		public inkCompoundWidgetReference DpadHintsPanel
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("phone")] 
		public CWeakHandle<inkWidget> Phone
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(20)] 
		[RED("car")] 
		public CWeakHandle<inkWidget> Car
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(21)] 
		[RED("radio")] 
		public CWeakHandle<inkWidget> Radio
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(22)] 
		[RED("consumables")] 
		public CWeakHandle<inkWidget> Consumables
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(23)] 
		[RED("gadgets")] 
		public CWeakHandle<inkWidget> Gadgets
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(24)] 
		[RED("cyberware")] 
		public CWeakHandle<inkWidget> Cyberware
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(25)] 
		[RED("leeroy")] 
		public CWeakHandle<inkWidget> Leeroy
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(26)] 
		[RED("timeBank")] 
		public CWeakHandle<inkWidget> TimeBank
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(27)] 
		[RED("berserkEnabledBBId")] 
		public CHandle<redCallbackObject> BerserkEnabledBBId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public HotkeysWidgetController()
		{
			PhoneSlot = new inkCompoundWidgetReference();
			CarSlot = new inkCompoundWidgetReference();
			RadioSlot = new inkCompoundWidgetReference();
			DpadHintsPanel = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
