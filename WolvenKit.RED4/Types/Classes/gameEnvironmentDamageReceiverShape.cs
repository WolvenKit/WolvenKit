using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gameEnvironmentDamageReceiverShape : ISerializable
	{
		[Ordinal(0)] 
		[RED("transform")] 
		public Transform Transform
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		public gameEnvironmentDamageReceiverShape()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
