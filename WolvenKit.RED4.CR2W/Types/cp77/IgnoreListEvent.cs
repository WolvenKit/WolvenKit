using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IgnoreListEvent : redEvent
	{
		private entEntityID _bodyID;
		private CBool _removeEvent;

		[Ordinal(0)] 
		[RED("bodyID")] 
		public entEntityID BodyID
		{
			get
			{
				if (_bodyID == null)
				{
					_bodyID = (entEntityID) CR2WTypeManager.Create("entEntityID", "bodyID", cr2w, this);
				}
				return _bodyID;
			}
			set
			{
				if (_bodyID == value)
				{
					return;
				}
				_bodyID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("removeEvent")] 
		public CBool RemoveEvent
		{
			get
			{
				if (_removeEvent == null)
				{
					_removeEvent = (CBool) CR2WTypeManager.Create("Bool", "removeEvent", cr2w, this);
				}
				return _removeEvent;
			}
			set
			{
				if (_removeEvent == value)
				{
					return;
				}
				_removeEvent = value;
				PropertySet(this);
			}
		}

		public IgnoreListEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
