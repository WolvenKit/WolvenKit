
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleDestructibleGlass_Record
	{
		[RED("broken")]
		[REDProperty(IsIgnored = true)]
		public CName Broken
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("component")]
		[REDProperty(IsIgnored = true)]
		public CName Component
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("effect")]
		[REDProperty(IsIgnored = true)]
		public CName Effect
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("gridCells")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> GridCells
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("isWindshield")]
		[REDProperty(IsIgnored = true)]
		public CBool IsWindshield
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
