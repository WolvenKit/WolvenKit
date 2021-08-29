using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GridUserData : IScriptable
	{
		private CEnum<gamedataEquipmentArea> _equipArea;
		private CEnum<inkEHorizontalAlign> _align;

		[Ordinal(0)] 
		[RED("equipArea")] 
		public CEnum<gamedataEquipmentArea> EquipArea
		{
			get => GetProperty(ref _equipArea);
			set => SetProperty(ref _equipArea, value);
		}

		[Ordinal(1)] 
		[RED("align")] 
		public CEnum<inkEHorizontalAlign> Align
		{
			get => GetProperty(ref _align);
			set => SetProperty(ref _align, value);
		}
	}
}
