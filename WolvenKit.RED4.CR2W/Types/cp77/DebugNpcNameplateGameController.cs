using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DebugNpcNameplateGameController : gameuiProjectedHUDGameController
	{
		private CBool _isToggledOn;
		private CHandle<gameIBlackboard> _uiBlackboard;
		private CUInt32 _bbNPCStatsInfo;
		private CHandle<inkScreenProjection> _nameplateProjection;
		private wCHandle<gameObject> _bufferedNPC;
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<inkTextWidget> _debugText1;
		private wCHandle<inkTextWidget> _debugText2;

		[Ordinal(9)] 
		[RED("isToggledOn")] 
		public CBool IsToggledOn
		{
			get
			{
				if (_isToggledOn == null)
				{
					_isToggledOn = (CBool) CR2WTypeManager.Create("Bool", "isToggledOn", cr2w, this);
				}
				return _isToggledOn;
			}
			set
			{
				if (_isToggledOn == value)
				{
					return;
				}
				_isToggledOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("uiBlackboard")] 
		public CHandle<gameIBlackboard> UiBlackboard
		{
			get
			{
				if (_uiBlackboard == null)
				{
					_uiBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "uiBlackboard", cr2w, this);
				}
				return _uiBlackboard;
			}
			set
			{
				if (_uiBlackboard == value)
				{
					return;
				}
				_uiBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("bbNPCStatsInfo")] 
		public CUInt32 BbNPCStatsInfo
		{
			get
			{
				if (_bbNPCStatsInfo == null)
				{
					_bbNPCStatsInfo = (CUInt32) CR2WTypeManager.Create("Uint32", "bbNPCStatsInfo", cr2w, this);
				}
				return _bbNPCStatsInfo;
			}
			set
			{
				if (_bbNPCStatsInfo == value)
				{
					return;
				}
				_bbNPCStatsInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("nameplateProjection")] 
		public CHandle<inkScreenProjection> NameplateProjection
		{
			get
			{
				if (_nameplateProjection == null)
				{
					_nameplateProjection = (CHandle<inkScreenProjection>) CR2WTypeManager.Create("handle:inkScreenProjection", "nameplateProjection", cr2w, this);
				}
				return _nameplateProjection;
			}
			set
			{
				if (_nameplateProjection == value)
				{
					return;
				}
				_nameplateProjection = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("bufferedNPC")] 
		public wCHandle<gameObject> BufferedNPC
		{
			get
			{
				if (_bufferedNPC == null)
				{
					_bufferedNPC = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "bufferedNPC", cr2w, this);
				}
				return _bufferedNPC;
			}
			set
			{
				if (_bufferedNPC == value)
				{
					return;
				}
				_bufferedNPC = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("debugText1")] 
		public wCHandle<inkTextWidget> DebugText1
		{
			get
			{
				if (_debugText1 == null)
				{
					_debugText1 = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "debugText1", cr2w, this);
				}
				return _debugText1;
			}
			set
			{
				if (_debugText1 == value)
				{
					return;
				}
				_debugText1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("debugText2")] 
		public wCHandle<inkTextWidget> DebugText2
		{
			get
			{
				if (_debugText2 == null)
				{
					_debugText2 = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "debugText2", cr2w, this);
				}
				return _debugText2;
			}
			set
			{
				if (_debugText2 == value)
				{
					return;
				}
				_debugText2 = value;
				PropertySet(this);
			}
		}

		public DebugNpcNameplateGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
