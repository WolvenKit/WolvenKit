using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PointData : IScriptable
	{
		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
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

		public PointData()
		{
			Position = new Vector4();
			Direction = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
