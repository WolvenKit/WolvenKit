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
			get => GetProperty(ref _actionID);
			set => SetProperty(ref _actionID, value);
		}

		public CustomActionOperationTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
