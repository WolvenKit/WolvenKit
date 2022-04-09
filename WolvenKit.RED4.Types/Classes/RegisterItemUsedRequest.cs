using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RegisterItemUsedRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("itemUsed")] 
		public gameItemID ItemUsed
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public RegisterItemUsedRequest()
		{
			ItemUsed = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
