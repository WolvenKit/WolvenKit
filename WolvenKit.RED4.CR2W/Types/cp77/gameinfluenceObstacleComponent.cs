using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceObstacleComponent : entIPlacedComponent
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

		public gameinfluenceObstacleComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
