using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entIVisualComponent : entIPlacedComponent
	{
		private CFloat _autoHideDistance;
		private CEnum<RenderSceneLayerMask> _renderSceneLayerMask;
		private CInt8 _forceLODLevel;

		[Ordinal(5)] 
		[RED("autoHideDistance")] 
		public CFloat AutoHideDistance
		{
			get
			{
				if (_autoHideDistance == null)
				{
					_autoHideDistance = (CFloat) CR2WTypeManager.Create("Float", "autoHideDistance", cr2w, this);
				}
				return _autoHideDistance;
			}
			set
			{
				if (_autoHideDistance == value)
				{
					return;
				}
				_autoHideDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("forceLODLevel")] 
		public CInt8 ForceLODLevel
		{
			get
			{
				if (_forceLODLevel == null)
				{
					_forceLODLevel = (CInt8) CR2WTypeManager.Create("Int8", "forceLODLevel", cr2w, this);
				}
				return _forceLODLevel;
			}
			set
			{
				if (_forceLODLevel == value)
				{
					return;
				}
				_forceLODLevel = value;
				PropertySet(this);
			}
		}

		public entIVisualComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
