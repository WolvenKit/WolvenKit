using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questGlobalTvScheduler_NodeType : questIUIManagerNodeType
	{
		private TweakDBID _channelId;
		private raRef<inkWidgetLibraryResource> _overlayResource;
		private raRef<Bink> _videoResource;
		private raRef<scnSceneResource> _vOScene;
		private CName _audioEvent;
		private TweakDBID _newsTitleTweak;
		private TweakDBID _randomNewsFeedPack;

		[Ordinal(0)] 
		[RED("channelId")] 
		public TweakDBID ChannelId
		{
			get
			{
				if (_channelId == null)
				{
					_channelId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "channelId", cr2w, this);
				}
				return _channelId;
			}
			set
			{
				if (_channelId == value)
				{
					return;
				}
				_channelId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("overlayResource")] 
		public raRef<inkWidgetLibraryResource> OverlayResource
		{
			get
			{
				if (_overlayResource == null)
				{
					_overlayResource = (raRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("raRef:inkWidgetLibraryResource", "overlayResource", cr2w, this);
				}
				return _overlayResource;
			}
			set
			{
				if (_overlayResource == value)
				{
					return;
				}
				_overlayResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("videoResource")] 
		public raRef<Bink> VideoResource
		{
			get
			{
				if (_videoResource == null)
				{
					_videoResource = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "videoResource", cr2w, this);
				}
				return _videoResource;
			}
			set
			{
				if (_videoResource == value)
				{
					return;
				}
				_videoResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("VOScene")] 
		public raRef<scnSceneResource> VOScene
		{
			get
			{
				if (_vOScene == null)
				{
					_vOScene = (raRef<scnSceneResource>) CR2WTypeManager.Create("raRef:scnSceneResource", "VOScene", cr2w, this);
				}
				return _vOScene;
			}
			set
			{
				if (_vOScene == value)
				{
					return;
				}
				_vOScene = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get
			{
				if (_audioEvent == null)
				{
					_audioEvent = (CName) CR2WTypeManager.Create("CName", "audioEvent", cr2w, this);
				}
				return _audioEvent;
			}
			set
			{
				if (_audioEvent == value)
				{
					return;
				}
				_audioEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		public questGlobalTvScheduler_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
