using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SelectorRevalutionBreak : AIbehaviortaskScript
	{
		private CFloat _reevaluationDuration;
		private CFloat _activationTimeStamp;

		[Ordinal(0)] 
		[RED("reevaluationDuration")] 
		public CFloat ReevaluationDuration
		{
			get
			{
				if (_reevaluationDuration == null)
				{
					_reevaluationDuration = (CFloat) CR2WTypeManager.Create("Float", "reevaluationDuration", cr2w, this);
				}
				return _reevaluationDuration;
			}
			set
			{
				if (_reevaluationDuration == value)
				{
					return;
				}
				_reevaluationDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get
			{
				if (_activationTimeStamp == null)
				{
					_activationTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "activationTimeStamp", cr2w, this);
				}
				return _activationTimeStamp;
			}
			set
			{
				if (_activationTimeStamp == value)
				{
					return;
				}
				_activationTimeStamp = value;
				PropertySet(this);
			}
		}

		public SelectorRevalutionBreak(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
