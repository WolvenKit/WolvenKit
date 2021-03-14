using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIArgumentMapping : IScriptable
	{
		private CEnum<AIArgumentType> _type;
		private CEnum<AIParameterizationType> _parameterizationType;
		private CVariant _defaultValue;
		private CHandle<AIArgumentMapping> _prefixValue;
		private CName _customTypeName;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<AIArgumentType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<AIArgumentType>) CR2WTypeManager.Create("AIArgumentType", "type", cr2w, this);
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

		[Ordinal(1)] 
		[RED("parameterizationType")] 
		public CEnum<AIParameterizationType> ParameterizationType
		{
			get
			{
				if (_parameterizationType == null)
				{
					_parameterizationType = (CEnum<AIParameterizationType>) CR2WTypeManager.Create("AIParameterizationType", "parameterizationType", cr2w, this);
				}
				return _parameterizationType;
			}
			set
			{
				if (_parameterizationType == value)
				{
					return;
				}
				_parameterizationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("defaultValue")] 
		public CVariant DefaultValue
		{
			get
			{
				if (_defaultValue == null)
				{
					_defaultValue = (CVariant) CR2WTypeManager.Create("Variant", "defaultValue", cr2w, this);
				}
				return _defaultValue;
			}
			set
			{
				if (_defaultValue == value)
				{
					return;
				}
				_defaultValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("prefixValue")] 
		public CHandle<AIArgumentMapping> PrefixValue
		{
			get
			{
				if (_prefixValue == null)
				{
					_prefixValue = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "prefixValue", cr2w, this);
				}
				return _prefixValue;
			}
			set
			{
				if (_prefixValue == value)
				{
					return;
				}
				_prefixValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("customTypeName")] 
		public CName CustomTypeName
		{
			get
			{
				if (_customTypeName == null)
				{
					_customTypeName = (CName) CR2WTypeManager.Create("CName", "customTypeName", cr2w, this);
				}
				return _customTypeName;
			}
			set
			{
				if (_customTypeName == value)
				{
					return;
				}
				_customTypeName = value;
				PropertySet(this);
			}
		}

		public AIArgumentMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
