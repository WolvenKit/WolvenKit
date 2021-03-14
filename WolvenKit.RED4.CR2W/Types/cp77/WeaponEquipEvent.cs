using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponEquipEvent : redEvent
	{
		private CHandle<AnimFeature_EquipType> _animFeature;
		private wCHandle<gameItemObject> _item;

		[Ordinal(0)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_EquipType> AnimFeature
		{
			get
			{
				if (_animFeature == null)
				{
					_animFeature = (CHandle<AnimFeature_EquipType>) CR2WTypeManager.Create("handle:AnimFeature_EquipType", "animFeature", cr2w, this);
				}
				return _animFeature;
			}
			set
			{
				if (_animFeature == value)
				{
					return;
				}
				_animFeature = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("item")] 
		public wCHandle<gameItemObject> Item
		{
			get
			{
				if (_item == null)
				{
					_item = (wCHandle<gameItemObject>) CR2WTypeManager.Create("whandle:gameItemObject", "item", cr2w, this);
				}
				return _item;
			}
			set
			{
				if (_item == value)
				{
					return;
				}
				_item = value;
				PropertySet(this);
			}
		}

		public WeaponEquipEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
