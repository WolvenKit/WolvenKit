using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LocomotionMachine : animAnimNode_StateMachine
	{
		private CBool _usePlanner;
		private CName _group;
		private CName _logic;
		private CName _requestId;
		private CName _distance;
		private CName _duration;
		private CName _motion;
		private CName _state;
		private CFloat _transitionTime;
		private CUInt32 _numVariants;

		[Ordinal(19)] 
		[RED("usePlanner")] 
		public CBool UsePlanner
		{
			get => GetProperty(ref _usePlanner);
			set => SetProperty(ref _usePlanner, value);
		}

		[Ordinal(20)] 
		[RED("group")] 
		public CName Group
		{
			get => GetProperty(ref _group);
			set => SetProperty(ref _group, value);
		}

		[Ordinal(21)] 
		[RED("logic")] 
		public CName Logic
		{
			get => GetProperty(ref _logic);
			set => SetProperty(ref _logic, value);
		}

		[Ordinal(22)] 
		[RED("requestId")] 
		public CName RequestId
		{
			get => GetProperty(ref _requestId);
			set => SetProperty(ref _requestId, value);
		}

		[Ordinal(23)] 
		[RED("distance")] 
		public CName Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(24)] 
		[RED("duration")] 
		public CName Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(25)] 
		[RED("motion")] 
		public CName Motion
		{
			get => GetProperty(ref _motion);
			set => SetProperty(ref _motion, value);
		}

		[Ordinal(26)] 
		[RED("state")] 
		public CName State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(27)] 
		[RED("transitionTime")] 
		public CFloat TransitionTime
		{
			get => GetProperty(ref _transitionTime);
			set => SetProperty(ref _transitionTime, value);
		}

		[Ordinal(28)] 
		[RED("numVariants")] 
		public CUInt32 NumVariants
		{
			get => GetProperty(ref _numVariants);
			set => SetProperty(ref _numVariants, value);
		}

		public animAnimNode_LocomotionMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
