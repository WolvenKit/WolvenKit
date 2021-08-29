using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OdaCementBag : InteractiveDevice
	{
		private CBool _onCooldown;

		[Ordinal(97)] 
		[RED("onCooldown")] 
		public CBool OnCooldown
		{
			get => GetProperty(ref _onCooldown);
			set => SetProperty(ref _onCooldown, value);
		}
	}
}
