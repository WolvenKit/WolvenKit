using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAchievementManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIAchievementManagerNodeType> Type
		{
			get => GetPropertyValue<CHandle<questIAchievementManagerNodeType>>();
			set => SetPropertyValue<CHandle<questIAchievementManagerNodeType>>(value);
		}

		public questAchievementManagerNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
