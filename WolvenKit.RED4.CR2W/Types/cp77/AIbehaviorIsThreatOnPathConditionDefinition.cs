using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorIsThreatOnPathConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIArgumentMapping> _threatObject;
		private CHandle<AIArgumentMapping> _threatRadius;

		[Ordinal(1)] 
		[RED("threatObject")] 
		public CHandle<AIArgumentMapping> ThreatObject
		{
			get
			{
				if (_threatObject == null)
				{
					_threatObject = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "threatObject", cr2w, this);
				}
				return _threatObject;
			}
			set
			{
				if (_threatObject == value)
				{
					return;
				}
				_threatObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("threatRadius")] 
		public CHandle<AIArgumentMapping> ThreatRadius
		{
			get
			{
				if (_threatRadius == null)
				{
					_threatRadius = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "threatRadius", cr2w, this);
				}
				return _threatRadius;
			}
			set
			{
				if (_threatRadius == value)
				{
					return;
				}
				_threatRadius = value;
				PropertySet(this);
			}
		}

		public AIbehaviorIsThreatOnPathConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
