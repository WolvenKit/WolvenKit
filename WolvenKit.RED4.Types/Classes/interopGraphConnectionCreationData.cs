using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class interopGraphConnectionCreationData : RedBaseClass
	{
		private CString _data;
		private CArray<CString> _extraData;

		[Ordinal(0)] 
		[RED("data")] 
		public CString Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(1)] 
		[RED("extraData")] 
		public CArray<CString> ExtraData
		{
			get => GetProperty(ref _extraData);
			set => SetProperty(ref _extraData, value);
		}
	}
}
