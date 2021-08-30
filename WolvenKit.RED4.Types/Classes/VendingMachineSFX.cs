using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendingMachineSFX : RedBaseClass
	{
		private CName _glitchingStart;
		private CName _glitchingStop;

		[Ordinal(0)] 
		[RED("glitchingStart")] 
		public CName GlitchingStart
		{
			get => GetProperty(ref _glitchingStart);
			set => SetProperty(ref _glitchingStart, value);
		}

		[Ordinal(1)] 
		[RED("glitchingStop")] 
		public CName GlitchingStop
		{
			get => GetProperty(ref _glitchingStop);
			set => SetProperty(ref _glitchingStop, value);
		}

		public VendingMachineSFX()
		{
			_glitchingStart = "amb_int_custom_megabuilding_01_adverts_interactive_nicola_01_select_q110";
			_glitchingStop = "amb_int_custom_megabuilding_01_adverts_interactive_nicola_01_select_q110_stop";
		}
	}
}
