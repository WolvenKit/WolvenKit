using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questQuestPrefabsEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("nodeRef")] 
		public worldGlobalNodeRef NodeRef
		{
			get => GetPropertyValue<worldGlobalNodeRef>();
			set => SetPropertyValue<worldGlobalNodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("loadingMode")] 
		public CEnum<worldQuestPrefabLoadingMode> LoadingMode
		{
			get => GetPropertyValue<CEnum<worldQuestPrefabLoadingMode>>();
			set => SetPropertyValue<CEnum<worldQuestPrefabLoadingMode>>(value);
		}

		public questQuestPrefabsEntry()
		{
			NodeRef = new worldGlobalNodeRef();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
