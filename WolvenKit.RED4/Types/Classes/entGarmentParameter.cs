using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entGarmentParameter : entEntityParameter
	{
		[Ordinal(0)] 
		[RED("componentsData")] 
		public CArray<entGarmentParameterComponentData> ComponentsData
		{
			get => GetPropertyValue<CArray<entGarmentParameterComponentData>>();
			set => SetPropertyValue<CArray<entGarmentParameterComponentData>>(value);
		}

		[Ordinal(1)] 
		[RED("collarArea")] 
		public garmentCollarAreaParams CollarArea
		{
			get => GetPropertyValue<garmentCollarAreaParams>();
			set => SetPropertyValue<garmentCollarAreaParams>(value);
		}

		[Ordinal(2)] 
		[RED("lastUpdateDateTime")] 
		public CDateTime LastUpdateDateTime
		{
			get => GetPropertyValue<CDateTime>();
			set => SetPropertyValue<CDateTime>(value);
		}

		public entGarmentParameter()
		{
			ComponentsData = new();
			CollarArea = new garmentCollarAreaParams { RadiusInCM = 32.000000F, RadiusForTriangleRemovalInCM = 16.000000F, Offset = new Vector3() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
