using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickHackSetDescriptionVisibilityRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuickHackSetDescriptionVisibilityRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
