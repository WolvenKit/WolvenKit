using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiNewsFeedDataProvider : IScriptable
	{
		private TweakDBID _newsTitleTweak;
		private TweakDBID _randomNewsFeedPack;

		[Ordinal(0)] 
		[RED("newsTitleTweak")] 
		public TweakDBID NewsTitleTweak
		{
			get
			{
				if (_newsTitleTweak == null)
				{
					_newsTitleTweak = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "newsTitleTweak", cr2w, this);
				}
				return _newsTitleTweak;
			}
			set
			{
				if (_newsTitleTweak == value)
				{
					return;
				}
				_newsTitleTweak = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("randomNewsFeedPack")] 
		public TweakDBID RandomNewsFeedPack
		{
			get
			{
				if (_randomNewsFeedPack == null)
				{
					_randomNewsFeedPack = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "randomNewsFeedPack", cr2w, this);
				}
				return _randomNewsFeedPack;
			}
			set
			{
				if (_randomNewsFeedPack == value)
				{
					return;
				}
				_randomNewsFeedPack = value;
				PropertySet(this);
			}
		}

		public gameuiNewsFeedDataProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
