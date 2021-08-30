using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBraindanceDissolveComponent : entIComponent
	{
		private CFloat _dissolveRadius;

		[Ordinal(3)] 
		[RED("dissolveRadius")] 
		public CFloat DissolveRadius
		{
			get => GetProperty(ref _dissolveRadius);
			set => SetProperty(ref _dissolveRadius, value);
		}

		public gameBraindanceDissolveComponent()
		{
			_dissolveRadius = 0.600000F;
		}
	}
}
