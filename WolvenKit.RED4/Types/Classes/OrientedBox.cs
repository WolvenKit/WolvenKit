using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class OrientedBox : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("edge 1")] 
		public Vector4 Edge_1
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("edge 2")] 
		public Vector4 Edge_2
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public OrientedBox()
		{
			Position = new Vector4();
			Edge_1 = new Vector4();
			Edge_2 = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
