using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AutocraftSystem : gameScriptableSystem
	{
		private CBool _active;
		private CFloat _cycleDuration;
		private gameDelayID _currentDelayID;
		private CArray<gameItemID> _itemsUsed;

		[Ordinal(0)] 
		[RED("active")] 
		public CBool Active
		{
			get
			{
				if (_active == null)
				{
					_active = (CBool) CR2WTypeManager.Create("Bool", "active", cr2w, this);
				}
				return _active;
			}
			set
			{
				if (_active == value)
				{
					return;
				}
				_active = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("cycleDuration")] 
		public CFloat CycleDuration
		{
			get
			{
				if (_cycleDuration == null)
				{
					_cycleDuration = (CFloat) CR2WTypeManager.Create("Float", "cycleDuration", cr2w, this);
				}
				return _cycleDuration;
			}
			set
			{
				if (_cycleDuration == value)
				{
					return;
				}
				_cycleDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("currentDelayID")] 
		public gameDelayID CurrentDelayID
		{
			get
			{
				if (_currentDelayID == null)
				{
					_currentDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "currentDelayID", cr2w, this);
				}
				return _currentDelayID;
			}
			set
			{
				if (_currentDelayID == value)
				{
					return;
				}
				_currentDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("itemsUsed")] 
		public CArray<gameItemID> ItemsUsed
		{
			get
			{
				if (_itemsUsed == null)
				{
					_itemsUsed = (CArray<gameItemID>) CR2WTypeManager.Create("array:gameItemID", "itemsUsed", cr2w, this);
				}
				return _itemsUsed;
			}
			set
			{
				if (_itemsUsed == value)
				{
					return;
				}
				_itemsUsed = value;
				PropertySet(this);
			}
		}

		public AutocraftSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
