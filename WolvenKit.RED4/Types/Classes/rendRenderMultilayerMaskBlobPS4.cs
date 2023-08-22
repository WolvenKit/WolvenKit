
namespace WolvenKit.RED4.Types
{
	public partial class rendRenderMultilayerMaskBlobPS4 : rendRenderMultilayerMaskBlob
	{
		public rendRenderMultilayerMaskBlobPS4()
		{
			Header = new rendRenderMultilayerMaskBlobHeader();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
