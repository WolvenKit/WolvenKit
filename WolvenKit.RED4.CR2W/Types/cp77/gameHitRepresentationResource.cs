using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitRepresentationResource : CResource
	{
		private CArray<gameHitShapeContainer> _representations;
		private CArray<gameHitRepresentationVisualTaggedOverride> _overrides;

		[Ordinal(1)] 
		[RED("representations")] 
		public CArray<gameHitShapeContainer> Representations
		{
			get => GetProperty(ref _representations);
			set => SetProperty(ref _representations, value);
		}

		[Ordinal(2)] 
		[RED("overrides")] 
		public CArray<gameHitRepresentationVisualTaggedOverride> Overrides
		{
			get => GetProperty(ref _overrides);
			set => SetProperty(ref _overrides, value);
		}

		public gameHitRepresentationResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
