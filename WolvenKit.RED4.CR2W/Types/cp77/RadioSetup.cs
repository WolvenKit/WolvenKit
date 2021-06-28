using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioSetup : CVariable
	{
		private CEnum<ERadioStationList> _startingStation;
		private CBool _isInteractive;
		private CName _glitchSFX;

		[Ordinal(0)] 
		[RED("startingStation")] 
		public CEnum<ERadioStationList> StartingStation
		{
			get => GetProperty(ref _startingStation);
			set => SetProperty(ref _startingStation, value);
		}

		[Ordinal(1)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetProperty(ref _isInteractive);
			set => SetProperty(ref _isInteractive, value);
		}

		[Ordinal(2)] 
		[RED("glitchSFX")] 
		public CName GlitchSFX
		{
			get => GetProperty(ref _glitchSFX);
			set => SetProperty(ref _glitchSFX, value);
		}

		public RadioSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
