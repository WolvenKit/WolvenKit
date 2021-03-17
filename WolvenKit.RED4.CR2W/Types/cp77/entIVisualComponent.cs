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
			get => GetProperty(ref _autoHideDistance);
			set => SetProperty(ref _autoHideDistance, value);
		}

		[Ordinal(6)] 
		[RED("renderSceneLayerMask")] 
		public CEnum<RenderSceneLayerMask> RenderSceneLayerMask
		{
			get => GetProperty(ref _renderSceneLayerMask);
			set => SetProperty(ref _renderSceneLayerMask, value);
		}

		[Ordinal(7)] 
		[RED("forceLODLevel")] 
		public CInt8 ForceLODLevel
		{
			get => GetProperty(ref _forceLODLevel);
			set => SetProperty(ref _forceLODLevel, value);
		}

		public entIVisualComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
