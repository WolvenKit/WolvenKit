using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinfluenceObstacleAgent : gameinfluenceIAgent
	{
		private CBool _useMeshes;
		private CFloat _radius;

		[Ordinal(0)] 
		[RED("useMeshes")] 
		public CBool UseMeshes
		{
			get => GetProperty(ref _useMeshes);
			set => SetProperty(ref _useMeshes, value);
		}

		[Ordinal(1)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}
	}
}
