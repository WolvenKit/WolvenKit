using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLocalizedBink : CVariable
	{
		private CArray<inkBinkLanguageDescriptor> _binks;

		[Ordinal(0)] 
		[RED("binks")] 
		public CArray<inkBinkLanguageDescriptor> Binks
		{
			get => GetProperty(ref _binks);
			set => SetProperty(ref _binks, value);
		}

		public inkLocalizedBink(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
