using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entEntity : IScriptable
	{
		private CEnum<ECustomCameraTarget> _customCameraTarget;
		private CEnum<RenderSceneLayerMask> _renderSceneLayerMask;

		[Ordinal(0)] 
		[RED("customCameraTarget")] 
		public CEnum<ECustomCameraTarget> CustomCameraTarget
		{
			get
			{
				if (_customCameraTarget == null)
				{
					_customCameraTarget = (CEnum<ECustomCameraTarget>) CR2WTypeManager.Create("ECustomCameraTarget", "customCameraTarget", cr2w, this);
				}
				return _customCameraTarget;
			}
			set
			{
				if (_customCameraTarget == value)
				{
					return;
				}
				_customCameraTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("renderSceneLayerMask")] 
		public CEnum<RenderSceneLayerMask> RenderSceneLayerMask
		{
			get
			{
				if (_renderSceneLayerMask == null)
				{
					_renderSceneLayerMask = (CEnum<RenderSceneLayerMask>) CR2WTypeManager.Create("RenderSceneLayerMask", "renderSceneLayerMask", cr2w, this);
				}
				return _renderSceneLayerMask;
			}
			set
			{
				if (_renderSceneLayerMask == value)
				{
					return;
				}
				_renderSceneLayerMask = value;
				PropertySet(this);
			}
		}

		public entEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
