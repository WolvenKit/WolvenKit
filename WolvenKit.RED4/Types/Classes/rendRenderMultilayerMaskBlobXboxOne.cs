
namespace WolvenKit.RED4.Types
{
	public partial class rendRenderMultilayerMaskBlobXboxOne : rendRenderMultilayerMaskBlob
	{
		public rendRenderMultilayerMaskBlobXboxOne()
		{
			Header = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
