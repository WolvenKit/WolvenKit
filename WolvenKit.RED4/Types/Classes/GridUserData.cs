using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GridUserData : IScriptable
	{
		[Ordinal(0)] 
		[RED("equipArea")] 
		public CEnum<gamedataEquipmentArea> EquipArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(1)] 
		[RED("align")] 
		public CEnum<inkEHorizontalAlign> Align
		{
			get => GetPropertyValue<CEnum<inkEHorizontalAlign>>();
			set => SetPropertyValue<CEnum<inkEHorizontalAlign>>(value);
		}

		[Ordinal(2)] 
		[RED("parent")] 
		public inkCompoundWidgetReference Parent
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		public GridUserData()
		{
			Parent = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
