using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetFOV_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("FOV")] 
		public CFloat FOV
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public questSetFOV_NodeType()
		{
			FOV = 60.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
