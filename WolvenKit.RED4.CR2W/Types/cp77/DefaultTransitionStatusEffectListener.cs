using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DefaultTransitionStatusEffectListener : gameScriptStatusEffectListener
	{
		private wCHandle<DefaultTransition> _transitionOwner;

		[Ordinal(0)] 
		[RED("transitionOwner")] 
		public wCHandle<DefaultTransition> TransitionOwner
		{
			get => GetProperty(ref _transitionOwner);
			set => SetProperty(ref _transitionOwner, value);
		}

		public DefaultTransitionStatusEffectListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
