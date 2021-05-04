using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISearchingLookat : AIGenericStaticLookatTask
	{
		private CHandle<AIArgumentMapping> _minAngleDifferenceMapping;
		private CFloat _minAngleDifference;
		private CHandle<AIArgumentMapping> _maxLookAroundAngleMapping;
		private CFloat _maxLookAroundAngle;
		private Vector4 _currentTarget;
		private Vector4 _lastTarget;
		private CFloat _targetSwitchTimeStamp;
		private CFloat _targetSwitchCooldown;
		private CInt32 _sideHorizontal;
		private CInt32 _sideVertical;

		[Ordinal(4)] 
		[RED("minAngleDifferenceMapping")] 
		public CHandle<AIArgumentMapping> MinAngleDifferenceMapping
		{
			get => GetProperty(ref _minAngleDifferenceMapping);
			set => SetProperty(ref _minAngleDifferenceMapping, value);
		}

		[Ordinal(5)] 
		[RED("minAngleDifference")] 
		public CFloat MinAngleDifference
		{
			get => GetProperty(ref _minAngleDifference);
			set => SetProperty(ref _minAngleDifference, value);
		}

		[Ordinal(6)] 
		[RED("maxLookAroundAngleMapping")] 
		public CHandle<AIArgumentMapping> MaxLookAroundAngleMapping
		{
			get => GetProperty(ref _maxLookAroundAngleMapping);
			set => SetProperty(ref _maxLookAroundAngleMapping, value);
		}

		[Ordinal(7)] 
		[RED("maxLookAroundAngle")] 
		public CFloat MaxLookAroundAngle
		{
			get => GetProperty(ref _maxLookAroundAngle);
			set => SetProperty(ref _maxLookAroundAngle, value);
		}

		[Ordinal(8)] 
		[RED("currentTarget")] 
		public Vector4 CurrentTarget
		{
			get => GetProperty(ref _currentTarget);
			set => SetProperty(ref _currentTarget, value);
		}

		[Ordinal(9)] 
		[RED("lastTarget")] 
		public Vector4 LastTarget
		{
			get => GetProperty(ref _lastTarget);
			set => SetProperty(ref _lastTarget, value);
		}

		[Ordinal(10)] 
		[RED("targetSwitchTimeStamp")] 
		public CFloat TargetSwitchTimeStamp
		{
			get => GetProperty(ref _targetSwitchTimeStamp);
			set => SetProperty(ref _targetSwitchTimeStamp, value);
		}

		[Ordinal(11)] 
		[RED("targetSwitchCooldown")] 
		public CFloat TargetSwitchCooldown
		{
			get => GetProperty(ref _targetSwitchCooldown);
			set => SetProperty(ref _targetSwitchCooldown, value);
		}

		[Ordinal(12)] 
		[RED("sideHorizontal")] 
		public CInt32 SideHorizontal
		{
			get => GetProperty(ref _sideHorizontal);
			set => SetProperty(ref _sideHorizontal, value);
		}

		[Ordinal(13)] 
		[RED("sideVertical")] 
		public CInt32 SideVertical
		{
			get => GetProperty(ref _sideVertical);
			set => SetProperty(ref _sideVertical, value);
		}

		public AISearchingLookat(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
