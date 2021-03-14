using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CommunicationEvent : redEvent
	{
		private CName _name;
		private entEntityID _sender;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sender")] 
		public entEntityID Sender
		{
			get
			{
				if (_sender == null)
				{
					_sender = (entEntityID) CR2WTypeManager.Create("entEntityID", "sender", cr2w, this);
				}
				return _sender;
			}
			set
			{
				if (_sender == value)
				{
					return;
				}
				_sender = value;
				PropertySet(this);
			}
		}

		public CommunicationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
