using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassiveCoverSelectionConditions : PassiveAutonomousCondition
	{
		private CUInt32 _statsChangedCbId;
		private wCHandle<gamedataGameplayAbility_Record> _ability;
		private CHandle<AIStatListener> _statListener;

		[Ordinal(0)] 
		[RED("statsChangedCbId")] 
		public CUInt32 StatsChangedCbId
		{
			get
			{
				if (_statsChangedCbId == null)
				{
					_statsChangedCbId = (CUInt32) CR2WTypeManager.Create("Uint32", "statsChangedCbId", cr2w, this);
				}
				return _statsChangedCbId;
			}
			set
			{
				if (_statsChangedCbId == value)
				{
					return;
				}
				_statsChangedCbId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ability")] 
		public wCHandle<gamedataGameplayAbility_Record> Ability
		{
			get
			{
				if (_ability == null)
				{
					_ability = (wCHandle<gamedataGameplayAbility_Record>) CR2WTypeManager.Create("whandle:gamedataGameplayAbility_Record", "ability", cr2w, this);
				}
				return _ability;
			}
			set
			{
				if (_ability == value)
				{
					return;
				}
				_ability = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("statListener")] 
		public CHandle<AIStatListener> StatListener
		{
			get
			{
				if (_statListener == null)
				{
					_statListener = (CHandle<AIStatListener>) CR2WTypeManager.Create("handle:AIStatListener", "statListener", cr2w, this);
				}
				return _statListener;
			}
			set
			{
				if (_statListener == value)
				{
					return;
				}
				_statListener = value;
				PropertySet(this);
			}
		}

		public PassiveCoverSelectionConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
