using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EMPHitEvent : redEvent
	{
		private CFloat _lifetime;

		[Ordinal(0)] 
		[RED("lifetime")] 
		public CFloat Lifetime
		{
			get => GetProperty(ref _lifetime);
			set => SetProperty(ref _lifetime, value);
		}

		public EMPHitEvent()
		{
			_lifetime = 15.000000F;
		}
	}
}
