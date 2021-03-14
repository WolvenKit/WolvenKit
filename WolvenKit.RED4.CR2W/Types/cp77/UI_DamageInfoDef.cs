using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_DamageInfoDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _damageList;
		private gamebbScriptID_Variant _killList;
		private gamebbScriptID_Variant _digitsMode;
		private gamebbScriptID_Bool _digitsInterpolationOn;
		private gamebbScriptID_Variant _digitsStickingMode;
		private gamebbScriptID_Bool _hitIndicatorEnabled;
		private gamebbScriptID_Variant _dmgIndicatorMode;

		[Ordinal(0)] 
		[RED("DamageList")] 
		public gamebbScriptID_Variant DamageList
		{
			get
			{
				if (_damageList == null)
				{
					_damageList = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "DamageList", cr2w, this);
				}
				return _damageList;
			}
			set
			{
				if (_damageList == value)
				{
					return;
				}
				_damageList = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("KillList")] 
		public gamebbScriptID_Variant KillList
		{
			get
			{
				if (_killList == null)
				{
					_killList = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "KillList", cr2w, this);
				}
				return _killList;
			}
			set
			{
				if (_killList == value)
				{
					return;
				}
				_killList = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("DigitsMode")] 
		public gamebbScriptID_Variant DigitsMode
		{
			get
			{
				if (_digitsMode == null)
				{
					_digitsMode = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "DigitsMode", cr2w, this);
				}
				return _digitsMode;
			}
			set
			{
				if (_digitsMode == value)
				{
					return;
				}
				_digitsMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("DigitsInterpolationOn")] 
		public gamebbScriptID_Bool DigitsInterpolationOn
		{
			get
			{
				if (_digitsInterpolationOn == null)
				{
					_digitsInterpolationOn = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "DigitsInterpolationOn", cr2w, this);
				}
				return _digitsInterpolationOn;
			}
			set
			{
				if (_digitsInterpolationOn == value)
				{
					return;
				}
				_digitsInterpolationOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("DigitsStickingMode")] 
		public gamebbScriptID_Variant DigitsStickingMode
		{
			get
			{
				if (_digitsStickingMode == null)
				{
					_digitsStickingMode = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "DigitsStickingMode", cr2w, this);
				}
				return _digitsStickingMode;
			}
			set
			{
				if (_digitsStickingMode == value)
				{
					return;
				}
				_digitsStickingMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("HitIndicatorEnabled")] 
		public gamebbScriptID_Bool HitIndicatorEnabled
		{
			get
			{
				if (_hitIndicatorEnabled == null)
				{
					_hitIndicatorEnabled = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "HitIndicatorEnabled", cr2w, this);
				}
				return _hitIndicatorEnabled;
			}
			set
			{
				if (_hitIndicatorEnabled == value)
				{
					return;
				}
				_hitIndicatorEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("DmgIndicatorMode")] 
		public gamebbScriptID_Variant DmgIndicatorMode
		{
			get
			{
				if (_dmgIndicatorMode == null)
				{
					_dmgIndicatorMode = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "DmgIndicatorMode", cr2w, this);
				}
				return _dmgIndicatorMode;
			}
			set
			{
				if (_dmgIndicatorMode == value)
				{
					return;
				}
				_dmgIndicatorMode = value;
				PropertySet(this);
			}
		}

		public UI_DamageInfoDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
