using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerPersistentData : CVariable
	{
		private CArray<gamedeviceGenericDataContent> _mails;
		private CArray<gamedeviceGenericDataContent> _files;
		private CArray<SNewsFeedElementData> _newsFeedElements;
		private SInternetData _internetData;
		private CString _initialUIPosition;
		private CInt32 _openedFileIDX;
		private CInt32 _openedFolderIDX;

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

		[Ordinal(2)] 
		[RED("newsFeedElements")] 
		public CArray<SNewsFeedElementData> NewsFeedElements
		{
			get => GetProperty(ref _newsFeedElements);
			set => SetProperty(ref _newsFeedElements, value);
		}

		[Ordinal(3)] 
		[RED("internetData")] 
		public SInternetData InternetData
		{
			get => GetProperty(ref _internetData);
			set => SetProperty(ref _internetData, value);
		}

		[Ordinal(4)] 
		[RED("initialUIPosition")] 
		public CString InitialUIPosition
		{
			get => GetProperty(ref _initialUIPosition);
			set => SetProperty(ref _initialUIPosition, value);
		}

		[Ordinal(5)] 
		[RED("openedFileIDX")] 
		public CInt32 OpenedFileIDX
		{
			get => GetProperty(ref _openedFileIDX);
			set => SetProperty(ref _openedFileIDX, value);
		}

		[Ordinal(6)] 
		[RED("openedFolderIDX")] 
		public CInt32 OpenedFolderIDX
		{
			get => GetProperty(ref _openedFolderIDX);
			set => SetProperty(ref _openedFolderIDX, value);
		}

		public ComputerPersistentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
