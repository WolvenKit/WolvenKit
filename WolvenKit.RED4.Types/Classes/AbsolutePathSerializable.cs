using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AbsolutePathSerializable : RedBaseClass
	{
		private CString _path;

		[Ordinal(0)] 
		[RED("Path")] 
		public CString Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}
	}
}
