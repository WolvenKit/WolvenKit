using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplicatedEntityEventsState : CVariable
	{
		private CArray<gameReplicatedEntityEvent> _items;
		private netTime _lastAppliedActionsTime;

		[Ordinal(0)] 
		[RED("items")] 
		public CArray<gameReplicatedEntityEvent> Items
		{
			get
			{
				if (_items == null)
				{
					_items = (CArray<gameReplicatedEntityEvent>) CR2WTypeManager.Create("array:gameReplicatedEntityEvent", "items", cr2w, this);
				}
				return _items;
			}
			set
			{
				if (_items == value)
				{
					return;
				}
				_items = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lastAppliedActionsTime")] 
		public netTime LastAppliedActionsTime
		{
			get
			{
				if (_lastAppliedActionsTime == null)
				{
					_lastAppliedActionsTime = (netTime) CR2WTypeManager.Create("netTime", "lastAppliedActionsTime", cr2w, this);
				}
				return _lastAppliedActionsTime;
			}
			set
			{
				if (_lastAppliedActionsTime == value)
				{
					return;
				}
				_lastAppliedActionsTime = value;
				PropertySet(this);
			}
		}

		public gameReplicatedEntityEventsState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
