using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	[REDClass(SerializeDefault = true)]
	public partial class EulerAngles : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Pitch")] 
		public CFloat Pitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("Yaw")] 
		public CFloat Yaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("Roll")] 
		public CFloat Roll
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
