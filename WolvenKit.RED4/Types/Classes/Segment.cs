using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class Segment : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("origin")] 
		public Vector4 Origin
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public Vector4 Direction
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public Segment()
		{
			Origin = new Vector4();
			Direction = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
