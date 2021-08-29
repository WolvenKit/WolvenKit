using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SkAnimAdjuster : animAnimNode_SkAnim
	{
		private animVectorLink _targetPositionWs;
		private animVectorLink _targetDirectionWs;
		private Vector4 _initialForwardVector;
		private CName _startAdjustmentEventName;
		private CName _endAdjustmentEventName;

		[Ordinal(30)] 
		[RED("targetPositionWs")] 
		public animVectorLink TargetPositionWs
		{
			get => GetProperty(ref _targetPositionWs);
			set => SetProperty(ref _targetPositionWs, value);
		}

		[Ordinal(31)] 
		[RED("targetDirectionWs")] 
		public animVectorLink TargetDirectionWs
		{
			get => GetProperty(ref _targetDirectionWs);
			set => SetProperty(ref _targetDirectionWs, value);
		}

		[Ordinal(32)] 
		[RED("initialForwardVector")] 
		public Vector4 InitialForwardVector
		{
			get => GetProperty(ref _initialForwardVector);
			set => SetProperty(ref _initialForwardVector, value);
		}

		[Ordinal(33)] 
		[RED("startAdjustmentEventName")] 
		public CName StartAdjustmentEventName
		{
			get => GetProperty(ref _startAdjustmentEventName);
			set => SetProperty(ref _startAdjustmentEventName, value);
		}

		[Ordinal(34)] 
		[RED("endAdjustmentEventName")] 
		public CName EndAdjustmentEventName
		{
			get => GetProperty(ref _endAdjustmentEventName);
			set => SetProperty(ref _endAdjustmentEventName, value);
		}
	}
}
