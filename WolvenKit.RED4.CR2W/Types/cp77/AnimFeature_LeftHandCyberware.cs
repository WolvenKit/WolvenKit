using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_LeftHandCyberware : animAnimFeature
	{
		private CFloat _actionDuration;
		private CInt32 _state;
		private CBool _isQuickAction;
		private CBool _isChargeAction;
		private CBool _isLoopAction;
		private CBool _isCatchAction;
		private CBool _isSafeAction;

		[Ordinal(0)] 
		[RED("actionDuration")] 
		public CFloat ActionDuration
		{
			get => GetProperty(ref _actionDuration);
			set => SetProperty(ref _actionDuration, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(2)] 
		[RED("isQuickAction")] 
		public CBool IsQuickAction
		{
			get => GetProperty(ref _isQuickAction);
			set => SetProperty(ref _isQuickAction, value);
		}

		[Ordinal(3)] 
		[RED("isChargeAction")] 
		public CBool IsChargeAction
		{
			get => GetProperty(ref _isChargeAction);
			set => SetProperty(ref _isChargeAction, value);
		}

		[Ordinal(4)] 
		[RED("isLoopAction")] 
		public CBool IsLoopAction
		{
			get => GetProperty(ref _isLoopAction);
			set => SetProperty(ref _isLoopAction, value);
		}

		[Ordinal(5)] 
		[RED("isCatchAction")] 
		public CBool IsCatchAction
		{
			get => GetProperty(ref _isCatchAction);
			set => SetProperty(ref _isCatchAction, value);
		}

		[Ordinal(6)] 
		[RED("isSafeAction")] 
		public CBool IsSafeAction
		{
			get => GetProperty(ref _isSafeAction);
			set => SetProperty(ref _isSafeAction, value);
		}

		public AnimFeature_LeftHandCyberware(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
