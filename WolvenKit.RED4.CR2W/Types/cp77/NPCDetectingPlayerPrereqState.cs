using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCDetectingPlayerPrereqState : gamePrereqState
	{
		private wCHandle<gameObject> _owner;
		private CUInt32 _listenerID;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("listenerID")] 
		public CUInt32 ListenerID
		{
			get
			{
				if (_listenerID == null)
				{
					_listenerID = (CUInt32) CR2WTypeManager.Create("Uint32", "listenerID", cr2w, this);
				}
				return _listenerID;
			}
			set
			{
				if (_listenerID == value)
				{
					return;
				}
				_listenerID = value;
				PropertySet(this);
			}
		}

		public NPCDetectingPlayerPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
