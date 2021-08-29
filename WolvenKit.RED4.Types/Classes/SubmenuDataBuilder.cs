using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SubmenuDataBuilder : IScriptable
	{
		private CHandle<MenuDataBuilder> _menuBuilder;
		private CInt32 _menuDataIndex;

		[Ordinal(0)] 
		[RED("menuBuilder")] 
		public CHandle<MenuDataBuilder> MenuBuilder
		{
			get => GetProperty(ref _menuBuilder);
			set => SetProperty(ref _menuBuilder, value);
		}

		[Ordinal(1)] 
		[RED("menuDataIndex")] 
		public CInt32 MenuDataIndex
		{
			get => GetProperty(ref _menuDataIndex);
			set => SetProperty(ref _menuDataIndex, value);
		}
	}
}
