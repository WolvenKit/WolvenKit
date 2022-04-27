
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAccelerateTowardsParameters_Record
	{
		[RED("accelerationSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat AccelerationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("accuracy")]
		[REDProperty(IsIgnored = true)]
		public CFloat Accuracy
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("decelerateTowardsTargetPositionDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat DecelerateTowardsTargetPositionDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("diffForMaxRotation")]
		[REDProperty(IsIgnored = true)]
		public CFloat DiffForMaxRotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxRotationSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxRotationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minRotationSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinRotationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
