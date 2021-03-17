using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_DroneLocomotion : animAnimFeature
	{
		private CFloat _speed;
		private CFloat _angularSpeed;
		private CFloat _lookAtAngle;
		private CFloat _desiredSpeed;
		private CFloat _pathCurvative;

		[Ordinal(0)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(1)] 
		[RED("angularSpeed")] 
		public CFloat AngularSpeed
		{
			get => GetProperty(ref _angularSpeed);
			set => SetProperty(ref _angularSpeed, value);
		}

		[Ordinal(2)] 
		[RED("lookAtAngle")] 
		public CFloat LookAtAngle
		{
			get => GetProperty(ref _lookAtAngle);
			set => SetProperty(ref _lookAtAngle, value);
		}

		[Ordinal(3)] 
		[RED("desiredSpeed")] 
		public CFloat DesiredSpeed
		{
			get => GetProperty(ref _desiredSpeed);
			set => SetProperty(ref _desiredSpeed, value);
		}

		[Ordinal(4)] 
		[RED("pathCurvative")] 
		public CFloat PathCurvative
		{
			get => GetProperty(ref _pathCurvative);
			set => SetProperty(ref _pathCurvative, value);
		}

		public animAnimFeature_DroneLocomotion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
