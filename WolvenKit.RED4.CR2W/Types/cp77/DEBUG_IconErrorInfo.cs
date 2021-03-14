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
			get
			{
				if (_itemName == null)
				{
					_itemName = (CString) CR2WTypeManager.Create("String", "itemName", cr2w, this);
				}
				return _itemName;
			}
			set
			{
				if (_itemName == value)
				{
					return;
				}
				_itemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("innerItemName")] 
		public CString InnerItemName
		{
			get
			{
				if (_innerItemName == null)
				{
					_innerItemName = (CString) CR2WTypeManager.Create("String", "innerItemName", cr2w, this);
				}
				return _innerItemName;
			}
			set
			{
				if (_innerItemName == value)
				{
					return;
				}
				_innerItemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("resolvedIconName")] 
		public CString ResolvedIconName
		{
			get
			{
				if (_resolvedIconName == null)
				{
					_resolvedIconName = (CString) CR2WTypeManager.Create("String", "resolvedIconName", cr2w, this);
				}
				return _resolvedIconName;
			}
			set
			{
				if (_resolvedIconName == value)
				{
					return;
				}
				_resolvedIconName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("errorMessage")] 
		public CString ErrorMessage
		{
			get
			{
				if (_errorMessage == null)
				{
					_errorMessage = (CString) CR2WTypeManager.Create("String", "errorMessage", cr2w, this);
				}
				return _errorMessage;
			}
			set
			{
				if (_errorMessage == value)
				{
					return;
				}
				_errorMessage = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("errorType")] 
		public CEnum<inkIconResult> ErrorType
		{
			get
			{
				if (_errorType == null)
				{
					_errorType = (CEnum<inkIconResult>) CR2WTypeManager.Create("inkIconResult", "errorType", cr2w, this);
				}
				return _errorType;
			}
			set
			{
				if (_errorType == value)
				{
					return;
				}
				_errorType = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isManuallySet")] 
		public CBool IsManuallySet
		{
			get
			{
				if (_isManuallySet == null)
				{
					_isManuallySet = (CBool) CR2WTypeManager.Create("Bool", "isManuallySet", cr2w, this);
				}
				return _isManuallySet;
			}
			set
			{
				if (_isManuallySet == value)
				{
					return;
				}
				_isManuallySet = value;
				PropertySet(this);
			}
		}

		public DEBUG_IconErrorInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
