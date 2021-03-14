using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MappingTimeout : AITimeoutCondition
	{
		private CHandle<AIArgumentMapping> _timeoutMapping;
		private CFloat _timeoutValue;

		[Ordinal(1)] 
		[RED("timeoutMapping")] 
		public CHandle<AIArgumentMapping> TimeoutMapping
		{
			get
			{
				if (_timeoutMapping == null)
				{
					_timeoutMapping = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "timeoutMapping", cr2w, this);
				}
				return _timeoutMapping;
			}
			set
			{
				if (_timeoutMapping == value)
				{
					return;
				}
				_timeoutMapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("timeoutValue")] 
		public CFloat TimeoutValue
		{
			get
			{
				if (_timeoutValue == null)
				{
					_timeoutValue = (CFloat) CR2WTypeManager.Create("Float", "timeoutValue", cr2w, this);
				}
				return _timeoutValue;
			}
			set
			{
				if (_timeoutValue == value)
				{
					return;
				}
				_timeoutValue = value;
				PropertySet(this);
			}
		}

		public MappingTimeout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
