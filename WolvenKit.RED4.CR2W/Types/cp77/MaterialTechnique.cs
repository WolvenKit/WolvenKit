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
			get
			{
				if (_passes == null)
				{
					_passes = (CArray<MaterialPass>) CR2WTypeManager.Create("array:MaterialPass", "passes", cr2w, this);
				}
				return _passes;
			}
			set
			{
				if (_passes == value)
				{
					return;
				}
				_passes = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("featureFlagsEnabledMask")] 
		public FeatureFlagsMask FeatureFlagsEnabledMask
		{
			get
			{
				if (_featureFlagsEnabledMask == null)
				{
					_featureFlagsEnabledMask = (FeatureFlagsMask) CR2WTypeManager.Create("FeatureFlagsMask", "featureFlagsEnabledMask", cr2w, this);
				}
				return _featureFlagsEnabledMask;
			}
			set
			{
				if (_featureFlagsEnabledMask == value)
				{
					return;
				}
				_featureFlagsEnabledMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("streamsToBind")] 
		public CUInt32 StreamsToBind
		{
			get
			{
				if (_streamsToBind == null)
				{
					_streamsToBind = (CUInt32) CR2WTypeManager.Create("Uint32", "streamsToBind", cr2w, this);
				}
				return _streamsToBind;
			}
			set
			{
				if (_streamsToBind == value)
				{
					return;
				}
				_streamsToBind = value;
				PropertySet(this);
			}
		}

		public MaterialTechnique(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
