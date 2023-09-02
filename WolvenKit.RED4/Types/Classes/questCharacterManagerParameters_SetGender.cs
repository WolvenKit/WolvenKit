using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerParameters_SetGender : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questSetGender_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questSetGender_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questSetGender_NodeTypeParams>>(value);
		}

		public questCharacterManagerParameters_SetGender()
		{
			Params = new() { new questSetGender_NodeTypeParams() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
