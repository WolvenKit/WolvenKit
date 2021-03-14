using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemOutputData : CVariable
	{
		private DeviceLink _link;
		private CEnum<EBreachOrigin> _breachOrigin;
		private CFloat _delayDuration;

		[Ordinal(0)] 
		[RED("link")] 
		public DeviceLink Link
		{
			get
			{
				if (_link == null)
				{
					_link = (DeviceLink) CR2WTypeManager.Create("DeviceLink", "link", cr2w, this);
				}
				return _link;
			}
			set
			{
				if (_link == value)
				{
					return;
				}
				_link = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("breachOrigin")] 
		public CEnum<EBreachOrigin> BreachOrigin
		{
			get
			{
				if (_breachOrigin == null)
				{
					_breachOrigin = (CEnum<EBreachOrigin>) CR2WTypeManager.Create("EBreachOrigin", "breachOrigin", cr2w, this);
				}
				return _breachOrigin;
			}
			set
			{
				if (_breachOrigin == value)
				{
					return;
				}
				_breachOrigin = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("delayDuration")] 
		public CFloat DelayDuration
		{
			get
			{
				if (_delayDuration == null)
				{
					_delayDuration = (CFloat) CR2WTypeManager.Create("Float", "delayDuration", cr2w, this);
				}
				return _delayDuration;
			}
			set
			{
				if (_delayDuration == value)
				{
					return;
				}
				_delayDuration = value;
				PropertySet(this);
			}
		}

		public SecuritySystemOutputData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
