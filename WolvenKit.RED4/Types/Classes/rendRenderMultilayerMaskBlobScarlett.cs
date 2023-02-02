
namespace WolvenKit.RED4.Types
{
	public partial class rendRenderMultilayerMaskBlobScarlett : rendRenderMultilayerMaskBlob
	{
		public rendRenderMultilayerMaskBlobScarlett()
		{
			Header = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
