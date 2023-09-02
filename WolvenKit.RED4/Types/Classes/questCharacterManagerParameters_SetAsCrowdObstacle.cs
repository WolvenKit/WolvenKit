using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerParameters_SetAsCrowdObstacle : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questSetAsCrowdObstacle_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questSetAsCrowdObstacle_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questSetAsCrowdObstacle_NodeTypeParams>>(value);
		}

		public questCharacterManagerParameters_SetAsCrowdObstacle()
		{
			Params = new() { new questSetAsCrowdObstacle_NodeTypeParams() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
