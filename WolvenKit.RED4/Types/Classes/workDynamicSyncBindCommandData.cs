using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workDynamicSyncBindCommandData : workSyncBindBaseCommandData
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
			MasterID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
