using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksMenuAttributeItemCreated : redEvent
	{
		private CHandle<PerksMenuAttributeItemController> _perksMenuAttributeItem;

		[Ordinal(0)] 
		[RED("perksMenuAttributeItem")] 
		public CHandle<PerksMenuAttributeItemController> PerksMenuAttributeItem
		{
			get
			{
				if (_perksMenuAttributeItem == null)
				{
					_perksMenuAttributeItem = (CHandle<PerksMenuAttributeItemController>) CR2WTypeManager.Create("handle:PerksMenuAttributeItemController", "perksMenuAttributeItem", cr2w, this);
				}
				return _perksMenuAttributeItem;
			}
			set
			{
				if (_perksMenuAttributeItem == value)
				{
					return;
				}
				_perksMenuAttributeItem = value;
				PropertySet(this);
			}
		}

		public PerksMenuAttributeItemCreated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
