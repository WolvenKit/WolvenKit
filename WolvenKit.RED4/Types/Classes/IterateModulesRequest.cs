using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IterateModulesRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("remainingJobs")] 
		public CArray<HUDJob> RemainingJobs
		{
			get => GetPropertyValue<CArray<HUDJob>>();
			set => SetPropertyValue<CArray<HUDJob>>(value);
		}

		public IterateModulesRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
