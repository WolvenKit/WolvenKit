using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AITeleportCommand : AICommand
	{
		[Ordinal(4)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(5)] 
		[RED("rotation")] 
		public CFloat Rotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("doNavTest")] 
		public CBool DoNavTest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AITeleportCommand()
		{
			Position = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
