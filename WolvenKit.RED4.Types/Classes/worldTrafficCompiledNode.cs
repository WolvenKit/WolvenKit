using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficCompiledNode : worldNode
	{
		[Ordinal(4)] 
		[RED("aabb")] 
		public Box Aabb
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		public worldTrafficCompiledNode()
		{
			Aabb = new() { Min = new() { X = 340282346638528859811704183484516925440.000000F, Y = 340282346638528859811704183484516925440.000000F, Z = 340282346638528859811704183484516925440.000000F, W = 340282346638528859811704183484516925440.000000F }, Max = new() { X = -340282346638528859811704183484516925440.000000F, Y = -340282346638528859811704183484516925440.000000F, Z = -340282346638528859811704183484516925440.000000F, W = -340282346638528859811704183484516925440.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
