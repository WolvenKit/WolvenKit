using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkShapeCollectionResource : CResource
	{
		private CArray<inkShapePreset> _presets;

		[Ordinal(1)] 
		[RED("presets")] 
		public CArray<inkShapePreset> Presets
		{
			get => GetProperty(ref _presets);
			set => SetProperty(ref _presets, value);
		}

		public inkShapeCollectionResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
