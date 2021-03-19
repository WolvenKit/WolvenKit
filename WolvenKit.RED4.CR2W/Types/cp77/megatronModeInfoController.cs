using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class megatronModeInfoController : TriggerModeLogicController
	{
		private wCHandle<inkWidget> _ammoBarVisibility;
		private wCHandle<inkWidget> _chargeBarVisibility;
		private wCHandle<inkWidget> _fullAutoModeText;
		private wCHandle<inkWidget> _chargeModeText;
		private wCHandle<inkWidget> _fullAutoModeBG;
		private wCHandle<inkWidget> _chargeModeBG;
		private wCHandle<inkWidget> _bg1;
		private wCHandle<inkWidget> _bg2;
		private wCHandle<inkWidget> _vignette;

		[Ordinal(1)] 
		[RED("ammoBarVisibility")] 
		public wCHandle<inkWidget> AmmoBarVisibility
		{
			get => GetProperty(ref _ammoBarVisibility);
			set => SetProperty(ref _ammoBarVisibility, value);
		}

		[Ordinal(2)] 
		[RED("chargeBarVisibility")] 
		public wCHandle<inkWidget> ChargeBarVisibility
		{
			get => GetProperty(ref _chargeBarVisibility);
			set => SetProperty(ref _chargeBarVisibility, value);
		}

		[Ordinal(3)] 
		[RED("fullAutoModeText")] 
		public wCHandle<inkWidget> FullAutoModeText
		{
			get => GetProperty(ref _fullAutoModeText);
			set => SetProperty(ref _fullAutoModeText, value);
		}

		[Ordinal(4)] 
		[RED("chargeModeText")] 
		public wCHandle<inkWidget> ChargeModeText
		{
			get => GetProperty(ref _chargeModeText);
			set => SetProperty(ref _chargeModeText, value);
		}

		[Ordinal(5)] 
		[RED("fullAutoModeBG")] 
		public wCHandle<inkWidget> FullAutoModeBG
		{
			get => GetProperty(ref _fullAutoModeBG);
			set => SetProperty(ref _fullAutoModeBG, value);
		}

		[Ordinal(6)] 
		[RED("chargeModeBG")] 
		public wCHandle<inkWidget> ChargeModeBG
		{
			get => GetProperty(ref _chargeModeBG);
			set => SetProperty(ref _chargeModeBG, value);
		}

		[Ordinal(7)] 
		[RED("bg1")] 
		public wCHandle<inkWidget> Bg1
		{
			get => GetProperty(ref _bg1);
			set => SetProperty(ref _bg1, value);
		}

		[Ordinal(8)] 
		[RED("bg2")] 
		public wCHandle<inkWidget> Bg2
		{
			get => GetProperty(ref _bg2);
			set => SetProperty(ref _bg2, value);
		}

		[Ordinal(9)] 
		[RED("vignette")] 
		public wCHandle<inkWidget> Vignette
		{
			get => GetProperty(ref _vignette);
			set => SetProperty(ref _vignette, value);
		}

		public megatronModeInfoController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
