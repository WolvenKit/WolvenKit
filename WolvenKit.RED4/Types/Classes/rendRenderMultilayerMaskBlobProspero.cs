
namespace WolvenKit.RED4.Types
{
	public partial class rendRenderMultilayerMaskBlobProspero : rendRenderMultilayerMaskBlob
	{
		public rendRenderMultilayerMaskBlobProspero()
		{
			Header = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
