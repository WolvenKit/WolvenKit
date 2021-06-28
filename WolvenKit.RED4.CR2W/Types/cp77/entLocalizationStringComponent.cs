using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entLocalizationStringComponent : entIComponent
	{
		private CArray<entLocalizationStringMapEntry> _strings;

		[Ordinal(3)] 
		[RED("Strings")] 
		public CArray<entLocalizationStringMapEntry> Strings
		{
			get => GetProperty(ref _strings);
			set => SetProperty(ref _strings, value);
		}

		public entLocalizationStringComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
