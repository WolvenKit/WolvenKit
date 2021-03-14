using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomCentaurBlackboardDef : CustomBlackboardDef
	{
		private gamebbScriptID_Int32 _shieldState;
		private gamebbScriptID_Float _weakSpotHitTimeStamp;
		private gamebbScriptID_EntityID _shieldTarget;
		private gamebbScriptID_Float _woundedStateHPThreshold;

		[Ordinal(0)] 
		[RED("ShieldState")] 
		public gamebbScriptID_Int32 ShieldState
		{
			get
			{
				if (_shieldState == null)
				{
					_shieldState = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "ShieldState", cr2w, this);
				}
				return _shieldState;
			}
			set
			{
				if (_shieldState == value)
				{
					return;
				}
				_shieldState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("WeakSpotHitTimeStamp")] 
		public gamebbScriptID_Float WeakSpotHitTimeStamp
		{
			get
			{
				if (_weakSpotHitTimeStamp == null)
				{
					_weakSpotHitTimeStamp = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "WeakSpotHitTimeStamp", cr2w, this);
				}
				return _weakSpotHitTimeStamp;
			}
			set
			{
				if (_weakSpotHitTimeStamp == value)
				{
					return;
				}
				_weakSpotHitTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ShieldTarget")] 
		public gamebbScriptID_EntityID ShieldTarget
		{
			get
			{
				if (_shieldTarget == null)
				{
					_shieldTarget = (gamebbScriptID_EntityID) CR2WTypeManager.Create("gamebbScriptID_EntityID", "ShieldTarget", cr2w, this);
				}
				return _shieldTarget;
			}
			set
			{
				if (_shieldTarget == value)
				{
					return;
				}
				_shieldTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("WoundedStateHPThreshold")] 
		public gamebbScriptID_Float WoundedStateHPThreshold
		{
			get
			{
				if (_woundedStateHPThreshold == null)
				{
					_woundedStateHPThreshold = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "WoundedStateHPThreshold", cr2w, this);
				}
				return _woundedStateHPThreshold;
			}
			set
			{
				if (_woundedStateHPThreshold == value)
				{
					return;
				}
				_woundedStateHPThreshold = value;
				PropertySet(this);
			}
		}

		public CustomCentaurBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
