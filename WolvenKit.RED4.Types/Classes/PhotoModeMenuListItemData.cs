using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PhotoModeMenuListItemData : ListItemData
	{
		[Ordinal(1)] 
		[RED("attributeKey")] 
		public CUInt32 AttributeKey
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
