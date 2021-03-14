using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestUIRefreshEvent : redEvent
	{
		private gamePersistentID _requester;
		private CName _context;

		[Ordinal(0)] 
		[RED("requester")] 
		public gamePersistentID Requester
		{
			get
			{
				if (_requester == null)
				{
					_requester = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "requester", cr2w, this);
				}
				return _requester;
			}
			set
			{
				if (_requester == value)
				{
					return;
				}
				_requester = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("context")] 
		public CName Context
		{
			get
			{
				if (_context == null)
				{
					_context = (CName) CR2WTypeManager.Create("CName", "context", cr2w, this);
				}
				return _context;
			}
			set
			{
				if (_context == value)
				{
					return;
				}
				_context = value;
				PropertySet(this);
			}
		}

		public RequestUIRefreshEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
