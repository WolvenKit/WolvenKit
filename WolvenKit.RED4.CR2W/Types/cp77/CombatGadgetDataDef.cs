using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CombatGadgetDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _throwUnequip;
		private gamebbScriptID_Float _lastThrowAngle;
		private gamebbScriptID_Vector4 _lastThrowPosition;
		private gamebbScriptID_Variant _lastThrowStartType;

		[Ordinal(0)] 
		[RED("throwUnequip")] 
		public gamebbScriptID_Bool ThrowUnequip
		{
			get
			{
				if (_throwUnequip == null)
				{
					_throwUnequip = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "throwUnequip", cr2w, this);
				}
				return _throwUnequip;
			}
			set
			{
				if (_throwUnequip == value)
				{
					return;
				}
				_throwUnequip = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lastThrowAngle")] 
		public gamebbScriptID_Float LastThrowAngle
		{
			get
			{
				if (_lastThrowAngle == null)
				{
					_lastThrowAngle = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "lastThrowAngle", cr2w, this);
				}
				return _lastThrowAngle;
			}
			set
			{
				if (_lastThrowAngle == value)
				{
					return;
				}
				_lastThrowAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lastThrowPosition")] 
		public gamebbScriptID_Vector4 LastThrowPosition
		{
			get
			{
				if (_lastThrowPosition == null)
				{
					_lastThrowPosition = (gamebbScriptID_Vector4) CR2WTypeManager.Create("gamebbScriptID_Vector4", "lastThrowPosition", cr2w, this);
				}
				return _lastThrowPosition;
			}
			set
			{
				if (_lastThrowPosition == value)
				{
					return;
				}
				_lastThrowPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lastThrowStartType")] 
		public gamebbScriptID_Variant LastThrowStartType
		{
			get
			{
				if (_lastThrowStartType == null)
				{
					_lastThrowStartType = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "lastThrowStartType", cr2w, this);
				}
				return _lastThrowStartType;
			}
			set
			{
				if (_lastThrowStartType == value)
				{
					return;
				}
				_lastThrowStartType = value;
				PropertySet(this);
			}
		}

		public CombatGadgetDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
