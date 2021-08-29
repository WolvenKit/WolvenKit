using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CraftingUserData : IScriptable
	{
		private CEnum<CraftingMode> _mode;

		[Ordinal(0)] 
		[RED("Mode")] 
		public CEnum<CraftingMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}
	}
}
