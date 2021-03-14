using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticParticleNodeInstance : worldINodeInstance
	{
		private CEnum<RenderSceneLayerMask> _renderLayerMask;

		[Ordinal(0)] 
		[RED("renderLayerMask")] 
		public CEnum<RenderSceneLayerMask> RenderLayerMask
		{
			get
			{
				if (_renderLayerMask == null)
				{
					_renderLayerMask = (CEnum<RenderSceneLayerMask>) CR2WTypeManager.Create("RenderSceneLayerMask", "renderLayerMask", cr2w, this);
				}
				return _renderLayerMask;
			}
			set
			{
				if (_renderLayerMask == value)
				{
					return;
				}
				_renderLayerMask = value;
				PropertySet(this);
			}
		}

		public worldStaticParticleNodeInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
