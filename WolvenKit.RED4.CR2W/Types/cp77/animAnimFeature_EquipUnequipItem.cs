using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_EquipUnequipItem : animAnimFeature
	{
		private CFloat _stateTransitionDuration;
		private CInt32 _itemState;
		private CInt32 _itemType;
		private CBool _firstEquip;

		[Ordinal(0)] 
		[RED("stateTransitionDuration")] 
		public CFloat StateTransitionDuration
		{
			get => GetProperty(ref _stateTransitionDuration);
			set => SetProperty(ref _stateTransitionDuration, value);
		}

		[Ordinal(1)] 
		[RED("itemState")] 
		public CInt32 ItemState
		{
			get => GetProperty(ref _itemState);
			set => SetProperty(ref _itemState, value);
		}

		[Ordinal(2)] 
		[RED("itemType")] 
		public CInt32 ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(3)] 
		[RED("firstEquip")] 
		public CBool FirstEquip
		{
			get => GetProperty(ref _firstEquip);
			set => SetProperty(ref _firstEquip, value);
		}

		public animAnimFeature_EquipUnequipItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
