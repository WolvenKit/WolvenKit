using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendRenderMultilayerMaskResource : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("renderResourceBlobPC")] 
		public CHandle<IRenderResourceBlob> RenderResourceBlobPC
		{
			get => GetPropertyValue<CHandle<IRenderResourceBlob>>();
			set => SetPropertyValue<CHandle<IRenderResourceBlob>>(value);
		}

		public rendRenderMultilayerMaskResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
