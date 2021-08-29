using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WindAreaSettings : IAreaSettings
	{
		private CLegacySingleChannelCurve<CFloat> _strength;
		private CLegacySingleChannelCurve<Vector4> _direction;

		[Ordinal(2)] 
		[RED("strength")] 
		public CLegacySingleChannelCurve<CFloat> Strength
		{
			get => GetProperty(ref _strength);
			set => SetProperty(ref _strength, value);
		}

		[Ordinal(3)] 
		[RED("direction")] 
		public CLegacySingleChannelCurve<Vector4> Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}
	}
}
