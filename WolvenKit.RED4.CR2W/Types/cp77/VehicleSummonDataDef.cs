using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleSummonDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Uint32 _garageState;
		private gamebbScriptID_Uint32 _unlockedVehiclesCount;
		private gamebbScriptID_Uint32 _summonState;
		private gamebbScriptID_EntityID _summonedVehicleEntityID;

		[Ordinal(0)] 
		[RED("GarageState")] 
		public gamebbScriptID_Uint32 GarageState
		{
			get
			{
				if (_garageState == null)
				{
					_garageState = (gamebbScriptID_Uint32) CR2WTypeManager.Create("gamebbScriptID_Uint32", "GarageState", cr2w, this);
				}
				return _garageState;
			}
			set
			{
				if (_garageState == value)
				{
					return;
				}
				_garageState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("UnlockedVehiclesCount")] 
		public gamebbScriptID_Uint32 UnlockedVehiclesCount
		{
			get
			{
				if (_unlockedVehiclesCount == null)
				{
					_unlockedVehiclesCount = (gamebbScriptID_Uint32) CR2WTypeManager.Create("gamebbScriptID_Uint32", "UnlockedVehiclesCount", cr2w, this);
				}
				return _unlockedVehiclesCount;
			}
			set
			{
				if (_unlockedVehiclesCount == value)
				{
					return;
				}
				_unlockedVehiclesCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("SummonState")] 
		public gamebbScriptID_Uint32 SummonState
		{
			get
			{
				if (_summonState == null)
				{
					_summonState = (gamebbScriptID_Uint32) CR2WTypeManager.Create("gamebbScriptID_Uint32", "SummonState", cr2w, this);
				}
				return _summonState;
			}
			set
			{
				if (_summonState == value)
				{
					return;
				}
				_summonState = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("SummonedVehicleEntityID")] 
		public gamebbScriptID_EntityID SummonedVehicleEntityID
		{
			get
			{
				if (_summonedVehicleEntityID == null)
				{
					_summonedVehicleEntityID = (gamebbScriptID_EntityID) CR2WTypeManager.Create("gamebbScriptID_EntityID", "SummonedVehicleEntityID", cr2w, this);
				}
				return _summonedVehicleEntityID;
			}
			set
			{
				if (_summonedVehicleEntityID == value)
				{
					return;
				}
				_summonedVehicleEntityID = value;
				PropertySet(this);
			}
		}

		public VehicleSummonDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
