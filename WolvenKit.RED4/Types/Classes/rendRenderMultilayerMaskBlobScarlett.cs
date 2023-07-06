
namespace WolvenKit.RED4.Types
{
	public partial class rendRenderMultilayerMaskBlobScarlett : rendRenderMultilayerMaskBlob
	{
		public rendRenderMultilayerMaskBlobScarlett()
		{
			Header = new rendRenderMultilayerMaskBlobHeader();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
