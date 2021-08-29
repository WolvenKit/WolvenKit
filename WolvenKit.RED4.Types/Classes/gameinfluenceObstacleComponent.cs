using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinfluenceObstacleComponent : entIPlacedComponent
	{
		private CEnum<gameinfluenceEBoundingBoxType> _boundingBoxType;
		private Box _customBoundingBox;
		private gameinfluenceObstacleAgent _obstacleAgent;
		private CBool _isEnabled;

		[Ordinal(5)] 
		[RED("boundingBoxType")] 
		public CEnum<gameinfluenceEBoundingBoxType> BoundingBoxType
		{
			get => GetProperty(ref _boundingBoxType);
			set => SetProperty(ref _boundingBoxType, value);
		}

		[Ordinal(6)] 
		[RED("customBoundingBox")] 
		public Box CustomBoundingBox
		{
			get => GetProperty(ref _customBoundingBox);
			set => SetProperty(ref _customBoundingBox, value);
		}

		[Ordinal(7)] 
		[RED("obstacleAgent")] 
		public gameinfluenceObstacleAgent ObstacleAgent
		{
			get => GetProperty(ref _obstacleAgent);
			set => SetProperty(ref _obstacleAgent, value);
		}

		[Ordinal(8)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}
	}
}
