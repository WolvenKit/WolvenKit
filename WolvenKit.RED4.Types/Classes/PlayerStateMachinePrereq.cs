using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerStateMachinePrereq : gameIScriptablePrereq
	{
		private CBool _previousState;
		private CBool _isInState;
		private CBool _skipWhenApplied;
		private CInt32 _valueToListen;

		[Ordinal(0)] 
		[RED("previousState")] 
		public CBool PreviousState
		{
			get => GetProperty(ref _previousState);
			set => SetProperty(ref _previousState, value);
		}

		[Ordinal(1)] 
		[RED("isInState")] 
		public CBool IsInState
		{
			get => GetProperty(ref _isInState);
			set => SetProperty(ref _isInState, value);
		}

		[Ordinal(2)] 
		[RED("skipWhenApplied")] 
		public CBool SkipWhenApplied
		{
			get => GetProperty(ref _skipWhenApplied);
			set => SetProperty(ref _skipWhenApplied, value);
		}

		[Ordinal(3)] 
		[RED("valueToListen")] 
		public CInt32 ValueToListen
		{
			get => GetProperty(ref _valueToListen);
			set => SetProperty(ref _valueToListen, value);
		}
	}
}
