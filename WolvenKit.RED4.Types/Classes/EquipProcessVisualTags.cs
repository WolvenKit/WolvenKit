using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EquipProcessVisualTags : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("item")] 
		public gameItemID Item
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public EquipProcessVisualTags()
		{
			Item = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
