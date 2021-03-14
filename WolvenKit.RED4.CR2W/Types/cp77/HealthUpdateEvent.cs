using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HealthUpdateEvent : redEvent
	{
		private CFloat _value;
		private CFloat _healthDifference;

		[Ordinal(0)] 
		[RED("value")] 
		public CFloat Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CFloat) CR2WTypeManager.Create("Float", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("healthDifference")] 
		public CFloat HealthDifference
		{
			get
			{
				if (_healthDifference == null)
				{
					_healthDifference = (CFloat) CR2WTypeManager.Create("Float", "healthDifference", cr2w, this);
				}
				return _healthDifference;
			}
			set
			{
				if (_healthDifference == value)
				{
					return;
				}
				_healthDifference = value;
				PropertySet(this);
			}
		}

		public HealthUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
