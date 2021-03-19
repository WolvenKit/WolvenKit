using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JukeboxSetup : CVariable
	{
		private CEnum<ERadioStationList> _startingStation;
		private CName _glitchSFX;
		private TweakDBID _paymentRecordID;

		[Ordinal(0)] 
		[RED("startingStation")] 
		public CEnum<ERadioStationList> StartingStation
		{
			get => GetProperty(ref _startingStation);
			set => SetProperty(ref _startingStation, value);
		}

		[Ordinal(1)] 
		[RED("glitchSFX")] 
		public CName GlitchSFX
		{
			get => GetProperty(ref _glitchSFX);
			set => SetProperty(ref _glitchSFX, value);
		}

		[Ordinal(2)] 
		[RED("paymentRecordID")] 
		public TweakDBID PaymentRecordID
		{
			get => GetProperty(ref _paymentRecordID);
			set => SetProperty(ref _paymentRecordID, value);
		}

		public JukeboxSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
