using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSVisualTagProcessing : RedBaseClass
	{
		private CEnum<gamedataEquipmentArea> _areaType;
		private CBool _showItem;

		[Ordinal(0)] 
		[RED("areaType")] 
		public CEnum<gamedataEquipmentArea> AreaType
		{
			get => GetProperty(ref _areaType);
			set => SetProperty(ref _areaType, value);
		}

		[Ordinal(1)] 
		[RED("showItem")] 
		public CBool ShowItem
		{
			get => GetProperty(ref _showItem);
			set => SetProperty(ref _showItem, value);
		}
	}
}
