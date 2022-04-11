using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AttributeBoughtEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("attributeType")] 
		public CEnum<gamedataStatType> AttributeType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}
	}
}
