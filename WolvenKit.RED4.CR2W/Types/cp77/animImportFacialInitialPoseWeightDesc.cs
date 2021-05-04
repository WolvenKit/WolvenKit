using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animImportFacialInitialPoseWeightDesc : CVariable
	{
		private CArray<CName> _poseNames;
		private CArray<CFloat> _weights;

		[Ordinal(0)] 
		[RED("poseNames")] 
		public CArray<CName> PoseNames
		{
			get => GetProperty(ref _poseNames);
			set => SetProperty(ref _poseNames, value);
		}

		[Ordinal(1)] 
		[RED("weights")] 
		public CArray<CFloat> Weights
		{
			get => GetProperty(ref _weights);
			set => SetProperty(ref _weights, value);
		}

		public animImportFacialInitialPoseWeightDesc(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
