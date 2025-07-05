using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Multilayer_Mask : CResource
	{
		[Ordinal(1)] 
		[RED("renderResourceBlob")] 
		public rendRenderMultilayerMaskResource RenderResourceBlob
		{
			get => GetPropertyValue<rendRenderMultilayerMaskResource>();
			set => SetPropertyValue<rendRenderMultilayerMaskResource>(value);
		}

		public Multilayer_Mask()
		{
			RenderResourceBlob = new rendRenderMultilayerMaskResource();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
