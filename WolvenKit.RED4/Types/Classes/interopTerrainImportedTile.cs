using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopTerrainImportedTile : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("heightMapAbsolutePath")] 
		public CString HeightMapAbsolutePath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("controlMapAbsolutePath")] 
		public CString ControlMapAbsolutePath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("colorMapAbsolutePath")] 
		public CString ColorMapAbsolutePath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("position")] 
		public Point Position
		{
			get => GetPropertyValue<Point>();
			set => SetPropertyValue<Point>(value);
		}

		public interopTerrainImportedTile()
		{
			Position = new Point();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
