using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gsmBaseRequestsHandler : inkISystemRequestsHandler
	{
		[Ordinal(19)] 
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
