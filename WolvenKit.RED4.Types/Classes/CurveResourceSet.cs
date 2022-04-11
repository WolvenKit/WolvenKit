using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		}
	}
}
