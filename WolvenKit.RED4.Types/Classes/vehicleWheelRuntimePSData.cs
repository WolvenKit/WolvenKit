using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleWheelRuntimePSData : RedBaseClass
	{
		private CName _previousTouchedMaterial;
		private CFloat _previousVisualDisplacement;
		private CFloat _previousLogicalSpringCompression;
		private CFloat _previousSwaybarDisplacement;
		private CFloat _previousDampedSpringForce;

		[Ordinal(0)] 
		[RED("previousTouchedMaterial")] 
		public CName PreviousTouchedMaterial
		{
			get => GetProperty(ref _previousTouchedMaterial);
			set => SetProperty(ref _previousTouchedMaterial, value);
		}

		[Ordinal(1)] 
		[RED("previousVisualDisplacement")] 
		public CFloat PreviousVisualDisplacement
		{
			get => GetProperty(ref _previousVisualDisplacement);
			set => SetProperty(ref _previousVisualDisplacement, value);
		}

		[Ordinal(2)] 
		[RED("previousLogicalSpringCompression")] 
		public CFloat PreviousLogicalSpringCompression
		{
			get => GetProperty(ref _previousLogicalSpringCompression);
			set => SetProperty(ref _previousLogicalSpringCompression, value);
		}

		[Ordinal(3)] 
		[RED("previousSwaybarDisplacement")] 
		public CFloat PreviousSwaybarDisplacement
		{
			get => GetProperty(ref _previousSwaybarDisplacement);
			set => SetProperty(ref _previousSwaybarDisplacement, value);
		}

		[Ordinal(4)] 
		[RED("previousDampedSpringForce")] 
		public CFloat PreviousDampedSpringForce
		{
			get => GetProperty(ref _previousDampedSpringForce);
			set => SetProperty(ref _previousDampedSpringForce, value);
		}
	}
}
