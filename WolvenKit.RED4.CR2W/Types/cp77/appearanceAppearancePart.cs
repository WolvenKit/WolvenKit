using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class appearanceAppearancePart : CVariable
	{
		private raRef<entEntityTemplate> _resource;

		[Ordinal(0)] 
		[RED("resource")] 
		public raRef<entEntityTemplate> Resource
		{
			get => GetProperty(ref _resource);
			set => SetProperty(ref _resource, value);
		}

		public appearanceAppearancePart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
