using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioContextualVoiceGrunt : RedBaseClass
	{
		private CName _regularGrunt;
		private CName _stealthGrunt;

		[Ordinal(0)] 
		[RED("regularGrunt")] 
		public CName RegularGrunt
		{
			get => GetProperty(ref _regularGrunt);
			set => SetProperty(ref _regularGrunt, value);
		}

		[Ordinal(1)] 
		[RED("stealthGrunt")] 
		public CName StealthGrunt
		{
			get => GetProperty(ref _stealthGrunt);
			set => SetProperty(ref _stealthGrunt, value);
		}
	}
}
