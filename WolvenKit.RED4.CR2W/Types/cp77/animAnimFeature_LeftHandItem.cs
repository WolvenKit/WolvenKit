using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_LeftHandItem : animAnimFeature
	{
		private CBool _itemInLeftHand;

		[Ordinal(0)] 
		[RED("itemInLeftHand")] 
		public CBool ItemInLeftHand
		{
			get
			{
				if (_itemInLeftHand == null)
				{
					_itemInLeftHand = (CBool) CR2WTypeManager.Create("Bool", "itemInLeftHand", cr2w, this);
				}
				return _itemInLeftHand;
			}
			set
			{
				if (_itemInLeftHand == value)
				{
					return;
				}
				_itemInLeftHand = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_LeftHandItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
