
namespace WolvenKit.RED4.Types
{
	public partial class rendRenderMultilayerMaskBlobPC : rendRenderMultilayerMaskBlob
	{
		public rendRenderMultilayerMaskBlobPC()
		{
			Header = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
