using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGrenadeThrowQueryParams : CVariable
	{
		private wCHandle<gameObject> _requester;
		private wCHandle<gameObject> _target;
		private CHandle<entIPositionProvider> _targetPositionProvider;
		private CFloat _minRadius;
		private CFloat _maxRadius;
		private CFloat _friendlyAvoidanceRadius;
		private CFloat _throwAngleDegrees;
		private CFloat _gravitySimulation;
		private CFloat _minTargetAngleDegrees;
		private CFloat _maxTargetAngleDegrees;

		[Ordinal(0)] 
		[RED("requester")] 
		public wCHandle<gameObject> Requester
		{
			get => GetProperty(ref _requester);
			set => SetProperty(ref _requester, value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("targetPositionProvider")] 
		public CHandle<entIPositionProvider> TargetPositionProvider
		{
			get => GetProperty(ref _targetPositionProvider);
			set => SetProperty(ref _targetPositionProvider, value);
		}

		[Ordinal(3)] 
		[RED("minRadius")] 
		public CFloat MinRadius
		{
			get => GetProperty(ref _minRadius);
			set => SetProperty(ref _minRadius, value);
		}

		[Ordinal(4)] 
		[RED("maxRadius")] 
		public CFloat MaxRadius
		{
			get => GetProperty(ref _maxRadius);
			set => SetProperty(ref _maxRadius, value);
		}

		[Ordinal(5)] 
		[RED("friendlyAvoidanceRadius")] 
		public CFloat FriendlyAvoidanceRadius
		{
			get => GetProperty(ref _friendlyAvoidanceRadius);
			set => SetProperty(ref _friendlyAvoidanceRadius, value);
		}

		[Ordinal(6)] 
		[RED("throwAngleDegrees")] 
		public CFloat ThrowAngleDegrees
		{
			get => GetProperty(ref _throwAngleDegrees);
			set => SetProperty(ref _throwAngleDegrees, value);
		}

		[Ordinal(7)] 
		[RED("gravitySimulation")] 
		public CFloat GravitySimulation
		{
			get => GetProperty(ref _gravitySimulation);
			set => SetProperty(ref _gravitySimulation, value);
		}

		[Ordinal(8)] 
		[RED("minTargetAngleDegrees")] 
		public CFloat MinTargetAngleDegrees
		{
			get => GetProperty(ref _minTargetAngleDegrees);
			set => SetProperty(ref _minTargetAngleDegrees, value);
		}

		[Ordinal(9)] 
		[RED("maxTargetAngleDegrees")] 
		public CFloat MaxTargetAngleDegrees
		{
			get => GetProperty(ref _maxTargetAngleDegrees);
			set => SetProperty(ref _maxTargetAngleDegrees, value);
		}

		public gameGrenadeThrowQueryParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
