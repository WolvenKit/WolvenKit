using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameNetrunnerPrototypeNodeSetupEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("scale")] 
		public Vector3 Scale
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public gameNetrunnerPrototypeNodeSetupEvent()
		{
			Scale = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
