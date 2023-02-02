using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SendInstructionRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("jobs")] 
		public CArray<HUDJob> Jobs
		{
			get => GetPropertyValue<CArray<HUDJob>>();
			set => SetPropertyValue<CArray<HUDJob>>(value);
		}

		public SendInstructionRequest()
		{
			Jobs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
