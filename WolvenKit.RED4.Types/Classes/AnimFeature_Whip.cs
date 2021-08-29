using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_Whip : animAnimFeature
	{
		private CInt32 _state;
		private CInt32 _pullState;
		private Vector4 _targetPoint;

		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("pullState")] 
		public CInt32 PullState
		{
			get => GetProperty(ref _pullState);
			set => SetProperty(ref _pullState, value);
		}

		[Ordinal(2)] 
		[RED("targetPoint")] 
		public Vector4 TargetPoint
		{
			get => GetProperty(ref _targetPoint);
			set => SetProperty(ref _targetPoint, value);
		}
	}
}
