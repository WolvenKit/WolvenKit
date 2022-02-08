using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workDynamicSyncBindCommandData : workIWorkspotCommandData
	{
		[Ordinal(0)] 
		[RED("masterID")] 
		public entEntityID MasterID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public workDynamicSyncBindCommandData()
		{
			MasterID = new();
		}
	}
}
