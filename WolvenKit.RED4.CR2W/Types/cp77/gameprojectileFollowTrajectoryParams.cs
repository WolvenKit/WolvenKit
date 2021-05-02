using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileFollowTrajectoryParams : gameprojectileTrajectoryParams
	{
		private CFloat _startVel;
		private wCHandle<gameObject> _target;
		private wCHandle<entIPlacedComponent> _targetComponent;
		private CFloat _accuracy;
		private Vector4 _targetOffset;

		[Ordinal(0)] 
		[RED("startVel")] 
		public CFloat StartVel
		{
			get => GetProperty(ref _startVel);
			set => SetProperty(ref _startVel, value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("targetComponent")] 
		public wCHandle<entIPlacedComponent> TargetComponent
		{
			get => GetProperty(ref _targetComponent);
			set => SetProperty(ref _targetComponent, value);
		}

		[Ordinal(3)] 
		[RED("accuracy")] 
		public CFloat Accuracy
		{
			get => GetProperty(ref _accuracy);
			set => SetProperty(ref _accuracy, value);
		}

		[Ordinal(4)] 
		[RED("targetOffset")] 
		public Vector4 TargetOffset
		{
			get => GetProperty(ref _targetOffset);
			set => SetProperty(ref _targetOffset, value);
		}

		public gameprojectileFollowTrajectoryParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
