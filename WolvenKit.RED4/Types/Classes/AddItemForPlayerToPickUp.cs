using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AddItemForPlayerToPickUp : ScriptableDeviceAction
	{
		[Ordinal(38)] 
		[RED("lootTable")] 
		public TweakDBID LootTable
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(39)] 
		[RED("shouldAdd")] 
		public CBool ShouldAdd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AddItemForPlayerToPickUp()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
