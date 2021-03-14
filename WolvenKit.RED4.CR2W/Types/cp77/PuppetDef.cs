using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PuppetDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _isCrowd;
		private gamebbScriptID_Bool _hideNameplate;
		private gamebbScriptID_Bool _forceFriendlyCarry;
		private gamebbScriptID_Int32 _forcedCarryStyle;
		private gamebbScriptID_Bool _hasCPOMissionData;

		[Ordinal(0)] 
		[RED("IsCrowd")] 
		public gamebbScriptID_Bool IsCrowd
		{
			get
			{
				if (_isCrowd == null)
				{
					_isCrowd = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsCrowd", cr2w, this);
				}
				return _isCrowd;
			}
			set
			{
				if (_isCrowd == value)
				{
					return;
				}
				_isCrowd = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("HideNameplate")] 
		public gamebbScriptID_Bool HideNameplate
		{
			get
			{
				if (_hideNameplate == null)
				{
					_hideNameplate = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "HideNameplate", cr2w, this);
				}
				return _hideNameplate;
			}
			set
			{
				if (_hideNameplate == value)
				{
					return;
				}
				_hideNameplate = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ForceFriendlyCarry")] 
		public gamebbScriptID_Bool ForceFriendlyCarry
		{
			get
			{
				if (_forceFriendlyCarry == null)
				{
					_forceFriendlyCarry = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "ForceFriendlyCarry", cr2w, this);
				}
				return _forceFriendlyCarry;
			}
			set
			{
				if (_forceFriendlyCarry == value)
				{
					return;
				}
				_forceFriendlyCarry = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ForcedCarryStyle")] 
		public gamebbScriptID_Int32 ForcedCarryStyle
		{
			get
			{
				if (_forcedCarryStyle == null)
				{
					_forcedCarryStyle = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "ForcedCarryStyle", cr2w, this);
				}
				return _forcedCarryStyle;
			}
			set
			{
				if (_forcedCarryStyle == value)
				{
					return;
				}
				_forcedCarryStyle = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("HasCPOMissionData")] 
		public gamebbScriptID_Bool HasCPOMissionData
		{
			get
			{
				if (_hasCPOMissionData == null)
				{
					_hasCPOMissionData = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "HasCPOMissionData", cr2w, this);
				}
				return _hasCPOMissionData;
			}
			set
			{
				if (_hasCPOMissionData == value)
				{
					return;
				}
				_hasCPOMissionData = value;
				PropertySet(this);
			}
		}

		public PuppetDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
