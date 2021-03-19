using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleWheelRuntimePSData : CVariable
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

		public vehicleWheelRuntimePSData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
