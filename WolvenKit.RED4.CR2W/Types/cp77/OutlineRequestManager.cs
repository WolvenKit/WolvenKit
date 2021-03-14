using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OutlineRequestManager : IScriptable
	{
		private CArray<CHandle<OutlineRequest>> _requestsList;
		private wCHandle<gameObject> _owner;
		private CBool _isBlocked;
		private CArray<CHandle<OutlineRequest>> _dbgRequests;

		[Ordinal(0)] 
		[RED("requestsList")] 
		public CArray<CHandle<OutlineRequest>> RequestsList
		{
			get
			{
				if (_requestsList == null)
				{
					_requestsList = (CArray<CHandle<OutlineRequest>>) CR2WTypeManager.Create("array:handle:OutlineRequest", "requestsList", cr2w, this);
				}
				return _requestsList;
			}
			set
			{
				if (_requestsList == value)
				{
					return;
				}
				_requestsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isBlocked")] 
		public CBool IsBlocked
		{
			get
			{
				if (_isBlocked == null)
				{
					_isBlocked = (CBool) CR2WTypeManager.Create("Bool", "isBlocked", cr2w, this);
				}
				return _isBlocked;
			}
			set
			{
				if (_isBlocked == value)
				{
					return;
				}
				_isBlocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("dbgRequests")] 
		public CArray<CHandle<OutlineRequest>> DbgRequests
		{
			get
			{
				if (_dbgRequests == null)
				{
					_dbgRequests = (CArray<CHandle<OutlineRequest>>) CR2WTypeManager.Create("array:handle:OutlineRequest", "dbgRequests", cr2w, this);
				}
				return _dbgRequests;
			}
			set
			{
				if (_dbgRequests == value)
				{
					return;
				}
				_dbgRequests = value;
				PropertySet(this);
			}
		}

		public OutlineRequestManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
