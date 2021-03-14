using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class moveReplicatedMovePoliciesState : CVariable
	{
		private CArray<moveReplicatedMovePolicies> _items;
		private netTime _lastAppliedActionsTime;

		[Ordinal(0)] 
		[RED("items")] 
		public CArray<moveReplicatedMovePolicies> Items
		{
			get
			{
				if (_items == null)
				{
					_items = (CArray<moveReplicatedMovePolicies>) CR2WTypeManager.Create("array:moveReplicatedMovePolicies", "items", cr2w, this);
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

		public moveReplicatedMovePoliciesState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
