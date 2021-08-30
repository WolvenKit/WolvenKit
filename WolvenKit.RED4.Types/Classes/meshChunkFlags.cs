using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshChunkFlags : RedBaseClass
	{
		private CBool _renderInScene;
		private CBool _renderInShadows;
		private CBool _isTwoSided;
		private CBool _isRayTracedEmissive;
		private CBool _isConsoleLOD0;

		[Ordinal(0)] 
		[RED("renderInScene")] 
		public CBool RenderInScene
		{
			get => GetProperty(ref _renderInScene);
			set => SetProperty(ref _renderInScene, value);
		}

		[Ordinal(1)] 
		[RED("renderInShadows")] 
		public CBool RenderInShadows
		{
			get => GetProperty(ref _renderInShadows);
			set => SetProperty(ref _renderInShadows, value);
		}

		[Ordinal(2)] 
		[RED("isTwoSided")] 
		public CBool IsTwoSided
		{
			get => GetProperty(ref _isTwoSided);
			set => SetProperty(ref _isTwoSided, value);
		}

		[Ordinal(3)] 
		[RED("isRayTracedEmissive")] 
		public CBool IsRayTracedEmissive
		{
			get => GetProperty(ref _isRayTracedEmissive);
			set => SetProperty(ref _isRayTracedEmissive, value);
		}

		[Ordinal(4)] 
		[RED("isConsoleLOD0")] 
		public CBool IsConsoleLOD0
		{
			get => GetProperty(ref _isConsoleLOD0);
			set => SetProperty(ref _isConsoleLOD0, value);
		}

		public meshChunkFlags()
		{
			_renderInScene = true;
			_renderInShadows = true;
		}
	}
}
