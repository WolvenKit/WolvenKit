using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetRenderLayer_NodeType : questIRenderFxManagerNodeType
	{
		private CEnum<RenderSceneLayer> _renderSceneLayer;

		[Ordinal(0)] 
		[RED("renderSceneLayer")] 
		public CEnum<RenderSceneLayer> RenderSceneLayer
		{
			get
			{
				if (_renderSceneLayer == null)
				{
					_renderSceneLayer = (CEnum<RenderSceneLayer>) CR2WTypeManager.Create("RenderSceneLayer", "renderSceneLayer", cr2w, this);
				}
				return _renderSceneLayer;
			}
			set
			{
				if (_renderSceneLayer == value)
				{
					return;
				}
				_renderSceneLayer = value;
				PropertySet(this);
			}
		}

		public questSetRenderLayer_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
