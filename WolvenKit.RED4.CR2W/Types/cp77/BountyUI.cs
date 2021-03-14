using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BountyUI : CVariable
	{
		private CString _issuedBy;
		private CInt32 _moneyReward;
		private CInt32 _streetCredReward;
		private CArray<CString> _transgressions;
		private CBool _hasAccess;
		private CInt32 _level;

		[Ordinal(0)] 
		[RED("issuedBy")] 
		public CString IssuedBy
		{
			get
			{
				if (_issuedBy == null)
				{
					_issuedBy = (CString) CR2WTypeManager.Create("String", "issuedBy", cr2w, this);
				}
				return _issuedBy;
			}
			set
			{
				if (_issuedBy == value)
				{
					return;
				}
				_issuedBy = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("moneyReward")] 
		public CInt32 MoneyReward
		{
			get
			{
				if (_moneyReward == null)
				{
					_moneyReward = (CInt32) CR2WTypeManager.Create("Int32", "moneyReward", cr2w, this);
				}
				return _moneyReward;
			}
			set
			{
				if (_moneyReward == value)
				{
					return;
				}
				_moneyReward = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("streetCredReward")] 
		public CInt32 StreetCredReward
		{
			get
			{
				if (_streetCredReward == null)
				{
					_streetCredReward = (CInt32) CR2WTypeManager.Create("Int32", "streetCredReward", cr2w, this);
				}
				return _streetCredReward;
			}
			set
			{
				if (_streetCredReward == value)
				{
					return;
				}
				_streetCredReward = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("transgressions")] 
		public CArray<CString> Transgressions
		{
			get
			{
				if (_transgressions == null)
				{
					_transgressions = (CArray<CString>) CR2WTypeManager.Create("array:String", "transgressions", cr2w, this);
				}
				return _transgressions;
			}
			set
			{
				if (_transgressions == value)
				{
					return;
				}
				_transgressions = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("hasAccess")] 
		public CBool HasAccess
		{
			get
			{
				if (_hasAccess == null)
				{
					_hasAccess = (CBool) CR2WTypeManager.Create("Bool", "hasAccess", cr2w, this);
				}
				return _hasAccess;
			}
			set
			{
				if (_hasAccess == value)
				{
					return;
				}
				_hasAccess = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("level")] 
		public CInt32 Level
		{
			get
			{
				if (_level == null)
				{
					_level = (CInt32) CR2WTypeManager.Create("Int32", "level", cr2w, this);
				}
				return _level;
			}
			set
			{
				if (_level == value)
				{
					return;
				}
				_level = value;
				PropertySet(this);
			}
		}

		public BountyUI(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
