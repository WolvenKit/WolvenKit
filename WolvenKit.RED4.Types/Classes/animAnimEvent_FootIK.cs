using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimEvent_FootIK : animAnimEvent
	{
		private CEnum<animLeg> _leg;

		[Ordinal(3)] 
		[RED("leg")] 
		public CEnum<animLeg> Leg
		{
			get => GetProperty(ref _leg);
			set => SetProperty(ref _leg, value);
		}
	}
}
