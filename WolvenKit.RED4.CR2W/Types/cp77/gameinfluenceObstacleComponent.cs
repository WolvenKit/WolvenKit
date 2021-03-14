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
			get
			{
				if (_boundingBoxType == null)
				{
					_boundingBoxType = (CEnum<gameinfluenceEBoundingBoxType>) CR2WTypeManager.Create("gameinfluenceEBoundingBoxType", "boundingBoxType", cr2w, this);
				}
				return _boundingBoxType;
			}
			set
			{
				if (_boundingBoxType == value)
				{
					return;
				}
				_boundingBoxType = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("customBoundingBox")] 
		public Box CustomBoundingBox
		{
			get
			{
				if (_customBoundingBox == null)
				{
					_customBoundingBox = (Box) CR2WTypeManager.Create("Box", "customBoundingBox", cr2w, this);
				}
				return _customBoundingBox;
			}
			set
			{
				if (_customBoundingBox == value)
				{
					return;
				}
				_customBoundingBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("obstacleAgent")] 
		public gameinfluenceObstacleAgent ObstacleAgent
		{
			get
			{
				if (_obstacleAgent == null)
				{
					_obstacleAgent = (gameinfluenceObstacleAgent) CR2WTypeManager.Create("gameinfluenceObstacleAgent", "obstacleAgent", cr2w, this);
				}
				return _obstacleAgent;
			}
			set
			{
				if (_obstacleAgent == value)
				{
					return;
				}
				_obstacleAgent = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		public gameinfluenceObstacleComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
