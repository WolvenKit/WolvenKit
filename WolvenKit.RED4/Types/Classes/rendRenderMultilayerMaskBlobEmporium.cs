
namespace WolvenKit.RED4.Types
{
	public partial class rendRenderMultilayerMaskBlobEmporium : rendRenderMultilayerMaskBlob
	{
		public rendRenderMultilayerMaskBlobEmporium()
		{
			Header = new rendRenderMultilayerMaskBlobHeader();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
