using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisInteractionDisplayData : CVariable
	{
		private CName _putAction;
		private CEnum<EInputKey> _wInputKey;
		private CBool _holdAction;
		private CString _calizedName;
		private gameinteractionsChoiceTypeWrapper _pe;
		private gameinteractionsChoice _oice;

		[Ordinal(0)] 
		[RED("putAction")] 
		public CName PutAction
		{
			get
			{
				if (_putAction == null)
				{
					_putAction = (CName) CR2WTypeManager.Create("CName", "putAction", cr2w, this);
				}
				return _putAction;
			}
			set
			{
				if (_putAction == value)
				{
					return;
				}
				_putAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("wInputKey")] 
		public CEnum<EInputKey> WInputKey
		{
			get
			{
				if (_wInputKey == null)
				{
					_wInputKey = (CEnum<EInputKey>) CR2WTypeManager.Create("EInputKey", "wInputKey", cr2w, this);
				}
				return _wInputKey;
			}
			set
			{
				if (_wInputKey == value)
				{
					return;
				}
				_wInputKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("HoldAction")] 
		public CBool HoldAction
		{
			get
			{
				if (_holdAction == null)
				{
					_holdAction = (CBool) CR2WTypeManager.Create("Bool", "HoldAction", cr2w, this);
				}
				return _holdAction;
			}
			set
			{
				if (_holdAction == value)
				{
					return;
				}
				_holdAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("calizedName")] 
		public CString CalizedName
		{
			get
			{
				if (_calizedName == null)
				{
					_calizedName = (CString) CR2WTypeManager.Create("String", "calizedName", cr2w, this);
				}
				return _calizedName;
			}
			set
			{
				if (_calizedName == value)
				{
					return;
				}
				_calizedName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("pe")] 
		public gameinteractionsChoiceTypeWrapper Pe
		{
			get
			{
				if (_pe == null)
				{
					_pe = (gameinteractionsChoiceTypeWrapper) CR2WTypeManager.Create("gameinteractionsChoiceTypeWrapper", "pe", cr2w, this);
				}
				return _pe;
			}
			set
			{
				if (_pe == value)
				{
					return;
				}
				_pe = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("oice")] 
		public gameinteractionsChoice Oice
		{
			get
			{
				if (_oice == null)
				{
					_oice = (gameinteractionsChoice) CR2WTypeManager.Create("gameinteractionsChoice", "oice", cr2w, this);
				}
				return _oice;
			}
			set
			{
				if (_oice == value)
				{
					return;
				}
				_oice = value;
				PropertySet(this);
			}
		}

		public gameinteractionsvisInteractionDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
