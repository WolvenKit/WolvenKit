using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRainEvent : redEvent
	{
		private CEnum<worldRainIntensity> _rainIntensity;

		[Ordinal(0)] 
		[RED("rainIntensity")] 
		public CEnum<worldRainIntensity> RainIntensity
		{
			get => GetProperty(ref _rainIntensity);
			set => SetProperty(ref _rainIntensity, value);
		}
	}
}
