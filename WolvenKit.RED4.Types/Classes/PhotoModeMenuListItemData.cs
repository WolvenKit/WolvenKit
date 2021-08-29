using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PhotoModeMenuListItemData : ListItemData
	{
		private CUInt32 _attributeKey;

		[Ordinal(1)] 
		[RED("attributeKey")] 
		public CUInt32 AttributeKey
		{
			get => GetProperty(ref _attributeKey);
			set => SetProperty(ref _attributeKey, value);
		}
	}
}
