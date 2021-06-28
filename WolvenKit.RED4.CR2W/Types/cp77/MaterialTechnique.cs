using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MaterialTechnique : CVariable
	{
		private CArray<MaterialPass> _passes;
		private FeatureFlagsMask _featureFlagsEnabledMask;
		private CUInt32 _streamsToBind;

		[Ordinal(0)] 
		[RED("passes")] 
		public CArray<MaterialPass> Passes
		{
			get => GetProperty(ref _passes);
			set => SetProperty(ref _passes, value);
		}

		[Ordinal(1)] 
		[RED("featureFlagsEnabledMask")] 
		public FeatureFlagsMask FeatureFlagsEnabledMask
		{
			get => GetProperty(ref _featureFlagsEnabledMask);
			set => SetProperty(ref _featureFlagsEnabledMask, value);
		}

		[Ordinal(2)] 
		[RED("streamsToBind")] 
		public CUInt32 StreamsToBind
		{
			get => GetProperty(ref _streamsToBind);
			set => SetProperty(ref _streamsToBind, value);
		}

		public MaterialTechnique(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
