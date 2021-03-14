using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entReplicatedAnimFeaturesState : CVariable
	{
		private CArray<entReplicatedAnimFeature> _items;
		private netTime _lastAppliedActionsTime;

		[Ordinal(0)] 
		[RED("items")] 
		public CArray<entReplicatedAnimFeature> Items
		{
			get
			{
				if (_items == null)
				{
					_items = (CArray<entReplicatedAnimFeature>) CR2WTypeManager.Create("array:entReplicatedAnimFeature", "items", cr2w, this);
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

		public entReplicatedAnimFeaturesState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
