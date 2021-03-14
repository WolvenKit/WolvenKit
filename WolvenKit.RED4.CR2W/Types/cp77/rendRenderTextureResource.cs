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
			get
			{
				if (_renderResourceBlobPC == null)
				{
					_renderResourceBlobPC = (CHandle<IRenderResourceBlob>) CR2WTypeManager.Create("handle:IRenderResourceBlob", "renderResourceBlobPC", cr2w, this);
				}
				return _renderResourceBlobPC;
			}
			set
			{
				if (_renderResourceBlobPC == value)
				{
					return;
				}
				_renderResourceBlobPC = value;
				PropertySet(this);
			}
		}

		public rendRenderTextureResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
