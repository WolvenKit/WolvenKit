using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DismembermentExplosionEvent : redEvent
	{
		private Vector4 _epicentrum;
		private CFloat _strength;

		[Ordinal(0)] 
		[RED("epicentrum")] 
		public Vector4 Epicentrum
		{
			get => GetProperty(ref _epicentrum);
			set => SetProperty(ref _epicentrum, value);
		}

		[Ordinal(1)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get => GetProperty(ref _strength);
			set => SetProperty(ref _strength, value);
		}
	}
}
