using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsclothPhaseConfig : CVariable
	{
		private CFloat _stiffness;
		private CFloat _stiffnessMultiplier;
		private CFloat _compressionLimit;
		private CFloat _stretchLimit;

		[Ordinal(0)] 
		[RED("stiffness")] 
		public CFloat Stiffness
		{
			get => GetProperty(ref _stiffness);
			set => SetProperty(ref _stiffness, value);
		}

		[Ordinal(1)] 
		[RED("stiffnessMultiplier")] 
		public CFloat StiffnessMultiplier
		{
			get => GetProperty(ref _stiffnessMultiplier);
			set => SetProperty(ref _stiffnessMultiplier, value);
		}

		[Ordinal(2)] 
		[RED("compressionLimit")] 
		public CFloat CompressionLimit
		{
			get => GetProperty(ref _compressionLimit);
			set => SetProperty(ref _compressionLimit, value);
		}

		[Ordinal(3)] 
		[RED("stretchLimit")] 
		public CFloat StretchLimit
		{
			get => GetProperty(ref _stretchLimit);
			set => SetProperty(ref _stretchLimit, value);
		}

		public physicsclothPhaseConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
