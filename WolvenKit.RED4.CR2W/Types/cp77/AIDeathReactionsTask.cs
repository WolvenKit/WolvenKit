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
			get
			{
				if (_fastForwardAnimation == null)
				{
					_fastForwardAnimation = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "fastForwardAnimation", cr2w, this);
				}
				return _fastForwardAnimation;
			}
			set
			{
				if (_fastForwardAnimation == value)
				{
					return;
				}
				_fastForwardAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hitData")] 
		public CHandle<animAnimFeature_HitReactionsData> HitData
		{
			get
			{
				if (_hitData == null)
				{
					_hitData = (CHandle<animAnimFeature_HitReactionsData>) CR2WTypeManager.Create("handle:animAnimFeature_HitReactionsData", "hitData", cr2w, this);
				}
				return _hitData;
			}
			set
			{
				if (_hitData == value)
				{
					return;
				}
				_hitData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hitReactionAction")] 
		public CHandle<ActionHitReactionScriptProxy> HitReactionAction
		{
			get
			{
				if (_hitReactionAction == null)
				{
					_hitReactionAction = (CHandle<ActionHitReactionScriptProxy>) CR2WTypeManager.Create("handle:ActionHitReactionScriptProxy", "hitReactionAction", cr2w, this);
				}
				return _hitReactionAction;
			}
			set
			{
				if (_hitReactionAction == value)
				{
					return;
				}
				_hitReactionAction = value;
				PropertySet(this);
			}
		}

		public AIDeathReactionsTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
