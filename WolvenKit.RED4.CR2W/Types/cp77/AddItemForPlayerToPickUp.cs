using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddItemForPlayerToPickUp : ScriptableDeviceAction
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

		public AddItemForPlayerToPickUp(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
