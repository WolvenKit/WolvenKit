using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimationChainPlayer : IScriptable
	{
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<AnimationChain> _current;
		private CInt32 _current_stage;
		private CHandle<AnimationChain> _next;
		private wCHandle<inkWidgetLogicController> _owner;

		[Ordinal(0)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(1)] 
		[RED("current")] 
		public CHandle<AnimationChain> Current
		{
			get => GetProperty(ref _current);
			set => SetProperty(ref _current, value);
		}

		[Ordinal(2)] 
		[RED("current_stage")] 
		public CInt32 Current_stage
		{
			get => GetProperty(ref _current_stage);
			set => SetProperty(ref _current_stage, value);
		}

		[Ordinal(3)] 
		[RED("next")] 
		public CHandle<AnimationChain> Next
		{
			get => GetProperty(ref _next);
			set => SetProperty(ref _next, value);
		}

		[Ordinal(4)] 
		[RED("owner")] 
		public wCHandle<inkWidgetLogicController> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public AnimationChainPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
