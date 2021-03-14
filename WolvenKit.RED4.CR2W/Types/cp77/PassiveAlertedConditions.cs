using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassiveAlertedConditions : PassiveAutonomousCondition
	{
		private CUInt32 _highLevelCbId;
		private CUInt32 _delayEvaluationCbId;

		[Ordinal(0)] 
		[RED("highLevelCbId")] 
		public CUInt32 HighLevelCbId
		{
			get
			{
				if (_highLevelCbId == null)
				{
					_highLevelCbId = (CUInt32) CR2WTypeManager.Create("Uint32", "highLevelCbId", cr2w, this);
				}
				return _highLevelCbId;
			}
			set
			{
				if (_highLevelCbId == value)
				{
					return;
				}
				_highLevelCbId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public PassiveAlertedConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
