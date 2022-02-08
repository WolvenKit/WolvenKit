using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectProvider_SweepOverTime_Capsule : gameEffectObjectProvider_SweepOverTime
	{
		[Ordinal(1)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
