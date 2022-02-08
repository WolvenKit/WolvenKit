using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		}
	}
}
