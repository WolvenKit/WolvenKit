using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		}
	}
}
