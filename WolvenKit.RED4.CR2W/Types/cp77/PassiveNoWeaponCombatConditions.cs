using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassiveNoWeaponCombatConditions : PassiveAutonomousCondition
	{
		private CUInt32 _delayEvaluationCbId;
		private CUInt32 _onItemAddedToSlotCbId;

		[Ordinal(0)] 
		[RED("delayEvaluationCbId")] 
		public CUInt32 DelayEvaluationCbId
		{
			get
			{
				if (_delayEvaluationCbId == null)
				{
					_delayEvaluationCbId = (CUInt32) CR2WTypeManager.Create("Uint32", "delayEvaluationCbId", cr2w, this);
				}
				return _delayEvaluationCbId;
			}
			set
			{
				if (_delayEvaluationCbId == value)
				{
					return;
				}
				_delayEvaluationCbId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("onItemAddedToSlotCbId")] 
		public CUInt32 OnItemAddedToSlotCbId
		{
			get
			{
				if (_onItemAddedToSlotCbId == null)
				{
					_onItemAddedToSlotCbId = (CUInt32) CR2WTypeManager.Create("Uint32", "onItemAddedToSlotCbId", cr2w, this);
				}
				return _onItemAddedToSlotCbId;
			}
			set
			{
				if (_onItemAddedToSlotCbId == value)
				{
					return;
				}
				_onItemAddedToSlotCbId = value;
				PropertySet(this);
			}
		}

		public PassiveNoWeaponCombatConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
