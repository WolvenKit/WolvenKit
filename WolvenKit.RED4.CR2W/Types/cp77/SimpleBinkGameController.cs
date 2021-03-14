using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SimpleBinkGameController : DeviceInkGameControllerBase
	{
		private CBool _playCommonAd;
		private CName _video1Path;
		private CName _video2Path;
		private inkVideoWidgetReference _video1;
		private inkVideoWidgetReference _video2;

		[Ordinal(16)] 
		[RED("playCommonAd")] 
		public CBool PlayCommonAd
		{
			get
			{
				if (_playCommonAd == null)
				{
					_playCommonAd = (CBool) CR2WTypeManager.Create("Bool", "playCommonAd", cr2w, this);
				}
				return _playCommonAd;
			}
			set
			{
				if (_playCommonAd == value)
				{
					return;
				}
				_playCommonAd = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("Video1Path")] 
		public CName Video1Path
		{
			get
			{
				if (_video1Path == null)
				{
					_video1Path = (CName) CR2WTypeManager.Create("CName", "Video1Path", cr2w, this);
				}
				return _video1Path;
			}
			set
			{
				if (_video1Path == value)
				{
					return;
				}
				_video1Path = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("Video2Path")] 
		public CName Video2Path
		{
			get
			{
				if (_video2Path == null)
				{
					_video2Path = (CName) CR2WTypeManager.Create("CName", "Video2Path", cr2w, this);
				}
				return _video2Path;
			}
			set
			{
				if (_video2Path == value)
				{
					return;
				}
				_video2Path = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("Video1")] 
		public inkVideoWidgetReference Video1
		{
			get
			{
				if (_video1 == null)
				{
					_video1 = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "Video1", cr2w, this);
				}
				return _video1;
			}
			set
			{
				if (_video1 == value)
				{
					return;
				}
				_video1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("Video2")] 
		public inkVideoWidgetReference Video2
		{
			get
			{
				if (_video2 == null)
				{
					_video2 = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "Video2", cr2w, this);
				}
				return _video2;
			}
			set
			{
				if (_video2 == value)
				{
					return;
				}
				_video2 = value;
				PropertySet(this);
			}
		}

		public SimpleBinkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
