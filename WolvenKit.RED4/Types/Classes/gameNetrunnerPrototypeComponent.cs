using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameNetrunnerPrototypeComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("structs")] 
		public CArray<gameNetrunnerPrototypeStruct> Structs
		{
			get => GetPropertyValue<CArray<gameNetrunnerPrototypeStruct>>();
			set => SetPropertyValue<CArray<gameNetrunnerPrototypeStruct>>(value);
		}

		public gameNetrunnerPrototypeComponent()
		{
			Name = "Component";
			Structs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
