using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisarmComponent : gameScriptableComponent
	{
		private CBool _isDisarmingOngoing;
		private wCHandle<gameObject> _owner;
		private wCHandle<gameObject> _requester;

		[Ordinal(5)] 
		[RED("isDisarmingOngoing")] 
		public CBool IsDisarmingOngoing
		{
			get
			{
				if (_isDisarmingOngoing == null)
				{
					_isDisarmingOngoing = (CBool) CR2WTypeManager.Create("Bool", "isDisarmingOngoing", cr2w, this);
				}
				return _isDisarmingOngoing;
			}
			set
			{
				if (_isDisarmingOngoing == value)
				{
					return;
				}
				_isDisarmingOngoing = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("requester")] 
		public wCHandle<gameObject> Requester
		{
			get
			{
				if (_requester == null)
				{
					_requester = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "requester", cr2w, this);
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

		public DisarmComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
