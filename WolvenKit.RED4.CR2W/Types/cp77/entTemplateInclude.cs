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
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("template")] 
		public raRef<entEntityTemplate> Template
		{
			get => GetProperty(ref _template);
			set => SetProperty(ref _template, value);
		}

		public entTemplateInclude(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
