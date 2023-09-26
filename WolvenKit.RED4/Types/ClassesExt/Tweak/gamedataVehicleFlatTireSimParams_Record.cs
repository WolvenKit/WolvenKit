
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleFlatTireSimParams_Record
	{
		[RED("blowOutImpulse")]
		[REDProperty(IsIgnored = true)]
		public CFloat BlowOutImpulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lateralFrictionDecimation")]
		[REDProperty(IsIgnored = true)]
		public CFloat LateralFrictionDecimation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("longitudinalFrictionDecimation")]
		[REDProperty(IsIgnored = true)]
		public CFloat LongitudinalFrictionDecimation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rotationResistanceTorque")]
		[REDProperty(IsIgnored = true)]
		public CFloat RotationResistanceTorque
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
