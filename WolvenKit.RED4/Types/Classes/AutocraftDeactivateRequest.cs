using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AutocraftDeactivateRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("resetMemory")] 
		public CBool ResetMemory
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AutocraftDeactivateRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
