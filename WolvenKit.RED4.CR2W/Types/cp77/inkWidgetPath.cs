using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetPath : CVariable
	{
		private CArray<CName> _names;

		[Ordinal(0)] 
		[RED("names")] 
		public CArray<CName> Names
		{
			get => GetProperty(ref _names);
			set => SetProperty(ref _names, value);
		}

		public inkWidgetPath(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
