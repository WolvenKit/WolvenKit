using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questRenderPlane_NodeType : questIRenderFxManagerNodeType
	{
		private gameEntityReference _puppetRef;
		private CEnum<ERenderingPlane> _renderPlane;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("renderPlane")] 
		public CEnum<ERenderingPlane> RenderPlane
		{
			get => GetProperty(ref _renderPlane);
			set => SetProperty(ref _renderPlane, value);
		}
	}
}
