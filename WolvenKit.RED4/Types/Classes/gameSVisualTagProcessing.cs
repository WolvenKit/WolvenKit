using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSVisualTagProcessing : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("areaType")] 
		public CEnum<gamedataEquipmentArea> AreaType
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(1)] 
		[RED("showItem")] 
		public CBool ShowItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameSVisualTagProcessing()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
