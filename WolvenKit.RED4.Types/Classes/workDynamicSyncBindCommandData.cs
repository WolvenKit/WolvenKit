using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workDynamicSyncBindCommandData : workIWorkspotCommandData
	{
		private entEntityID _masterID;

		[Ordinal(0)] 
		[RED("masterID")] 
		public entEntityID MasterID
		{
			get => GetProperty(ref _masterID);
			set => SetProperty(ref _masterID, value);
		}
	}
}
