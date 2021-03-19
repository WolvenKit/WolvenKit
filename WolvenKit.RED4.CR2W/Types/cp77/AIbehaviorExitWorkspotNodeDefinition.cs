using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorExitWorkspotNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CHandle<AIArgumentMapping> _skipExitAnimation;
		private CHandle<AIArgumentMapping> _useSlowExitAnimation;
		private CHandle<AIArgumentMapping> _doSlowIfFastExitFails;
		private CHandle<AIArgumentMapping> _stayInWorkspotIfExitFails;
		private CHandle<AIArgumentMapping> _tryBlendFastExitToWalk;
		private CHandle<AIArgumentMapping> _dontRequestExit;
		private CHandle<AIArgumentMapping> _target;

		[Ordinal(1)] 
		[RED("skipExitAnimation")] 
		public CHandle<AIArgumentMapping> SkipExitAnimation
		{
			get => GetProperty(ref _skipExitAnimation);
			set => SetProperty(ref _skipExitAnimation, value);
		}

		[Ordinal(2)] 
		[RED("useSlowExitAnimation")] 
		public CHandle<AIArgumentMapping> UseSlowExitAnimation
		{
			get => GetProperty(ref _useSlowExitAnimation);
			set => SetProperty(ref _useSlowExitAnimation, value);
		}

		[Ordinal(3)] 
		[RED("doSlowIfFastExitFails")] 
		public CHandle<AIArgumentMapping> DoSlowIfFastExitFails
		{
			get => GetProperty(ref _doSlowIfFastExitFails);
			set => SetProperty(ref _doSlowIfFastExitFails, value);
		}

		[Ordinal(4)] 
		[RED("stayInWorkspotIfExitFails")] 
		public CHandle<AIArgumentMapping> StayInWorkspotIfExitFails
		{
			get => GetProperty(ref _stayInWorkspotIfExitFails);
			set => SetProperty(ref _stayInWorkspotIfExitFails, value);
		}

		[Ordinal(5)] 
		[RED("tryBlendFastExitToWalk")] 
		public CHandle<AIArgumentMapping> TryBlendFastExitToWalk
		{
			get => GetProperty(ref _tryBlendFastExitToWalk);
			set => SetProperty(ref _tryBlendFastExitToWalk, value);
		}

		[Ordinal(6)] 
		[RED("dontRequestExit")] 
		public CHandle<AIArgumentMapping> DontRequestExit
		{
			get => GetProperty(ref _dontRequestExit);
			set => SetProperty(ref _dontRequestExit, value);
		}

		[Ordinal(7)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		public AIbehaviorExitWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
