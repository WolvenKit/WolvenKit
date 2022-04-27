using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questRenderPlane_NodeType : questIRenderFxManagerNodeType
	{
		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("renderPlane")] 
		public CEnum<ERenderingPlane> RenderPlane
		{
			get => GetPropertyValue<CEnum<ERenderingPlane>>();
			set => SetPropertyValue<CEnum<ERenderingPlane>>(value);
		}

		public questRenderPlane_NodeType()
		{
			PuppetRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
