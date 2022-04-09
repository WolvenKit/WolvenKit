using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlaceMineEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("normal")] 
		public Vector4 Normal
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public PlaceMineEvent()
		{
			Position = new();
			Normal = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
