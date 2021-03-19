using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtRequest_ : CVariable
	{
		private CFloat _transitionSpeed;
		private CBool _hasOutTransition;
		private CFloat _outTransitionSpeed;
		private CFloat _followingSpeedFactorOverride;
		private animLookAtLimits _limits;
		private CFloat _suppress;
		private CInt32 _mode;
		private CBool _calculatePositionInParentSpace;
		private CInt32 _priority;
		private CStatic<animLookAtPartRequest> _additionalParts;
		private CBool _invalid;

		[Ordinal(0)] 
		[RED("transitionSpeed")] 
		public CFloat TransitionSpeed
		{
			get => GetProperty(ref _transitionSpeed);
			set => SetProperty(ref _transitionSpeed, value);
		}

		[Ordinal(1)] 
		[RED("hasOutTransition")] 
		public CBool HasOutTransition
		{
			get => GetProperty(ref _hasOutTransition);
			set => SetProperty(ref _hasOutTransition, value);
		}

		[Ordinal(2)] 
		[RED("outTransitionSpeed")] 
		public CFloat OutTransitionSpeed
		{
			get => GetProperty(ref _outTransitionSpeed);
			set => SetProperty(ref _outTransitionSpeed, value);
		}

		[Ordinal(3)] 
		[RED("followingSpeedFactorOverride")] 
		public CFloat FollowingSpeedFactorOverride
		{
			get => GetProperty(ref _followingSpeedFactorOverride);
			set => SetProperty(ref _followingSpeedFactorOverride, value);
		}

		[Ordinal(4)] 
		[RED("limits")] 
		public animLookAtLimits Limits
		{
			get => GetProperty(ref _limits);
			set => SetProperty(ref _limits, value);
		}

		[Ordinal(5)] 
		[RED("suppress")] 
		public CFloat Suppress
		{
			get => GetProperty(ref _suppress);
			set => SetProperty(ref _suppress, value);
		}

		[Ordinal(6)] 
		[RED("mode")] 
		public CInt32 Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(7)] 
		[RED("calculatePositionInParentSpace")] 
		public CBool CalculatePositionInParentSpace
		{
			get => GetProperty(ref _calculatePositionInParentSpace);
			set => SetProperty(ref _calculatePositionInParentSpace, value);
		}

		[Ordinal(8)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(9)] 
		[RED("additionalParts", 2)] 
		public CStatic<animLookAtPartRequest> AdditionalParts
		{
			get => GetProperty(ref _additionalParts);
			set => SetProperty(ref _additionalParts, value);
		}

		[Ordinal(10)] 
		[RED("invalid")] 
		public CBool Invalid
		{
			get => GetProperty(ref _invalid);
			set => SetProperty(ref _invalid, value);
		}

		public animLookAtRequest_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
