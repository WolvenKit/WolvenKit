using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorAlphaByDistance : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("nearBlendDistance")] 
		public Vector2 NearBlendDistance
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(5)] 
		[RED("farBlendDistance")] 
		public Vector2 FarBlendDistance
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public CParticleModificatorAlphaByDistance()
		{
			EditorName = "Alpha by distance";
			EditorGroup = "Material";
			IsEnabled = true;
			NearBlendDistance = new() { X = 7.000000F, Y = 5.000000F };
			FarBlendDistance = new() { X = 27.000000F, Y = 20.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
