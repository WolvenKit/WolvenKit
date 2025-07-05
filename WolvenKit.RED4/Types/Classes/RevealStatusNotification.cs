using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RevealStatusNotification : HUDManagerRequest
	{
		[Ordinal(1)] 
		[RED("isRevealed")] 
		public CBool IsRevealed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RevealStatusNotification()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
