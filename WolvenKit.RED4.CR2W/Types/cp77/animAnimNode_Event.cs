using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Event : animAnimNode_FloatValue
	{
		private CName _eventName;
		private CFloat _defaultValue;
		private CFloat _eventValue;

		[Ordinal(11)] 
		[RED("eventName")] 
		public CName EventName
		{
			get
			{
				if (_eventName == null)
				{
					_eventName = (CName) CR2WTypeManager.Create("CName", "eventName", cr2w, this);
				}
				return _eventName;
			}
			set
			{
				if (_eventName == value)
				{
					return;
				}
				_eventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get
			{
				if (_defaultValue == null)
				{
					_defaultValue = (CFloat) CR2WTypeManager.Create("Float", "defaultValue", cr2w, this);
				}
				return _defaultValue;
			}
			set
			{
				if (_defaultValue == value)
				{
					return;
				}
				_defaultValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("eventValue")] 
		public CFloat EventValue
		{
			get
			{
				if (_eventValue == null)
				{
					_eventValue = (CFloat) CR2WTypeManager.Create("Float", "eventValue", cr2w, this);
				}
				return _eventValue;
			}
			set
			{
				if (_eventValue == value)
				{
					return;
				}
				_eventValue = value;
				PropertySet(this);
			}
		}

		public animAnimNode_Event(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
