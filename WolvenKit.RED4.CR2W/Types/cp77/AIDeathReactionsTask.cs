using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIDeathReactionsTask : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _fastForwardAnimation;
		private CHandle<animAnimFeature_HitReactionsData> _hitData;
		private CHandle<ActionHitReactionScriptProxy> _hitReactionAction;

		[Ordinal(0)] 
		[RED("fastForwardAnimation")] 
		public CHandle<AIArgumentMapping> FastForwardAnimation
		{
			get => GetProperty(ref _fastForwardAnimation);
			set => SetProperty(ref _fastForwardAnimation, value);
		}

		[Ordinal(1)] 
		[RED("hitData")] 
		public CHandle<animAnimFeature_HitReactionsData> HitData
		{
			get => GetProperty(ref _hitData);
			set => SetProperty(ref _hitData, value);
		}

		[Ordinal(2)] 
		[RED("hitReactionAction")] 
		public CHandle<ActionHitReactionScriptProxy> HitReactionAction
		{
			get => GetProperty(ref _hitReactionAction);
			set => SetProperty(ref _hitReactionAction, value);
		}

		public AIDeathReactionsTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
