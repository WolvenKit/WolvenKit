using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class KeyBindings : RedBaseClass
	{
		private TweakDBID _dPAD_UP;
		private TweakDBID _rB;

		[Ordinal(0)] 
		[RED("DPAD_UP")] 
		public TweakDBID DPAD_UP
		{
			get => GetProperty(ref _dPAD_UP);
			set => SetProperty(ref _dPAD_UP, value);
		}

		[Ordinal(1)] 
		[RED("RB")] 
		public TweakDBID RB
		{
			get => GetProperty(ref _rB);
			set => SetProperty(ref _rB, value);
		}
	}
}
