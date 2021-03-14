using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SimpleCombatConditon : AIbehaviorconditionScript
	{
		private CBool _firstCoverEvaluationDone;
		private CHandle<gamedataGameplayAbility_Record> _takeCoverAbility;
		private CHandle<gamedataGameplayAbility_Record> _quickhackAbility;

		[Ordinal(0)] 
		[RED("firstCoverEvaluationDone")] 
		public CBool FirstCoverEvaluationDone
		{
			get
			{
				if (_firstCoverEvaluationDone == null)
				{
					_firstCoverEvaluationDone = (CBool) CR2WTypeManager.Create("Bool", "firstCoverEvaluationDone", cr2w, this);
				}
				return _firstCoverEvaluationDone;
			}
			set
			{
				if (_firstCoverEvaluationDone == value)
				{
					return;
				}
				_firstCoverEvaluationDone = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("takeCoverAbility")] 
		public CHandle<gamedataGameplayAbility_Record> TakeCoverAbility
		{
			get
			{
				if (_takeCoverAbility == null)
				{
					_takeCoverAbility = (CHandle<gamedataGameplayAbility_Record>) CR2WTypeManager.Create("handle:gamedataGameplayAbility_Record", "takeCoverAbility", cr2w, this);
				}
				return _takeCoverAbility;
			}
			set
			{
				if (_takeCoverAbility == value)
				{
					return;
				}
				_takeCoverAbility = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("quickhackAbility")] 
		public CHandle<gamedataGameplayAbility_Record> QuickhackAbility
		{
			get
			{
				if (_quickhackAbility == null)
				{
					_quickhackAbility = (CHandle<gamedataGameplayAbility_Record>) CR2WTypeManager.Create("handle:gamedataGameplayAbility_Record", "quickhackAbility", cr2w, this);
				}
				return _quickhackAbility;
			}
			set
			{
				if (_quickhackAbility == value)
				{
					return;
				}
				_quickhackAbility = value;
				PropertySet(this);
			}
		}

		public SimpleCombatConditon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
