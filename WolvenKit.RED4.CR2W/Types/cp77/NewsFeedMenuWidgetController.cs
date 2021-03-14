using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewsFeedMenuWidgetController : inkWidgetLogicController
	{
		private CName _bannersListWidgetPath;
		private inkWidgetReference _bannersListWidget;
		private CBool _isInitialized;
		private CArray<SBannerWidgetPackage> _bannerWidgetsData;
		private SBannerWidgetPackage _fullBannerWidgetData;

		[Ordinal(1)] 
		[RED("bannersListWidgetPath")] 
		public CName BannersListWidgetPath
		{
			get
			{
				if (_bannersListWidgetPath == null)
				{
					_bannersListWidgetPath = (CName) CR2WTypeManager.Create("CName", "bannersListWidgetPath", cr2w, this);
				}
				return _bannersListWidgetPath;
			}
			set
			{
				if (_bannersListWidgetPath == value)
				{
					return;
				}
				_bannersListWidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("bannersListWidget")] 
		public inkWidgetReference BannersListWidget
		{
			get
			{
				if (_bannersListWidget == null)
				{
					_bannersListWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bannersListWidget", cr2w, this);
				}
				return _bannersListWidget;
			}
			set
			{
				if (_bannersListWidget == value)
				{
					return;
				}
				_bannersListWidget = value;
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
		[RED("bannerWidgetsData")] 
		public CArray<SBannerWidgetPackage> BannerWidgetsData
		{
			get
			{
				if (_bannerWidgetsData == null)
				{
					_bannerWidgetsData = (CArray<SBannerWidgetPackage>) CR2WTypeManager.Create("array:SBannerWidgetPackage", "bannerWidgetsData", cr2w, this);
				}
				return _bannerWidgetsData;
			}
			set
			{
				if (_bannerWidgetsData == value)
				{
					return;
				}
				_bannerWidgetsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("fullBannerWidgetData")] 
		public SBannerWidgetPackage FullBannerWidgetData
		{
			get
			{
				if (_fullBannerWidgetData == null)
				{
					_fullBannerWidgetData = (SBannerWidgetPackage) CR2WTypeManager.Create("SBannerWidgetPackage", "fullBannerWidgetData", cr2w, this);
				}
				return _fullBannerWidgetData;
			}
			set
			{
				if (_fullBannerWidgetData == value)
				{
					return;
				}
				_fullBannerWidgetData = value;
				PropertySet(this);
			}
		}

		public NewsFeedMenuWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
