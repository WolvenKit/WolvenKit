using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animLookAtPreset_Eyes : animLookAtPreset
	{
		[Ordinal(0)] 
		[RED("softLimitAngle")] 
		public CFloat SoftLimitAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animLookAtPreset_Eyes()
		{
			SoftLimitAngle = 360.000000F;
		}
	}
}
