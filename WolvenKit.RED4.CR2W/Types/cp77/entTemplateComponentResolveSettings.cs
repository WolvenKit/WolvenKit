using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTemplateComponentResolveSettings : CVariable
	{
		private CName _componentName;
		private CName _nameParam;
		private CEnum<entTemplateComponentResolveMode> _mode;

		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get
			{
				if (_componentName == null)
				{
					_componentName = (CName) CR2WTypeManager.Create("CName", "componentName", cr2w, this);
				}
				return _componentName;
			}
			set
			{
				if (_componentName == value)
				{
					return;
				}
				_componentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("nameParam")] 
		public CName NameParam
		{
			get
			{
				if (_nameParam == null)
				{
					_nameParam = (CName) CR2WTypeManager.Create("CName", "nameParam", cr2w, this);
				}
				return _nameParam;
			}
			set
			{
				if (_nameParam == value)
				{
					return;
				}
				_nameParam = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("mode")] 
		public CEnum<entTemplateComponentResolveMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<entTemplateComponentResolveMode>) CR2WTypeManager.Create("entTemplateComponentResolveMode", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		public entTemplateComponentResolveSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
