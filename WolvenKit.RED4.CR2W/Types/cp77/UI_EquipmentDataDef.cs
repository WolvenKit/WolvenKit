using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_EquipmentDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _equipmentData;
		private gamebbScriptID_Variant _uIjailbreakData;
		private gamebbScriptID_Bool _ammoLooted;

		[Ordinal(0)] 
		[RED("EquipmentData")] 
		public gamebbScriptID_Variant EquipmentData
		{
			get
			{
				if (_equipmentData == null)
				{
					_equipmentData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "EquipmentData", cr2w, this);
				}
				return _equipmentData;
			}
			set
			{
				if (_equipmentData == value)
				{
					return;
				}
				_equipmentData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("UIjailbreakData")] 
		public gamebbScriptID_Variant UIjailbreakData
		{
			get
			{
				if (_uIjailbreakData == null)
				{
					_uIjailbreakData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "UIjailbreakData", cr2w, this);
				}
				return _uIjailbreakData;
			}
			set
			{
				if (_uIjailbreakData == value)
				{
					return;
				}
				_uIjailbreakData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ammoLooted")] 
		public gamebbScriptID_Bool AmmoLooted
		{
			get
			{
				if (_ammoLooted == null)
				{
					_ammoLooted = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "ammoLooted", cr2w, this);
				}
				return _ammoLooted;
			}
			set
			{
				if (_ammoLooted == value)
				{
					return;
				}
				_ammoLooted = value;
				PropertySet(this);
			}
		}

		public UI_EquipmentDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
