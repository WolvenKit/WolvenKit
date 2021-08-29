using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameItemDropObject : gameLootObject
	{
		private CBool _wasItemInitialized;

		[Ordinal(43)] 
		[RED("wasItemInitialized")] 
		public CBool WasItemInitialized
		{
			get => GetProperty(ref _wasItemInitialized);
			set => SetProperty(ref _wasItemInitialized, value);
		}
	}
}
