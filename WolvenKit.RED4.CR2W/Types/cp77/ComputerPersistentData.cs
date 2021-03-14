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
			get
			{
				if (_mails == null)
				{
					_mails = (CArray<gamedeviceGenericDataContent>) CR2WTypeManager.Create("array:gamedeviceGenericDataContent", "mails", cr2w, this);
				}
				return _mails;
			}
			set
			{
				if (_mails == value)
				{
					return;
				}
				_mails = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("files")] 
		public CArray<gamedeviceGenericDataContent> Files
		{
			get
			{
				if (_files == null)
				{
					_files = (CArray<gamedeviceGenericDataContent>) CR2WTypeManager.Create("array:gamedeviceGenericDataContent", "files", cr2w, this);
				}
				return _files;
			}
			set
			{
				if (_files == value)
				{
					return;
				}
				_files = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("newsFeedElements")] 
		public CArray<SNewsFeedElementData> NewsFeedElements
		{
			get
			{
				if (_newsFeedElements == null)
				{
					_newsFeedElements = (CArray<SNewsFeedElementData>) CR2WTypeManager.Create("array:SNewsFeedElementData", "newsFeedElements", cr2w, this);
				}
				return _newsFeedElements;
			}
			set
			{
				if (_newsFeedElements == value)
				{
					return;
				}
				_newsFeedElements = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("internetData")] 
		public SInternetData InternetData
		{
			get
			{
				if (_internetData == null)
				{
					_internetData = (SInternetData) CR2WTypeManager.Create("SInternetData", "internetData", cr2w, this);
				}
				return _internetData;
			}
			set
			{
				if (_internetData == value)
				{
					return;
				}
				_internetData = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("initialUIPosition")] 
		public CString InitialUIPosition
		{
			get
			{
				if (_initialUIPosition == null)
				{
					_initialUIPosition = (CString) CR2WTypeManager.Create("String", "initialUIPosition", cr2w, this);
				}
				return _initialUIPosition;
			}
			set
			{
				if (_initialUIPosition == value)
				{
					return;
				}
				_initialUIPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("openedFileIDX")] 
		public CInt32 OpenedFileIDX
		{
			get
			{
				if (_openedFileIDX == null)
				{
					_openedFileIDX = (CInt32) CR2WTypeManager.Create("Int32", "openedFileIDX", cr2w, this);
				}
				return _openedFileIDX;
			}
			set
			{
				if (_openedFileIDX == value)
				{
					return;
				}
				_openedFileIDX = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("openedFolderIDX")] 
		public CInt32 OpenedFolderIDX
		{
			get
			{
				if (_openedFolderIDX == null)
				{
					_openedFolderIDX = (CInt32) CR2WTypeManager.Create("Int32", "openedFolderIDX", cr2w, this);
				}
				return _openedFolderIDX;
			}
			set
			{
				if (_openedFolderIDX == value)
				{
					return;
				}
				_openedFolderIDX = value;
				PropertySet(this);
			}
		}

		public ComputerPersistentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
