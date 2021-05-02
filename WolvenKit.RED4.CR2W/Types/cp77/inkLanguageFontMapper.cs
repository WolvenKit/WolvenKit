using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLanguageFontMapper : ISerializable
	{
		private CArray<inkLanguageFontMapping> _mappings;

		[Ordinal(0)] 
		[RED("mappings")] 
		public CArray<inkLanguageFontMapping> Mappings
		{
			get => GetProperty(ref _mappings);
			set => SetProperty(ref _mappings, value);
		}

		public inkLanguageFontMapper(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
