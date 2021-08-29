using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RegisterItemUsedRequest : gameScriptableSystemRequest
	{
		private gameItemID _itemUsed;

		[Ordinal(0)] 
		[RED("itemUsed")] 
		public gameItemID ItemUsed
		{
			get => GetProperty(ref _itemUsed);
			set => SetProperty(ref _itemUsed, value);
		}
	}
}
