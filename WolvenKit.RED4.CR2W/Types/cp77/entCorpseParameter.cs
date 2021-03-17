using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entCorpseParameter : entEntityParameter
	{
		private CUInt32 _lod;
		private CArray<QsTransform> _bones;
		private CArray<raRef<animRig>> _rigs;
		private CArray<QsTransform> _bakedPose;
		private CArray<CName> _bakedBoneNames;

		[Ordinal(0)] 
		[RED("lod")] 
		public CUInt32 Lod
		{
			get => GetProperty(ref _lod);
			set => SetProperty(ref _lod, value);
		}

		[Ordinal(1)] 
		[RED("bones")] 
		public CArray<QsTransform> Bones
		{
			get => GetProperty(ref _bones);
			set => SetProperty(ref _bones, value);
		}

		[Ordinal(2)] 
		[RED("rigs")] 
		public CArray<raRef<animRig>> Rigs
		{
			get => GetProperty(ref _rigs);
			set => SetProperty(ref _rigs, value);
		}

		[Ordinal(3)] 
		[RED("bakedPose")] 
		public CArray<QsTransform> BakedPose
		{
			get => GetProperty(ref _bakedPose);
			set => SetProperty(ref _bakedPose, value);
		}

		[Ordinal(4)] 
		[RED("bakedBoneNames")] 
		public CArray<CName> BakedBoneNames
		{
			get => GetProperty(ref _bakedBoneNames);
			set => SetProperty(ref _bakedBoneNames, value);
		}

		public entCorpseParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
