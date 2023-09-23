using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DismembermentExplosionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("epicentrum")] 
		public Vector4 Epicentrum
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public DismembermentExplosionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
