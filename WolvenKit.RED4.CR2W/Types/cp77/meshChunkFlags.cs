using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshChunkFlags : CVariable
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

		public meshChunkFlags(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
