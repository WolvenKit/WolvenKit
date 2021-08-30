using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class garmentBendingParams : RedBaseClass
	{
		private CFloat _bendPowerOffsetInCM;

		[Ordinal(0)] 
		[RED("bendPowerOffsetInCM")] 
		public CFloat BendPowerOffsetInCM
		{
			get => GetProperty(ref _bendPowerOffsetInCM);
			set => SetProperty(ref _bendPowerOffsetInCM, value);
		}

		public garmentBendingParams()
		{
			_bendPowerOffsetInCM = 1.000000F;
		}
	}
}
