using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DEBUG_IconErrorInfo : IScriptable
	{
		private CString _itemName;
		private CString _innerItemName;
		private CString _resolvedIconName;
		private CString _errorMessage;
		private CEnum<inkIconResult> _errorType;
		private CBool _isManuallySet;

		[Ordinal(0)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		[Ordinal(1)] 
		[RED("innerItemName")] 
		public CString InnerItemName
		{
			get => GetProperty(ref _innerItemName);
			set => SetProperty(ref _innerItemName, value);
		}

		[Ordinal(2)] 
		[RED("resolvedIconName")] 
		public CString ResolvedIconName
		{
			get => GetProperty(ref _resolvedIconName);
			set => SetProperty(ref _resolvedIconName, value);
		}

		[Ordinal(3)] 
		[RED("errorMessage")] 
		public CString ErrorMessage
		{
			get => GetProperty(ref _errorMessage);
			set => SetProperty(ref _errorMessage, value);
		}

		[Ordinal(4)] 
		[RED("errorType")] 
		public CEnum<inkIconResult> ErrorType
		{
			get => GetProperty(ref _errorType);
			set => SetProperty(ref _errorType, value);
		}

		[Ordinal(5)] 
		[RED("isManuallySet")] 
		public CBool IsManuallySet
		{
			get => GetProperty(ref _isManuallySet);
			set => SetProperty(ref _isManuallySet, value);
		}

		public DEBUG_IconErrorInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
