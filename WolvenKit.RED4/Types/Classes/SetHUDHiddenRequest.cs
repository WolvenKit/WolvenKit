using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetHUDHiddenRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("hidden")] 
		public CBool Hidden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetHUDHiddenRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
