using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questQuickItemsManager_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("set")] 
		public CEnum<questQuickItemsSet> Set
		{
			get => GetPropertyValue<CEnum<questQuickItemsSet>>();
			set => SetPropertyValue<CEnum<questQuickItemsSet>>(value);
		}

		public questQuickItemsManager_NodeType()
		{
			Set = Enums.questQuickItemsSet.Q003_All;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
