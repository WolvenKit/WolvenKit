using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorGameItemData : IScriptable
	{
		private CHandle<gameItemData> _gameItemData;
		private gameSItemStack _itemStack;

		[Ordinal(0)] 
		[RED("gameItemData")] 
		public CHandle<gameItemData> GameItemData
		{
			get => GetProperty(ref _gameItemData);
			set => SetProperty(ref _gameItemData, value);
		}

		[Ordinal(1)] 
		[RED("itemStack")] 
		public gameSItemStack ItemStack
		{
			get => GetProperty(ref _itemStack);
			set => SetProperty(ref _itemStack, value);
		}

		public VendorGameItemData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
