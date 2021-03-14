using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomActionOperationTriggerData : DeviceOperationTriggerData
	{
		private CName _actionID;

		[Ordinal(1)] 
		[RED("actionID")] 
		public CName ActionID
		{
			get
			{
				if (_actionID == null)
				{
					_actionID = (CName) CR2WTypeManager.Create("CName", "actionID", cr2w, this);
				}
				return _actionID;
			}
			set
			{
				if (_actionID == value)
				{
					return;
				}
				_actionID = value;
				PropertySet(this);
			}
		}

		public CustomActionOperationTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
