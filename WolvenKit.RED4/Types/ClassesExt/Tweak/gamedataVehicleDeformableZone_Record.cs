
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleDeformableZone_Record
	{
		[RED("gridCells")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> GridCells
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("shapes")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> Shapes
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
	}
}
