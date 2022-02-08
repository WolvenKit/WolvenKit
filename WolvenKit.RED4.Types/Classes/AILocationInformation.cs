using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AILocationInformation : RedBaseClass
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

		public AILocationInformation()
		{
			Position = new() { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity, W = float.PositiveInfinity };
			Direction = new() { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity, W = float.PositiveInfinity };
		}
	}
}
