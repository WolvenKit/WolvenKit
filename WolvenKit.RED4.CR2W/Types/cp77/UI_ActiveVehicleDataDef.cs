using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_ActiveVehicleDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _vehPlayerStateData;
		private gamebbScriptID_Bool _isPlayerMounted;
		private gamebbScriptID_Bool _isTPPCameraOn;
		private gamebbScriptID_Int32 _positionInRace;

		[Ordinal(0)] 
		[RED("VehPlayerStateData")] 
		public gamebbScriptID_Variant VehPlayerStateData
		{
			get
			{
				if (_vehPlayerStateData == null)
				{
					_vehPlayerStateData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "VehPlayerStateData", cr2w, this);
				}
				return _vehPlayerStateData;
			}
			set
			{
				if (_vehPlayerStateData == value)
				{
					return;
				}
				_vehPlayerStateData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("IsPlayerMounted")] 
		public gamebbScriptID_Bool IsPlayerMounted
		{
			get
			{
				if (_isPlayerMounted == null)
				{
					_isPlayerMounted = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsPlayerMounted", cr2w, this);
				}
				return _isPlayerMounted;
			}
			set
			{
				if (_isPlayerMounted == value)
				{
					return;
				}
				_isPlayerMounted = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("IsTPPCameraOn")] 
		public gamebbScriptID_Bool IsTPPCameraOn
		{
			get
			{
				if (_isTPPCameraOn == null)
				{
					_isTPPCameraOn = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsTPPCameraOn", cr2w, this);
				}
				return _isTPPCameraOn;
			}
			set
			{
				if (_isTPPCameraOn == value)
				{
					return;
				}
				_isTPPCameraOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("PositionInRace")] 
		public gamebbScriptID_Int32 PositionInRace
		{
			get
			{
				if (_positionInRace == null)
				{
					_positionInRace = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "PositionInRace", cr2w, this);
				}
				return _positionInRace;
			}
			set
			{
				if (_positionInRace == value)
				{
					return;
				}
				_positionInRace = value;
				PropertySet(this);
			}
		}

		public UI_ActiveVehicleDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
