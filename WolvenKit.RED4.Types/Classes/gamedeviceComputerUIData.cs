using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedeviceComputerUIData : RedBaseClass
	{
		private CArray<gamedeviceGenericDataContent> _mails;
		private CArray<gamedeviceGenericDataContent> _files;

		[Ordinal(0)] 
		[RED("mails")] 
		public CArray<gamedeviceGenericDataContent> Mails
		{
			get => GetProperty(ref _mails);
			set => SetProperty(ref _mails, value);
		}

		[Ordinal(1)] 
		[RED("files")] 
		public CArray<gamedeviceGenericDataContent> Files
		{
			get => GetProperty(ref _files);
			set => SetProperty(ref _files, value);
		}
	}
}
