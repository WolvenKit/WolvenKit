using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRenderPlane_NodeType : questIRenderFxManagerNodeType
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

		public questRenderPlane_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
