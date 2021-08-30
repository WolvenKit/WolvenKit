using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalPath : IScriptable
	{
		private CString _realPath;
		private CInt32 _fileEntryIndex;
		private CName _className;

		[Ordinal(0)] 
		[RED("realPath")] 
		public CString RealPath
		{
			get => GetProperty(ref _realPath);
			set => SetProperty(ref _realPath, value);
		}

		[Ordinal(1)] 
		[RED("fileEntryIndex")] 
		public CInt32 FileEntryIndex
		{
			get => GetProperty(ref _fileEntryIndex);
			set => SetProperty(ref _fileEntryIndex, value);
		}

		[Ordinal(2)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetProperty(ref _className);
			set => SetProperty(ref _className, value);
		}

		public gameJournalPath()
		{
			_fileEntryIndex = -1;
		}
	}
}
