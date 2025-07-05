using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CurveResourceSet : CResource
	{
		[Ordinal(1)] 
		[RED("curveResources")] 
		public CArray<CurveResourceSetEntry> CurveResources
		{
			get => GetPropertyValue<CArray<CurveResourceSetEntry>>();
			set => SetPropertyValue<CArray<CurveResourceSetEntry>>(value);
		}

		public CurveResourceSet()
		{
			CurveResources = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
