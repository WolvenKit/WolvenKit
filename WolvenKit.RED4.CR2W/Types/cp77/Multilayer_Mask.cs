using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Multilayer_Mask : CResource
	{
		private rendRenderMultilayerMaskResource _renderResourceBlob;

		[Ordinal(1)] 
		[RED("renderResourceBlob")] 
		public rendRenderMultilayerMaskResource RenderResourceBlob
		{
			get
			{
				if (_renderResourceBlob == null)
				{
					_renderResourceBlob = (rendRenderMultilayerMaskResource) CR2WTypeManager.Create("rendRenderMultilayerMaskResource", "renderResourceBlob", cr2w, this);
				}
				return _renderResourceBlob;
			}
			set
			{
				if (_renderResourceBlob == value)
				{
					return;
				}
				_renderResourceBlob = value;
				PropertySet(this);
			}
		}

		public Multilayer_Mask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
