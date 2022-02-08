using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RevealStatusNotification : HUDManagerRequest
	{
		[Ordinal(1)] 
		[RED("isRevealed")] 
		public CBool IsRevealed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
