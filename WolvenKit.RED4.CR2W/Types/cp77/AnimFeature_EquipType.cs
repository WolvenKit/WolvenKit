using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_EquipType : animAnimFeature
	{
		private CBool _firstEquip;
		private CFloat _equipDuration;
		private CFloat _unequipDuration;

		[Ordinal(0)] 
		[RED("firstEquip")] 
		public CBool FirstEquip
		{
			get => GetProperty(ref _firstEquip);
			set => SetProperty(ref _firstEquip, value);
		}

		[Ordinal(1)] 
		[RED("equipDuration")] 
		public CFloat EquipDuration
		{
			get => GetProperty(ref _equipDuration);
			set => SetProperty(ref _equipDuration, value);
		}

		[Ordinal(2)] 
		[RED("unequipDuration")] 
		public CFloat UnequipDuration
		{
			get => GetProperty(ref _unequipDuration);
			set => SetProperty(ref _unequipDuration, value);
		}

		public AnimFeature_EquipType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
