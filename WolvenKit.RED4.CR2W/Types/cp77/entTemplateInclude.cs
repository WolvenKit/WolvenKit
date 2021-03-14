using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTemplateInclude : CVariable
	{
		private CName _name;
		private raRef<entEntityTemplate> _template;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("template")] 
		public raRef<entEntityTemplate> Template
		{
			get
			{
				if (_template == null)
				{
					_template = (raRef<entEntityTemplate>) CR2WTypeManager.Create("raRef:entEntityTemplate", "template", cr2w, this);
				}
				return _template;
			}
			set
			{
				if (_template == value)
				{
					return;
				}
				_template = value;
				PropertySet(this);
			}
		}

		public entTemplateInclude(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
