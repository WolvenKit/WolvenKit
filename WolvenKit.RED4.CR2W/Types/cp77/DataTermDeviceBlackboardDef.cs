using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DataTermDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Variant _fastTravelPoint;
		private gamebbScriptID_Bool _triggerWorldMap;

		[Ordinal(7)] 
		[RED("fastTravelPoint")] 
		public gamebbScriptID_Variant FastTravelPoint
		{
			get
			{
				if (_fastTravelPoint == null)
				{
					_fastTravelPoint = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "fastTravelPoint", cr2w, this);
				}
				return _fastTravelPoint;
			}
			set
			{
				if (_fastTravelPoint == value)
				{
					return;
				}
				_fastTravelPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("triggerWorldMap")] 
		public gamebbScriptID_Bool TriggerWorldMap
		{
			get
			{
				if (_triggerWorldMap == null)
				{
					_triggerWorldMap = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "triggerWorldMap", cr2w, this);
				}
				return _triggerWorldMap;
			}
			set
			{
				if (_triggerWorldMap == value)
				{
					return;
				}
				_triggerWorldMap = value;
				PropertySet(this);
			}
		}

		public DataTermDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
