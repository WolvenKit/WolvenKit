using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficLaneExitDefinition : RedBaseClass
	{
		private NodeRef _outLaneRef;
		private Vector4 _exitPosition;
		private CFloat _exitProbability;
		private CBool _endConnection;
		private CBool _thisLaneReversed;
		private CBool _outLaneReversed;

		[Ordinal(0)] 
		[RED("outLaneRef")] 
		public NodeRef OutLaneRef
		{
			get => GetProperty(ref _outLaneRef);
			set => SetProperty(ref _outLaneRef, value);
		}

		[Ordinal(1)] 
		[RED("exitPosition")] 
		public Vector4 ExitPosition
		{
			get => GetProperty(ref _exitPosition);
			set => SetProperty(ref _exitPosition, value);
		}

		[Ordinal(2)] 
		[RED("exitProbability")] 
		public CFloat ExitProbability
		{
			get => GetProperty(ref _exitProbability);
			set => SetProperty(ref _exitProbability, value);
		}

		[Ordinal(3)] 
		[RED("endConnection")] 
		public CBool EndConnection
		{
			get => GetProperty(ref _endConnection);
			set => SetProperty(ref _endConnection, value);
		}

		[Ordinal(4)] 
		[RED("thisLaneReversed")] 
		public CBool ThisLaneReversed
		{
			get => GetProperty(ref _thisLaneReversed);
			set => SetProperty(ref _thisLaneReversed, value);
		}

		[Ordinal(5)] 
		[RED("outLaneReversed")] 
		public CBool OutLaneReversed
		{
			get => GetProperty(ref _outLaneReversed);
			set => SetProperty(ref _outLaneReversed, value);
		}
	}
}
