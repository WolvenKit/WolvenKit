using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		}
	}
}
