using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RegisterActiveClueOwnerkRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public RegisterActiveClueOwnerkRequest()
		{
			OwnerID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
