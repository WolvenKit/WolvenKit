using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPrefabVariantMapArrayElement : RedBaseClass
	{
		private worldGlobalNodeRef _globalNodeRef;
		private CArray<questPrefabVariantReplicatedInfo> _prefabVariantsReplicatedInfos;

		[Ordinal(0)] 
		[RED("globalNodeRef")] 
		public worldGlobalNodeRef GlobalNodeRef
		{
			get => GetProperty(ref _globalNodeRef);
			set => SetProperty(ref _globalNodeRef, value);
		}

		[Ordinal(1)] 
		[RED("PrefabVariantsReplicatedInfos")] 
		public CArray<questPrefabVariantReplicatedInfo> PrefabVariantsReplicatedInfos
		{
			get => GetProperty(ref _prefabVariantsReplicatedInfos);
			set => SetProperty(ref _prefabVariantsReplicatedInfos, value);
		}
	}
}
