using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entCorpseParameter : entEntityParameter
	{
		[Ordinal(0)] 
		[RED("lod")] 
		public CUInt32 Lod
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("bakedPose")] 
		public CArray<QsTransform> BakedPose
		{
			get => GetPropertyValue<CArray<QsTransform>>();
			set => SetPropertyValue<CArray<QsTransform>>(value);
		}

		[Ordinal(2)] 
		[RED("bakedBoneNames")] 
		public CArray<CName> BakedBoneNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("forceLOD0Components")] 
		public CArray<CRUID> ForceLOD0Components
		{
			get => GetPropertyValue<CArray<CRUID>>();
			set => SetPropertyValue<CArray<CRUID>>(value);
		}

		[Ordinal(4)] 
		[RED("baseRig")] 
		public CResourceAsyncReference<animRig> BaseRig
		{
			get => GetPropertyValue<CResourceAsyncReference<animRig>>();
			set => SetPropertyValue<CResourceAsyncReference<animRig>>(value);
		}

		public entCorpseParameter()
		{
			BakedPose = new();
			BakedBoneNames = new();
			ForceLOD0Components = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
