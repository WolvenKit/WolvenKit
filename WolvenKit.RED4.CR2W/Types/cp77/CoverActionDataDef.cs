using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CoverActionDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _coverActionStateId;
		private gamebbScriptID_Bool _playerNearValidEdge;
		private gamebbScriptID_Bool _debugLeaning;
		private gamebbScriptID_Bool _debugAutoLeaning;
		private gamebbScriptID_Bool _debugDpadLeaning;
		private gamebbScriptID_Bool _debugLsLeaning;
		private gamebbScriptID_Bool _debugStagesLeaning;
		private gamebbScriptID_Bool _debugAdsLeaning;

		[Ordinal(0)] 
		[RED("coverActionStateId")] 
		public gamebbScriptID_Int32 CoverActionStateId
		{
			get
			{
				if (_coverActionStateId == null)
				{
					_coverActionStateId = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "coverActionStateId", cr2w, this);
				}
				return _coverActionStateId;
			}
			set
			{
				if (_coverActionStateId == value)
				{
					return;
				}
				_coverActionStateId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("playerNearValidEdge")] 
		public gamebbScriptID_Bool PlayerNearValidEdge
		{
			get
			{
				if (_playerNearValidEdge == null)
				{
					_playerNearValidEdge = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "playerNearValidEdge", cr2w, this);
				}
				return _playerNearValidEdge;
			}
			set
			{
				if (_playerNearValidEdge == value)
				{
					return;
				}
				_playerNearValidEdge = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("debugLeaning")] 
		public gamebbScriptID_Bool DebugLeaning
		{
			get
			{
				if (_debugLeaning == null)
				{
					_debugLeaning = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "debugLeaning", cr2w, this);
				}
				return _debugLeaning;
			}
			set
			{
				if (_debugLeaning == value)
				{
					return;
				}
				_debugLeaning = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("debugAutoLeaning")] 
		public gamebbScriptID_Bool DebugAutoLeaning
		{
			get
			{
				if (_debugAutoLeaning == null)
				{
					_debugAutoLeaning = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "debugAutoLeaning", cr2w, this);
				}
				return _debugAutoLeaning;
			}
			set
			{
				if (_debugAutoLeaning == value)
				{
					return;
				}
				_debugAutoLeaning = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("debugDpadLeaning")] 
		public gamebbScriptID_Bool DebugDpadLeaning
		{
			get
			{
				if (_debugDpadLeaning == null)
				{
					_debugDpadLeaning = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "debugDpadLeaning", cr2w, this);
				}
				return _debugDpadLeaning;
			}
			set
			{
				if (_debugDpadLeaning == value)
				{
					return;
				}
				_debugDpadLeaning = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("debugLsLeaning")] 
		public gamebbScriptID_Bool DebugLsLeaning
		{
			get
			{
				if (_debugLsLeaning == null)
				{
					_debugLsLeaning = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "debugLsLeaning", cr2w, this);
				}
				return _debugLsLeaning;
			}
			set
			{
				if (_debugLsLeaning == value)
				{
					return;
				}
				_debugLsLeaning = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("debugStagesLeaning")] 
		public gamebbScriptID_Bool DebugStagesLeaning
		{
			get
			{
				if (_debugStagesLeaning == null)
				{
					_debugStagesLeaning = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "debugStagesLeaning", cr2w, this);
				}
				return _debugStagesLeaning;
			}
			set
			{
				if (_debugStagesLeaning == value)
				{
					return;
				}
				_debugStagesLeaning = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("debugAdsLeaning")] 
		public gamebbScriptID_Bool DebugAdsLeaning
		{
			get
			{
				if (_debugAdsLeaning == null)
				{
					_debugAdsLeaning = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "debugAdsLeaning", cr2w, this);
				}
				return _debugAdsLeaning;
			}
			set
			{
				if (_debugAdsLeaning == value)
				{
					return;
				}
				_debugAdsLeaning = value;
				PropertySet(this);
			}
		}

		public CoverActionDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
