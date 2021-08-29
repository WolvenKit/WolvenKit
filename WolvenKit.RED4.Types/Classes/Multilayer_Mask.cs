using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Multilayer_Mask : CResource
	{
		private rendRenderMultilayerMaskResource _renderResourceBlob;

		[Ordinal(1)] 
		[RED("renderResourceBlob")] 
		public rendRenderMultilayerMaskResource RenderResourceBlob
		{
			get => GetProperty(ref _renderResourceBlob);
			set => SetProperty(ref _renderResourceBlob, value);
		}
	}
}
