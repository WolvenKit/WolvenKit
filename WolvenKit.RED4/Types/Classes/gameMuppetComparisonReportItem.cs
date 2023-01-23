using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetComparisonReportItem : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameMuppetComparisonReportItemType> Type
		{
			get => GetPropertyValue<CEnum<gameMuppetComparisonReportItemType>>();
			set => SetPropertyValue<CEnum<gameMuppetComparisonReportItemType>>(value);
		}

		[Ordinal(1)] 
		[RED("propertyName")] 
		public CString PropertyName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("serverValue")] 
		public CString ServerValue
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("clientValue")] 
		public CString ClientValue
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public gameMuppetComparisonReportItem()
		{
			Type = Enums.gameMuppetComparisonReportItemType.Equal;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
