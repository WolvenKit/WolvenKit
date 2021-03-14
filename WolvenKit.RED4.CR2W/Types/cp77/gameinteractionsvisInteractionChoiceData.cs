using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisInteractionChoiceData : CVariable
	{
		private CName _inputAction;
		private CEnum<EInputKey> _rawInputKey;
		private CBool _isHoldAction;
		private CString _localizedName;
		private gameinteractionsChoiceTypeWrapper _type;
		private CArray<CVariant> _data;
		private gameinteractionsChoiceCaption _captionParts;

		[Ordinal(0)] 
		[RED("inputAction")] 
		public CName InputAction
		{
			get
			{
				if (_inputAction == null)
				{
					_inputAction = (CName) CR2WTypeManager.Create("CName", "inputAction", cr2w, this);
				}
				return _inputAction;
			}
			set
			{
				if (_inputAction == value)
				{
					return;
				}
				_inputAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rawInputKey")] 
		public CEnum<EInputKey> RawInputKey
		{
			get
			{
				if (_rawInputKey == null)
				{
					_rawInputKey = (CEnum<EInputKey>) CR2WTypeManager.Create("EInputKey", "rawInputKey", cr2w, this);
				}
				return _rawInputKey;
			}
			set
			{
				if (_rawInputKey == value)
				{
					return;
				}
				_rawInputKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isHoldAction")] 
		public CBool IsHoldAction
		{
			get
			{
				if (_isHoldAction == null)
				{
					_isHoldAction = (CBool) CR2WTypeManager.Create("Bool", "isHoldAction", cr2w, this);
				}
				return _isHoldAction;
			}
			set
			{
				if (_isHoldAction == value)
				{
					return;
				}
				_isHoldAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get
			{
				if (_localizedName == null)
				{
					_localizedName = (CString) CR2WTypeManager.Create("String", "localizedName", cr2w, this);
				}
				return _localizedName;
			}
			set
			{
				if (_localizedName == value)
				{
					return;
				}
				_localizedName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("type")] 
		public gameinteractionsChoiceTypeWrapper Type
		{
			get
			{
				if (_type == null)
				{
					_type = (gameinteractionsChoiceTypeWrapper) CR2WTypeManager.Create("gameinteractionsChoiceTypeWrapper", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("data")] 
		public CArray<CVariant> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CArray<CVariant>) CR2WTypeManager.Create("array:Variant", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("captionParts")] 
		public gameinteractionsChoiceCaption CaptionParts
		{
			get
			{
				if (_captionParts == null)
				{
					_captionParts = (gameinteractionsChoiceCaption) CR2WTypeManager.Create("gameinteractionsChoiceCaption", "captionParts", cr2w, this);
				}
				return _captionParts;
			}
			set
			{
				if (_captionParts == value)
				{
					return;
				}
				_captionParts = value;
				PropertySet(this);
			}
		}

		public gameinteractionsvisInteractionChoiceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
