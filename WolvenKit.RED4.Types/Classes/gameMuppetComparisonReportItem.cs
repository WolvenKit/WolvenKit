using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetComparisonReportItem : RedBaseClass
	{
		private CEnum<gameMuppetComparisonReportItemType> _type;
		private CString _propertyName;
		private CString _serverValue;
		private CString _clientValue;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameMuppetComparisonReportItemType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("propertyName")] 
		public CString PropertyName
		{
			get => GetProperty(ref _propertyName);
			set => SetProperty(ref _propertyName, value);
		}

		[Ordinal(2)] 
		[RED("serverValue")] 
		public CString ServerValue
		{
			get => GetProperty(ref _serverValue);
			set => SetProperty(ref _serverValue, value);
		}

		[Ordinal(3)] 
		[RED("clientValue")] 
		public CString ClientValue
		{
			get => GetProperty(ref _clientValue);
			set => SetProperty(ref _clientValue, value);
		}
	}
}
