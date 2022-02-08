using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationAttribute : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataStatType> Type
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CUInt32 Value
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
