
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleDetachablePart_Record
	{
		[RED("components")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> Components
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("gridCells")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> GridCells
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("spawnsExplosionEffect")]
		[REDProperty(IsIgnored = true)]
		public CBool SpawnsExplosionEffect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("threshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat Threshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
