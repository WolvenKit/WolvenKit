using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendRenderTextureResource : RedBaseClass
	{
		private CHandle<IRenderResourceBlob> _renderResourceBlobPC;

		[Ordinal(0)] 
		[RED("renderResourceBlobPC")] 
		public CHandle<IRenderResourceBlob> RenderResourceBlobPC
		{
			get => GetProperty(ref _renderResourceBlobPC);
			set => SetProperty(ref _renderResourceBlobPC, value);
		}
	}
}
