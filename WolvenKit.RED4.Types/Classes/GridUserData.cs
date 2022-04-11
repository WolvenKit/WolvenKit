using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
	}
}
