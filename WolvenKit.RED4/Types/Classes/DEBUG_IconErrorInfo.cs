using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DEBUG_IconErrorInfo : IScriptable
	{
		[Ordinal(0)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("innerItemName")] 
		public CString InnerItemName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("resolvedIconName")] 
		public CString ResolvedIconName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("errorMessage")] 
		public CString ErrorMessage
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("errorType")] 
		public CEnum<inkIconResult> ErrorType
		{
			get => GetPropertyValue<CEnum<inkIconResult>>();
			set => SetPropertyValue<CEnum<inkIconResult>>(value);
		}

		[Ordinal(5)] 
		[RED("isManuallySet")] 
		public CBool IsManuallySet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DEBUG_IconErrorInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
