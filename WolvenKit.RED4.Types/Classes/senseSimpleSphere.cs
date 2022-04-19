using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseSimpleSphere : senseIShape
	{
		[Ordinal(1)] 
		[RED("sphere")] 
		public Sphere Sphere
		{
			get => GetPropertyValue<Sphere>();
			set => SetPropertyValue<Sphere>(value);
		}

		public senseSimpleSphere()
		{
			Sphere = new() { CenterRadius2 = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
