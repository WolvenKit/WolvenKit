using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIPosition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public AIPosition()
		{
			Position = new Vector3 { X = float.MinValue, Y = float.MinValue, Z = float.MinValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
