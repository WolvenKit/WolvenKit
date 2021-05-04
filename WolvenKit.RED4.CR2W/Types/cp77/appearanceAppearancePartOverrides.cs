using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class appearanceAppearancePartOverrides : CVariable
	{
		private raRef<entEntityTemplate> _partResource;
		private CArray<appearancePartComponentOverrides> _componentsOverrides;

		[Ordinal(0)] 
		[RED("partResource")] 
		public raRef<entEntityTemplate> PartResource
		{
			get => GetProperty(ref _partResource);
			set => SetProperty(ref _partResource, value);
		}

		[Ordinal(1)] 
		[RED("componentsOverrides")] 
		public CArray<appearancePartComponentOverrides> ComponentsOverrides
		{
			get => GetProperty(ref _componentsOverrides);
			set => SetProperty(ref _componentsOverrides, value);
		}

		public appearanceAppearancePartOverrides(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
