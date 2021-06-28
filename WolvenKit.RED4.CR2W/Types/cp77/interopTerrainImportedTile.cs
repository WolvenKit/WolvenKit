using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopTerrainImportedTile : CVariable
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

		public interopTerrainImportedTile(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
