using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataComplexValueNode : gamedataValueDataNode
	{
		private CArray<CString> _data;

		[Ordinal(3)] 
		[RED("data")] 
		public CArray<CString> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
