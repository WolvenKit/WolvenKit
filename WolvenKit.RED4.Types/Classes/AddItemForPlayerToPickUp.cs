using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddItemForPlayerToPickUp : ScriptableDeviceAction
	{
		private TweakDBID _lootTable;
		private CBool _shouldAdd;

		[Ordinal(25)] 
		[RED("lootTable")] 
		public TweakDBID LootTable
		{
			get => GetProperty(ref _lootTable);
			set => SetProperty(ref _lootTable, value);
		}

		[Ordinal(26)] 
		[RED("shouldAdd")] 
		public CBool ShouldAdd
		{
			get => GetProperty(ref _shouldAdd);
			set => SetProperty(ref _shouldAdd, value);
		}

		public AddItemForPlayerToPickUp()
		{
			_shouldAdd = true;
		}
	}
}
