using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedeviceGenericDataContent : RedBaseClass
	{
		private CString _name;
		private CArray<gamedeviceDataElement> _content;

		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("content")] 
		public CArray<gamedeviceDataElement> Content
		{
			get => GetProperty(ref _content);
			set => SetProperty(ref _content, value);
		}
	}
}
