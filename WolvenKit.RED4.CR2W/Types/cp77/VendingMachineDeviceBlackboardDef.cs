using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendingMachineDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Variant _actionStatus;
		private gamebbScriptID_Bool _soldOut;

		[Ordinal(7)] 
		[RED("ActionStatus")] 
		public gamebbScriptID_Variant ActionStatus
		{
			get
			{
				if (_actionStatus == null)
				{
					_actionStatus = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ActionStatus", cr2w, this);
				}
				return _actionStatus;
			}
			set
			{
				if (_actionStatus == value)
				{
					return;
				}
				_actionStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("SoldOut")] 
		public gamebbScriptID_Bool SoldOut
		{
			get
			{
				if (_soldOut == null)
				{
					_soldOut = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "SoldOut", cr2w, this);
				}
				return _soldOut;
			}
			set
			{
				if (_soldOut == value)
				{
					return;
				}
				_soldOut = value;
				PropertySet(this);
			}
		}

		public VendingMachineDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
