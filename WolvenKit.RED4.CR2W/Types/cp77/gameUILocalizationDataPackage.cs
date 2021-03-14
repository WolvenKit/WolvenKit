using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameUILocalizationDataPackage : IScriptable
	{
		private CArray<CFloat> _floatValues;
		private CArray<CInt32> _intValues;
		private CArray<CName> _nameValues;
		private CArray<CFloat> _statValues;
		private CArray<CName> _statNames;
		private CInt32 _paramsCount;
		private CHandle<textTextParameterSet> _textParams;

		[Ordinal(0)] 
		[RED("floatValues")] 
		public CArray<CFloat> FloatValues
		{
			get
			{
				if (_floatValues == null)
				{
					_floatValues = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "floatValues", cr2w, this);
				}
				return _floatValues;
			}
			set
			{
				if (_floatValues == value)
				{
					return;
				}
				_floatValues = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("intValues")] 
		public CArray<CInt32> IntValues
		{
			get
			{
				if (_intValues == null)
				{
					_intValues = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "intValues", cr2w, this);
				}
				return _intValues;
			}
			set
			{
				if (_intValues == value)
				{
					return;
				}
				_intValues = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("nameValues")] 
		public CArray<CName> NameValues
		{
			get
			{
				if (_nameValues == null)
				{
					_nameValues = (CArray<CName>) CR2WTypeManager.Create("array:CName", "nameValues", cr2w, this);
				}
				return _nameValues;
			}
			set
			{
				if (_nameValues == value)
				{
					return;
				}
				_nameValues = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("statValues")] 
		public CArray<CFloat> StatValues
		{
			get
			{
				if (_statValues == null)
				{
					_statValues = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "statValues", cr2w, this);
				}
				return _statValues;
			}
			set
			{
				if (_statValues == value)
				{
					return;
				}
				_statValues = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("statNames")] 
		public CArray<CName> StatNames
		{
			get
			{
				if (_statNames == null)
				{
					_statNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "statNames", cr2w, this);
				}
				return _statNames;
			}
			set
			{
				if (_statNames == value)
				{
					return;
				}
				_statNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("paramsCount")] 
		public CInt32 ParamsCount
		{
			get
			{
				if (_paramsCount == null)
				{
					_paramsCount = (CInt32) CR2WTypeManager.Create("Int32", "paramsCount", cr2w, this);
				}
				return _paramsCount;
			}
			set
			{
				if (_paramsCount == value)
				{
					return;
				}
				_paramsCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("textParams")] 
		public CHandle<textTextParameterSet> TextParams
		{
			get
			{
				if (_textParams == null)
				{
					_textParams = (CHandle<textTextParameterSet>) CR2WTypeManager.Create("handle:textTextParameterSet", "textParams", cr2w, this);
				}
				return _textParams;
			}
			set
			{
				if (_textParams == value)
				{
					return;
				}
				_textParams = value;
				PropertySet(this);
			}
		}

		public gameUILocalizationDataPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
