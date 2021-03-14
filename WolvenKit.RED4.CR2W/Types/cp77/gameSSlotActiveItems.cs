using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSSlotActiveItems : CVariable
	{
		private gameItemID _rightHandItem;
		private gameItemID _leftHandItem;

		[Ordinal(0)] 
		[RED("rightHandItem")] 
		public gameItemID RightHandItem
		{
			get
			{
				if (_rightHandItem == null)
				{
					_rightHandItem = (gameItemID) CR2WTypeManager.Create("gameItemID", "rightHandItem", cr2w, this);
				}
				return _rightHandItem;
			}
			set
			{
				if (_rightHandItem == value)
				{
					return;
				}
				_rightHandItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("leftHandItem")] 
		public gameItemID LeftHandItem
		{
			get
			{
				if (_leftHandItem == null)
				{
					_leftHandItem = (gameItemID) CR2WTypeManager.Create("gameItemID", "leftHandItem", cr2w, this);
				}
				return _leftHandItem;
			}
			set
			{
				if (_leftHandItem == value)
				{
					return;
				}
				_leftHandItem = value;
				PropertySet(this);
			}
		}

		public gameSSlotActiveItems(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
