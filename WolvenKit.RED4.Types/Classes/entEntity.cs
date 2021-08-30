using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entEntity : IScriptable
	{
		private CEnum<ECustomCameraTarget> _customCameraTarget;
		private CEnum<RenderSceneLayerMask> _renderSceneLayerMask;

		[Ordinal(0)] 
		[RED("customCameraTarget")] 
		public CEnum<ECustomCameraTarget> CustomCameraTarget
		{
			get => GetProperty(ref _customCameraTarget);
			set => SetProperty(ref _customCameraTarget, value);
		}

		[Ordinal(1)] 
		[RED("renderSceneLayerMask")] 
		public CEnum<RenderSceneLayerMask> RenderSceneLayerMask
		{
			get => GetProperty(ref _renderSceneLayerMask);
			set => SetProperty(ref _renderSceneLayerMask, value);
		}

		public entEntity()
		{
			_renderSceneLayerMask = new() { Value = Enums.RenderSceneLayerMask.Default };
		}
	}
}
