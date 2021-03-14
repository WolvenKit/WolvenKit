using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIThreatCalculationEvent : redEvent
	{
		private CBool _set;
		private CEnum<EAIThreatCalculationType> _temporaryThreatCalculationType;

		[Ordinal(0)] 
		[RED("set")] 
		public CBool Set
		{
			get
			{
				if (_set == null)
				{
					_set = (CBool) CR2WTypeManager.Create("Bool", "set", cr2w, this);
				}
				return _set;
			}
			set
			{
				if (_set == value)
				{
					return;
				}
				_set = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("temporaryThreatCalculationType")] 
		public CEnum<EAIThreatCalculationType> TemporaryThreatCalculationType
		{
			get
			{
				if (_temporaryThreatCalculationType == null)
				{
					_temporaryThreatCalculationType = (CEnum<EAIThreatCalculationType>) CR2WTypeManager.Create("EAIThreatCalculationType", "temporaryThreatCalculationType", cr2w, this);
				}
				return _temporaryThreatCalculationType;
			}
			set
			{
				if (_temporaryThreatCalculationType == value)
				{
					return;
				}
				_temporaryThreatCalculationType = value;
				PropertySet(this);
			}
		}

		public AIThreatCalculationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
