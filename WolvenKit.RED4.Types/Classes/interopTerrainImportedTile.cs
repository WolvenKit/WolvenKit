using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class interopTerrainImportedTile : RedBaseClass
	{
		private CString _heightMapAbsolutePath;
		private CString _controlMapAbsolutePath;
		private CString _colorMapAbsolutePath;
		private Point _position;

		[Ordinal(0)] 
		[RED("heightMapAbsolutePath")] 
		public CString HeightMapAbsolutePath
		{
			get => GetProperty(ref _heightMapAbsolutePath);
			set => SetProperty(ref _heightMapAbsolutePath, value);
		}

		[Ordinal(1)] 
		[RED("controlMapAbsolutePath")] 
		public CString ControlMapAbsolutePath
		{
			get => GetProperty(ref _controlMapAbsolutePath);
			set => SetProperty(ref _controlMapAbsolutePath, value);
		}

		[Ordinal(2)] 
		[RED("colorMapAbsolutePath")] 
		public CString ColorMapAbsolutePath
		{
			get => GetProperty(ref _colorMapAbsolutePath);
			set => SetProperty(ref _colorMapAbsolutePath, value);
		}

		[Ordinal(3)] 
		[RED("position")] 
		public Point Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}
	}
}
