using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleCustomActionDeviceOperation : DeviceOperationBase
	{
		private CName _customActionID;
		private CBool _enabled;

		[Ordinal(5)] 
		[RED("customActionID")] 
		public CName CustomActionID
		{
			get => GetProperty(ref _customActionID);
			set => SetProperty(ref _customActionID, value);
		}

		[Ordinal(6)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		public ToggleCustomActionDeviceOperation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
