using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SNewsFeedElementData : CVariable
	{
		private CArray<SsimpleBanerData> _banners;
		private CInt32 _currentBanner;

		[Ordinal(0)] 
		[RED("banners")] 
		public CArray<SsimpleBanerData> Banners
		{
			get
			{
				if (_banners == null)
				{
					_banners = (CArray<SsimpleBanerData>) CR2WTypeManager.Create("array:SsimpleBanerData", "banners", cr2w, this);
				}
				return _banners;
			}
			set
			{
				if (_banners == value)
				{
					return;
				}
				_banners = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("currentBanner")] 
		public CInt32 CurrentBanner
		{
			get
			{
				if (_currentBanner == null)
				{
					_currentBanner = (CInt32) CR2WTypeManager.Create("Int32", "currentBanner", cr2w, this);
				}
				return _currentBanner;
			}
			set
			{
				if (_currentBanner == value)
				{
					return;
				}
				_currentBanner = value;
				PropertySet(this);
			}
		}

		public SNewsFeedElementData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
