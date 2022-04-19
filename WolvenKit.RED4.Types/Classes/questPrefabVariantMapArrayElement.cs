using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPrefabVariantMapArrayElement : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("globalNodeRef")] 
		public worldGlobalNodeRef GlobalNodeRef
		{
			get => GetPropertyValue<worldGlobalNodeRef>();
			set => SetPropertyValue<worldGlobalNodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("PrefabVariantsReplicatedInfos")] 
		public CArray<questPrefabVariantReplicatedInfo> PrefabVariantsReplicatedInfos
		{
			get => GetPropertyValue<CArray<questPrefabVariantReplicatedInfo>>();
			set => SetPropertyValue<CArray<questPrefabVariantReplicatedInfo>>(value);
		}

		public questPrefabVariantMapArrayElement()
		{
			GlobalNodeRef = new();
			PrefabVariantsReplicatedInfos = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
