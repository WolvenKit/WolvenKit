using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerMenuWidgetController : inkWidgetLogicController
	{
		private inkWidgetReference _thumbnailsListWidget;
		private inkWidgetReference _contentWidget;
		private CBool _isInitialized;
		private CArray<SDocumentWidgetPackage> _fileWidgetsData;
		private CArray<SDocumentThumbnailWidgetPackage> _fileThumbnailWidgetsData;

		[Ordinal(1)] 
		[RED("thumbnailsListWidget")] 
		public inkWidgetReference ThumbnailsListWidget
		{
			get
			{
				if (_thumbnailsListWidget == null)
				{
					_thumbnailsListWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "thumbnailsListWidget", cr2w, this);
				}
				return _thumbnailsListWidget;
			}
			set
			{
				if (_thumbnailsListWidget == value)
				{
					return;
				}
				_thumbnailsListWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("contentWidget")] 
		public inkWidgetReference ContentWidget
		{
			get
			{
				if (_contentWidget == null)
				{
					_contentWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "contentWidget", cr2w, this);
				}
				return _contentWidget;
			}
			set
			{
				if (_contentWidget == value)
				{
					return;
				}
				_contentWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get
			{
				if (_isInitialized == null)
				{
					_isInitialized = (CBool) CR2WTypeManager.Create("Bool", "isInitialized", cr2w, this);
				}
				return _isInitialized;
			}
			set
			{
				if (_isInitialized == value)
				{
					return;
				}
				_isInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("fileWidgetsData")] 
		public CArray<SDocumentWidgetPackage> FileWidgetsData
		{
			get
			{
				if (_fileWidgetsData == null)
				{
					_fileWidgetsData = (CArray<SDocumentWidgetPackage>) CR2WTypeManager.Create("array:SDocumentWidgetPackage", "fileWidgetsData", cr2w, this);
				}
				return _fileWidgetsData;
			}
			set
			{
				if (_fileWidgetsData == value)
				{
					return;
				}
				_fileWidgetsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("fileThumbnailWidgetsData")] 
		public CArray<SDocumentThumbnailWidgetPackage> FileThumbnailWidgetsData
		{
			get
			{
				if (_fileThumbnailWidgetsData == null)
				{
					_fileThumbnailWidgetsData = (CArray<SDocumentThumbnailWidgetPackage>) CR2WTypeManager.Create("array:SDocumentThumbnailWidgetPackage", "fileThumbnailWidgetsData", cr2w, this);
				}
				return _fileThumbnailWidgetsData;
			}
			set
			{
				if (_fileThumbnailWidgetsData == value)
				{
					return;
				}
				_fileThumbnailWidgetsData = value;
				PropertySet(this);
			}
		}

		public ComputerMenuWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
