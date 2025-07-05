
namespace WolvenKit.RED4.Types
{
	public partial class rendRenderMultilayerMaskBlobProspero : rendRenderMultilayerMaskBlob
	{
		public rendRenderMultilayerMaskBlobProspero()
		{
			Header = new rendRenderMultilayerMaskBlobHeader();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
