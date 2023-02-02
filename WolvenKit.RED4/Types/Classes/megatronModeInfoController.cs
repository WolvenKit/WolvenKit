using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class megatronModeInfoController : TriggerModeLogicController
	{
		[Ordinal(1)] 
		[RED("ammoBarVisibility")] 
		public CWeakHandle<inkWidget> AmmoBarVisibility
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(2)] 
		[RED("chargeBarVisibility")] 
		public CWeakHandle<inkWidget> ChargeBarVisibility
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(3)] 
		[RED("fullAutoModeText")] 
		public CWeakHandle<inkWidget> FullAutoModeText
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(4)] 
		[RED("chargeModeText")] 
		public CWeakHandle<inkWidget> ChargeModeText
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(5)] 
		[RED("fullAutoModeBG")] 
		public CWeakHandle<inkWidget> FullAutoModeBG
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(6)] 
		[RED("chargeModeBG")] 
		public CWeakHandle<inkWidget> ChargeModeBG
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(7)] 
		[RED("bg1")] 
		public CWeakHandle<inkWidget> Bg1
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(8)] 
		[RED("bg2")] 
		public CWeakHandle<inkWidget> Bg2
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(9)] 
		[RED("vignette")] 
		public CWeakHandle<inkWidget> Vignette
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public megatronModeInfoController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
