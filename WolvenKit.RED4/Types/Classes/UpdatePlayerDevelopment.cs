using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UpdatePlayerDevelopment : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("ForceRefresh")] 
		public CBool ForceRefresh
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UpdatePlayerDevelopment()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
