using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkDexLimoGameController : gameuiWidgetGameController
	{
		private CHandle<gameIBlackboard> _activeVehicleBlackboard;
		private CUInt32 _playerVehStateId;
		private wCHandle<inkVideoWidget> _screenVideoWidget;
		private CName _screenVideoWidgetPath;
		private redResourceReferenceScriptToken _videoPath;

		[Ordinal(2)] 
		[RED("activeVehicleBlackboard")] 
		public CHandle<gameIBlackboard> ActiveVehicleBlackboard
		{
			get
			{
				if (_activeVehicleBlackboard == null)
				{
					_activeVehicleBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "activeVehicleBlackboard", cr2w, this);
				}
				return _activeVehicleBlackboard;
			}
			set
			{
				if (_activeVehicleBlackboard == value)
				{
					return;
				}
				_activeVehicleBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("playerVehStateId")] 
		public CUInt32 PlayerVehStateId
		{
			get
			{
				if (_playerVehStateId == null)
				{
					_playerVehStateId = (CUInt32) CR2WTypeManager.Create("Uint32", "playerVehStateId", cr2w, this);
				}
				return _playerVehStateId;
			}
			set
			{
				if (_playerVehStateId == value)
				{
					return;
				}
				_playerVehStateId = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("screenVideoWidget")] 
		public wCHandle<inkVideoWidget> ScreenVideoWidget
		{
			get
			{
				if (_screenVideoWidget == null)
				{
					_screenVideoWidget = (wCHandle<inkVideoWidget>) CR2WTypeManager.Create("whandle:inkVideoWidget", "screenVideoWidget", cr2w, this);
				}
				return _screenVideoWidget;
			}
			set
			{
				if (_screenVideoWidget == value)
				{
					return;
				}
				_screenVideoWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("screenVideoWidgetPath")] 
		public CName ScreenVideoWidgetPath
		{
			get
			{
				if (_screenVideoWidgetPath == null)
				{
					_screenVideoWidgetPath = (CName) CR2WTypeManager.Create("CName", "screenVideoWidgetPath", cr2w, this);
				}
				return _screenVideoWidgetPath;
			}
			set
			{
				if (_screenVideoWidgetPath == value)
				{
					return;
				}
				_screenVideoWidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("videoPath")] 
		public redResourceReferenceScriptToken VideoPath
		{
			get
			{
				if (_videoPath == null)
				{
					_videoPath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "videoPath", cr2w, this);
				}
				return _videoPath;
			}
			set
			{
				if (_videoPath == value)
				{
					return;
				}
				_videoPath = value;
				PropertySet(this);
			}
		}

		public inkDexLimoGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
