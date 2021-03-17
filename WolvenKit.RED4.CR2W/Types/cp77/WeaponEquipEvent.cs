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
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(1)] 
		[RED("item")] 
		public wCHandle<gameItemObject> Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}

		public WeaponEquipEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
