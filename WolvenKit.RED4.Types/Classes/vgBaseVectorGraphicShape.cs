using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vgBaseVectorGraphicShape : ISerializable
	{
		private CMatrix _calTransform;
		private CHandle<vgVectorGraphicStyle> _yle;

		[Ordinal(0)] 
		[RED("calTransform")] 
		public CMatrix CalTransform
		{
			get => GetProperty(ref _calTransform);
			set => SetProperty(ref _calTransform, value);
		}

		[Ordinal(1)] 
		[RED("yle")] 
		public CHandle<vgVectorGraphicStyle> Yle
		{
			get => GetProperty(ref _yle);
			set => SetProperty(ref _yle, value);
		}
	}
}
