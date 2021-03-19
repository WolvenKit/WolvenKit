using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetComparisonReportItem : CVariable
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

		public gameMuppetComparisonReportItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
