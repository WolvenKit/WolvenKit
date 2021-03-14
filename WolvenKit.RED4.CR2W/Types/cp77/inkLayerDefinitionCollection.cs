using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLayerDefinitionCollection : CVariable
	{
		private inkMenuLayerDefinition _menuLayer;
		private inkMenuLayerDefinition _menuLayerMP;
		private inkHUDLayerDefinition _hudLayer;
		private inkVideoLayerDefinition _videoLayer;
		private inkOffscreenLayerDefinition _offscreenLayer;
		private inkGameNotificationsLayerDefinition _gameNotificationsLayer;
		private inkPhotoModeLayerDefinition _photoModeLayer;
		private inkDebugLayerDefinition _debugLayer;

		[Ordinal(0)] 
		[RED("menuLayer")] 
		public inkMenuLayerDefinition MenuLayer
		{
			get
			{
				if (_menuLayer == null)
				{
					_menuLayer = (inkMenuLayerDefinition) CR2WTypeManager.Create("inkMenuLayerDefinition", "menuLayer", cr2w, this);
				}
				return _menuLayer;
			}
			set
			{
				if (_menuLayer == value)
				{
					return;
				}
				_menuLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("menuLayerMP")] 
		public inkMenuLayerDefinition MenuLayerMP
		{
			get
			{
				if (_menuLayerMP == null)
				{
					_menuLayerMP = (inkMenuLayerDefinition) CR2WTypeManager.Create("inkMenuLayerDefinition", "menuLayerMP", cr2w, this);
				}
				return _menuLayerMP;
			}
			set
			{
				if (_menuLayerMP == value)
				{
					return;
				}
				_menuLayerMP = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hudLayer")] 
		public inkHUDLayerDefinition HudLayer
		{
			get
			{
				if (_hudLayer == null)
				{
					_hudLayer = (inkHUDLayerDefinition) CR2WTypeManager.Create("inkHUDLayerDefinition", "hudLayer", cr2w, this);
				}
				return _hudLayer;
			}
			set
			{
				if (_hudLayer == value)
				{
					return;
				}
				_hudLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("videoLayer")] 
		public inkVideoLayerDefinition VideoLayer
		{
			get
			{
				if (_videoLayer == null)
				{
					_videoLayer = (inkVideoLayerDefinition) CR2WTypeManager.Create("inkVideoLayerDefinition", "videoLayer", cr2w, this);
				}
				return _videoLayer;
			}
			set
			{
				if (_videoLayer == value)
				{
					return;
				}
				_videoLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("offscreenLayer")] 
		public inkOffscreenLayerDefinition OffscreenLayer
		{
			get
			{
				if (_offscreenLayer == null)
				{
					_offscreenLayer = (inkOffscreenLayerDefinition) CR2WTypeManager.Create("inkOffscreenLayerDefinition", "offscreenLayer", cr2w, this);
				}
				return _offscreenLayer;
			}
			set
			{
				if (_offscreenLayer == value)
				{
					return;
				}
				_offscreenLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("gameNotificationsLayer")] 
		public inkGameNotificationsLayerDefinition GameNotificationsLayer
		{
			get
			{
				if (_gameNotificationsLayer == null)
				{
					_gameNotificationsLayer = (inkGameNotificationsLayerDefinition) CR2WTypeManager.Create("inkGameNotificationsLayerDefinition", "gameNotificationsLayer", cr2w, this);
				}
				return _gameNotificationsLayer;
			}
			set
			{
				if (_gameNotificationsLayer == value)
				{
					return;
				}
				_gameNotificationsLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("photoModeLayer")] 
		public inkPhotoModeLayerDefinition PhotoModeLayer
		{
			get
			{
				if (_photoModeLayer == null)
				{
					_photoModeLayer = (inkPhotoModeLayerDefinition) CR2WTypeManager.Create("inkPhotoModeLayerDefinition", "photoModeLayer", cr2w, this);
				}
				return _photoModeLayer;
			}
			set
			{
				if (_photoModeLayer == value)
				{
					return;
				}
				_photoModeLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("debugLayer")] 
		public inkDebugLayerDefinition DebugLayer
		{
			get
			{
				if (_debugLayer == null)
				{
					_debugLayer = (inkDebugLayerDefinition) CR2WTypeManager.Create("inkDebugLayerDefinition", "debugLayer", cr2w, this);
				}
				return _debugLayer;
			}
			set
			{
				if (_debugLayer == value)
				{
					return;
				}
				_debugLayer = value;
				PropertySet(this);
			}
		}

		public inkLayerDefinitionCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
