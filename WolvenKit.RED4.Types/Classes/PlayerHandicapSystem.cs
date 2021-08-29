using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerHandicapSystem : gameScriptableSystem
	{
		private CBool _canDropHealingConsumable;
		private CBool _canDropAmmo;

		[Ordinal(0)] 
		[RED("canDropHealingConsumable")] 
		public CBool CanDropHealingConsumable
		{
			get => GetProperty(ref _canDropHealingConsumable);
			set => SetProperty(ref _canDropHealingConsumable, value);
		}

		[Ordinal(1)] 
		[RED("canDropAmmo")] 
		public CBool CanDropAmmo
		{
			get => GetProperty(ref _canDropAmmo);
			set => SetProperty(ref _canDropAmmo, value);
		}
	}
}
