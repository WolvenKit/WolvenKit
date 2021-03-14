using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameweaponGrenadeReplicatedState : netIEntityState
	{
		private wCHandle<gameObject> _instigator;
		private gameItemID _itemID;
		private WorldTransform _currentTransform;
		private CBool _exploded;
		private CBool _launched;

		[Ordinal(2)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get
			{
				if (_instigator == null)
				{
					_instigator = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "instigator", cr2w, this);
				}
				return _instigator;
			}
			set
			{
				if (_instigator == value)
				{
					return;
				}
				_instigator = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get
			{
				if (_itemID == null)
				{
					_itemID = (gameItemID) CR2WTypeManager.Create("gameItemID", "itemID", cr2w, this);
				}
				return _itemID;
			}
			set
			{
				if (_itemID == value)
				{
					return;
				}
				_itemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("currentTransform")] 
		public WorldTransform CurrentTransform
		{
			get
			{
				if (_currentTransform == null)
				{
					_currentTransform = (WorldTransform) CR2WTypeManager.Create("WorldTransform", "currentTransform", cr2w, this);
				}
				return _currentTransform;
			}
			set
			{
				if (_currentTransform == value)
				{
					return;
				}
				_currentTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("exploded")] 
		public CBool Exploded
		{
			get
			{
				if (_exploded == null)
				{
					_exploded = (CBool) CR2WTypeManager.Create("Bool", "exploded", cr2w, this);
				}
				return _exploded;
			}
			set
			{
				if (_exploded == value)
				{
					return;
				}
				_exploded = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("launched")] 
		public CBool Launched
		{
			get
			{
				if (_launched == null)
				{
					_launched = (CBool) CR2WTypeManager.Create("Bool", "launched", cr2w, this);
				}
				return _launched;
			}
			set
			{
				if (_launched == value)
				{
					return;
				}
				_launched = value;
				PropertySet(this);
			}
		}

		public gameweaponGrenadeReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
