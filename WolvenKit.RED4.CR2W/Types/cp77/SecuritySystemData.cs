using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemData : CVariable
	{
		private CBool _suppressIncomingEvents;
		private CBool _suppressOutgoingEvents;

		[Ordinal(0)] 
		[RED("suppressIncomingEvents")] 
		public CBool SuppressIncomingEvents
		{
			get
			{
				if (_suppressIncomingEvents == null)
				{
					_suppressIncomingEvents = (CBool) CR2WTypeManager.Create("Bool", "suppressIncomingEvents", cr2w, this);
				}
				return _suppressIncomingEvents;
			}
			set
			{
				if (_suppressIncomingEvents == value)
				{
					return;
				}
				_suppressIncomingEvents = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("suppressOutgoingEvents")] 
		public CBool SuppressOutgoingEvents
		{
			get
			{
				if (_suppressOutgoingEvents == null)
				{
					_suppressOutgoingEvents = (CBool) CR2WTypeManager.Create("Bool", "suppressOutgoingEvents", cr2w, this);
				}
				return _suppressOutgoingEvents;
			}
			set
			{
				if (_suppressOutgoingEvents == value)
				{
					return;
				}
				_suppressOutgoingEvents = value;
				PropertySet(this);
			}
		}

		public SecuritySystemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
