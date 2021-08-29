using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vgVectorGraphicShape_Circle : vgBaseVectorGraphicShape
	{
		private CFloat _dius;

		[Ordinal(2)] 
		[RED("dius")] 
		public CFloat Dius
		{
			get => GetProperty(ref _dius);
			set => SetProperty(ref _dius, value);
		}
	}
}
