using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioGrenadeEntitySettings : audioEntitySettings
	{
		private CName _explosionSound;

		[Ordinal(6)] 
		[RED("explosionSound")] 
		public CName ExplosionSound
		{
			get => GetProperty(ref _explosionSound);
			set => SetProperty(ref _explosionSound, value);
		}
	}
}
