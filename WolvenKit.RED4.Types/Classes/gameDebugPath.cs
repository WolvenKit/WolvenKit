using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDebugPath : RedBaseClass
	{
		private CString _str;

		[Ordinal(0)] 
		[RED("str")] 
		public CString Str
		{
			get => GetProperty(ref _str);
			set => SetProperty(ref _str, value);
		}
	}
}
