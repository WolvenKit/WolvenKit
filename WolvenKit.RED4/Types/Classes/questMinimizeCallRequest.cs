using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMinimizeCallRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("minimized")] 
		public CBool Minimized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questMinimizeCallRequest()
		{
			Minimized = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
