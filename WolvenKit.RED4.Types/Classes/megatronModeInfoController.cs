using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class megatronModeInfoController : TriggerModeLogicController
	{
		private CWeakHandle<inkWidget> _ammoBarVisibility;
		private CWeakHandle<inkWidget> _chargeBarVisibility;
		private CWeakHandle<inkWidget> _fullAutoModeText;
		private CWeakHandle<inkWidget> _chargeModeText;
		private CWeakHandle<inkWidget> _fullAutoModeBG;
		private CWeakHandle<inkWidget> _chargeModeBG;
		private CWeakHandle<inkWidget> _bg1;
		private CWeakHandle<inkWidget> _bg2;
		private CWeakHandle<inkWidget> _vignette;

		[Ordinal(1)] 
		[RED("ammoBarVisibility")] 
		public CWeakHandle<inkWidget> AmmoBarVisibility
		{
			get => GetProperty(ref _ammoBarVisibility);
			set => SetProperty(ref _ammoBarVisibility, value);
		}

		[Ordinal(2)] 
		[RED("chargeBarVisibility")] 
		public CWeakHandle<inkWidget> ChargeBarVisibility
		{
			get => GetProperty(ref _chargeBarVisibility);
			set => SetProperty(ref _chargeBarVisibility, value);
		}

		[Ordinal(3)] 
		[RED("fullAutoModeText")] 
		public CWeakHandle<inkWidget> FullAutoModeText
		{
			get => GetProperty(ref _fullAutoModeText);
			set => SetProperty(ref _fullAutoModeText, value);
		}

		[Ordinal(4)] 
		[RED("chargeModeText")] 
		public CWeakHandle<inkWidget> ChargeModeText
		{
			get => GetProperty(ref _chargeModeText);
			set => SetProperty(ref _chargeModeText, value);
		}

		[Ordinal(5)] 
		[RED("fullAutoModeBG")] 
		public CWeakHandle<inkWidget> FullAutoModeBG
		{
			get => GetProperty(ref _fullAutoModeBG);
			set => SetProperty(ref _fullAutoModeBG, value);
		}

		[Ordinal(6)] 
		[RED("chargeModeBG")] 
		public CWeakHandle<inkWidget> ChargeModeBG
		{
			get => GetProperty(ref _chargeModeBG);
			set => SetProperty(ref _chargeModeBG, value);
		}

		[Ordinal(7)] 
		[RED("bg1")] 
		public CWeakHandle<inkWidget> Bg1
		{
			get => GetProperty(ref _bg1);
			set => SetProperty(ref _bg1, value);
		}

		[Ordinal(8)] 
		[RED("bg2")] 
		public CWeakHandle<inkWidget> Bg2
		{
			get => GetProperty(ref _bg2);
			set => SetProperty(ref _bg2, value);
		}

		[Ordinal(9)] 
		[RED("vignette")] 
		public CWeakHandle<inkWidget> Vignette
		{
			get => GetProperty(ref _vignette);
			set => SetProperty(ref _vignette, value);
		}
	}
}
