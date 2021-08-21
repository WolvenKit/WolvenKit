using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entCorpseParameter : entEntityParameter
	{
		private CUInt32 _lod;
		private CArray<QsTransform> _bakedPose;
		private CArray<CName> _bakedBoneNames;
		private CArray<CRUID> _forceLOD0Components;
		private raRef<animRig> _baseRig;

		[Ordinal(0)] 
		[RED("lod")] 
		public CUInt32 Lod
		{
			get => GetProperty(ref _lod);
			set => SetProperty(ref _lod, value);
		}

		[Ordinal(1)] 
		[RED("bakedPose")] 
		public CArray<QsTransform> BakedPose
		{
			get => GetProperty(ref _bakedPose);
			set => SetProperty(ref _bakedPose, value);
		}

		[Ordinal(2)] 
		[RED("bakedBoneNames")] 
		public CArray<CName> BakedBoneNames
		{
			get => GetProperty(ref _bakedBoneNames);
			set => SetProperty(ref _bakedBoneNames, value);
		}

		[Ordinal(3)] 
		[RED("forceLOD0Components")] 
		public CArray<CRUID> ForceLOD0Components
		{
			get => GetProperty(ref _forceLOD0Components);
			set => SetProperty(ref _forceLOD0Components, value);
		}

		[Ordinal(4)] 
		[RED("baseRig")] 
		public raRef<animRig> BaseRig
		{
			get => GetProperty(ref _baseRig);
			set => SetProperty(ref _baseRig, value);
		}

		public entCorpseParameter(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
