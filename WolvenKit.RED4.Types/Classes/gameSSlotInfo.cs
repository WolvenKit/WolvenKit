using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSSlotInfo : RedBaseClass
	{
		private CEnum<gamedataEquipmentArea> _areaType;
		private TweakDBID _equipSlot;
		private CName _visualTag;

		[Ordinal(0)] 
		[RED("areaType")] 
		public CEnum<gamedataEquipmentArea> AreaType
		{
			get => GetProperty(ref _areaType);
			set => SetProperty(ref _areaType, value);
		}

		[Ordinal(1)] 
		[RED("equipSlot")] 
		public TweakDBID EquipSlot
		{
			get => GetProperty(ref _equipSlot);
			set => SetProperty(ref _equipSlot, value);
		}

		[Ordinal(2)] 
		[RED("visualTag")] 
		public CName VisualTag
		{
			get => GetProperty(ref _visualTag);
			set => SetProperty(ref _visualTag, value);
		}
	}
}
