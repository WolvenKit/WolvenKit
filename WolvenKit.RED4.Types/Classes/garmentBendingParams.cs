using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class garmentBendingParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("bendPowerOffsetInCM")] 
		public CFloat BendPowerOffsetInCM
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public garmentBendingParams()
		{
			BendPowerOffsetInCM = 1.000000F;
		}
	}
}
