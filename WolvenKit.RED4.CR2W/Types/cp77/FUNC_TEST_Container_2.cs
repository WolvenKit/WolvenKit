using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FUNC_TEST_Container_2 : CVariable
	{
		private CFloat _floatBox;
		private CInt32 _intBox;
		private CBool _boolBox;
		private CName _nameBox;
		private CString _stringBox;
		private CName _cNameBox;
		private TweakDBID _tweakBox;

		[Ordinal(0)] 
		[RED("FloatBox")] 
		public CFloat FloatBox
		{
			get
			{
				if (_floatBox == null)
				{
					_floatBox = (CFloat) CR2WTypeManager.Create("Float", "FloatBox", cr2w, this);
				}
				return _floatBox;
			}
			set
			{
				if (_floatBox == value)
				{
					return;
				}
				_floatBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("IntBox")] 
		public CInt32 IntBox
		{
			get
			{
				if (_intBox == null)
				{
					_intBox = (CInt32) CR2WTypeManager.Create("Int32", "IntBox", cr2w, this);
				}
				return _intBox;
			}
			set
			{
				if (_intBox == value)
				{
					return;
				}
				_intBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("BoolBox")] 
		public CBool BoolBox
		{
			get
			{
				if (_boolBox == null)
				{
					_boolBox = (CBool) CR2WTypeManager.Create("Bool", "BoolBox", cr2w, this);
				}
				return _boolBox;
			}
			set
			{
				if (_boolBox == value)
				{
					return;
				}
				_boolBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("NameBox")] 
		public CName NameBox
		{
			get
			{
				if (_nameBox == null)
				{
					_nameBox = (CName) CR2WTypeManager.Create("CName", "NameBox", cr2w, this);
				}
				return _nameBox;
			}
			set
			{
				if (_nameBox == value)
				{
					return;
				}
				_nameBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("StringBox")] 
		public CString StringBox
		{
			get
			{
				if (_stringBox == null)
				{
					_stringBox = (CString) CR2WTypeManager.Create("String", "StringBox", cr2w, this);
				}
				return _stringBox;
			}
			set
			{
				if (_stringBox == value)
				{
					return;
				}
				_stringBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("CNameBox")] 
		public CName CNameBox
		{
			get
			{
				if (_cNameBox == null)
				{
					_cNameBox = (CName) CR2WTypeManager.Create("CName", "CNameBox", cr2w, this);
				}
				return _cNameBox;
			}
			set
			{
				if (_cNameBox == value)
				{
					return;
				}
				_cNameBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("TweakBox")] 
		public TweakDBID TweakBox
		{
			get
			{
				if (_tweakBox == null)
				{
					_tweakBox = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "TweakBox", cr2w, this);
				}
				return _tweakBox;
			}
			set
			{
				if (_tweakBox == value)
				{
					return;
				}
				_tweakBox = value;
				PropertySet(this);
			}
		}

		public FUNC_TEST_Container_2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
