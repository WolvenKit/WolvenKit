using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderTextureResource : CVariable
	{
		private CHandle<IRenderResourceBlob> _renderResourceBlobPC;

		[Ordinal(0)] 
		[RED("renderResourceBlobPC")] 
		public CHandle<IRenderResourceBlob> RenderResourceBlobPC
		{
			get => GetProperty(ref _renderResourceBlobPC);
			set => SetProperty(ref _renderResourceBlobPC, value);
		}

		public rendRenderTextureResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
