using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DebugDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _weaponSpread_EvenDistributionRowCount;
		private gamebbScriptID_Int32 _weaponSpread_ProjectilesPerShot;
		private gamebbScriptID_Bool _weaponSpread_UseCircularSpread;
		private gamebbScriptID_Bool _weaponSpread_UseEvenDistribution;
		private gamebbScriptID_Bool _vehicle_BlockSwitchSeats;

		[Ordinal(0)] 
		[RED("WeaponSpread_EvenDistributionRowCount")] 
		public gamebbScriptID_Int32 WeaponSpread_EvenDistributionRowCount
		{
			get
			{
				if (_weaponSpread_EvenDistributionRowCount == null)
				{
					_weaponSpread_EvenDistributionRowCount = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "WeaponSpread_EvenDistributionRowCount", cr2w, this);
				}
				return _weaponSpread_EvenDistributionRowCount;
			}
			set
			{
				if (_weaponSpread_EvenDistributionRowCount == value)
				{
					return;
				}
				_weaponSpread_EvenDistributionRowCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("WeaponSpread_ProjectilesPerShot")] 
		public gamebbScriptID_Int32 WeaponSpread_ProjectilesPerShot
		{
			get
			{
				if (_weaponSpread_ProjectilesPerShot == null)
				{
					_weaponSpread_ProjectilesPerShot = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "WeaponSpread_ProjectilesPerShot", cr2w, this);
				}
				return _weaponSpread_ProjectilesPerShot;
			}
			set
			{
				if (_weaponSpread_ProjectilesPerShot == value)
				{
					return;
				}
				_weaponSpread_ProjectilesPerShot = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("WeaponSpread_UseCircularSpread")] 
		public gamebbScriptID_Bool WeaponSpread_UseCircularSpread
		{
			get
			{
				if (_weaponSpread_UseCircularSpread == null)
				{
					_weaponSpread_UseCircularSpread = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "WeaponSpread_UseCircularSpread", cr2w, this);
				}
				return _weaponSpread_UseCircularSpread;
			}
			set
			{
				if (_weaponSpread_UseCircularSpread == value)
				{
					return;
				}
				_weaponSpread_UseCircularSpread = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("WeaponSpread_UseEvenDistribution")] 
		public gamebbScriptID_Bool WeaponSpread_UseEvenDistribution
		{
			get
			{
				if (_weaponSpread_UseEvenDistribution == null)
				{
					_weaponSpread_UseEvenDistribution = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "WeaponSpread_UseEvenDistribution", cr2w, this);
				}
				return _weaponSpread_UseEvenDistribution;
			}
			set
			{
				if (_weaponSpread_UseEvenDistribution == value)
				{
					return;
				}
				_weaponSpread_UseEvenDistribution = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("Vehicle_BlockSwitchSeats")] 
		public gamebbScriptID_Bool Vehicle_BlockSwitchSeats
		{
			get
			{
				if (_vehicle_BlockSwitchSeats == null)
				{
					_vehicle_BlockSwitchSeats = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "Vehicle_BlockSwitchSeats", cr2w, this);
				}
				return _vehicle_BlockSwitchSeats;
			}
			set
			{
				if (_vehicle_BlockSwitchSeats == value)
				{
					return;
				}
				_vehicle_BlockSwitchSeats = value;
				PropertySet(this);
			}
		}

		public DebugDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
