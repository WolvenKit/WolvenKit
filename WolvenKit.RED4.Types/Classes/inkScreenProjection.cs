using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkScreenProjection : IScriptable
	{
		private CFloat _distanceToCamera;
		private Vector2 _previousPosition;
		private Vector2 _currentPosition;
		private Vector2 _uvPosition;

		[Ordinal(0)] 
		[RED("distanceToCamera")] 
		public CFloat DistanceToCamera
		{
			get => GetProperty(ref _distanceToCamera);
			set => SetProperty(ref _distanceToCamera, value);
		}

		[Ordinal(1)] 
		[RED("previousPosition")] 
		public Vector2 PreviousPosition
		{
			get => GetProperty(ref _previousPosition);
			set => SetProperty(ref _previousPosition, value);
		}

		[Ordinal(2)] 
		[RED("currentPosition")] 
		public Vector2 CurrentPosition
		{
			get => GetProperty(ref _currentPosition);
			set => SetProperty(ref _currentPosition, value);
		}

		[Ordinal(3)] 
		[RED("uvPosition")] 
		public Vector2 UvPosition
		{
			get => GetProperty(ref _uvPosition);
			set => SetProperty(ref _uvPosition, value);
		}
	}
}
