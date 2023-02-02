using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryItemStatComparison : IScriptable
	{
		[Ordinal(0)] 
		[RED("Type")] 
		public CEnum<gamedataStatType> Type
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(1)] 
		[RED("Value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public UIInventoryItemStatComparison()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
