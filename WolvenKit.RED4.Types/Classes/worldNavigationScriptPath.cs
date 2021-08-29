using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldNavigationScriptPath : IScriptable
	{
		private CArray<Vector4> _path;

		[Ordinal(0)] 
		[RED("path")] 
		public CArray<Vector4> Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}
	}
}
