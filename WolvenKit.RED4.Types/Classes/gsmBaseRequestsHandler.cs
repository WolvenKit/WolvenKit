using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gsmBaseRequestsHandler : inkISystemRequestsHandler
	{
		[Ordinal(10)] 
		[RED("SavingComplete")] 
		public gsmSavingRequesResult SavingComplete
		{
			get => GetPropertyValue<gsmSavingRequesResult>();
			set => SetPropertyValue<gsmSavingRequesResult>(value);
		}

		public gsmBaseRequestsHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
