using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVideoWidget : inkLeafWidget
	{
		private raRef<Bink> _videoResource;
		private CBool _loop;
		private CName _overriddenPlayerName;
		private CBool _isParallaxEnabled;
		private CBool _prefetchVideo;

		[Ordinal(20)] 
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

		[Ordinal(21)] 
		[RED("loop")] 
		public CBool Loop
		{
			get
			{
				if (_loop == null)
				{
					_loop = (CBool) CR2WTypeManager.Create("Bool", "loop", cr2w, this);
				}
				return _loop;
			}
			set
			{
				if (_loop == value)
				{
					return;
				}
				_loop = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("overriddenPlayerName")] 
		public CName OverriddenPlayerName
		{
			get
			{
				if (_overriddenPlayerName == null)
				{
					_overriddenPlayerName = (CName) CR2WTypeManager.Create("CName", "overriddenPlayerName", cr2w, this);
				}
				return _overriddenPlayerName;
			}
			set
			{
				if (_overriddenPlayerName == value)
				{
					return;
				}
				_overriddenPlayerName = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("isParallaxEnabled")] 
		public CBool IsParallaxEnabled
		{
			get
			{
				if (_isParallaxEnabled == null)
				{
					_isParallaxEnabled = (CBool) CR2WTypeManager.Create("Bool", "isParallaxEnabled", cr2w, this);
				}
				return _isParallaxEnabled;
			}
			set
			{
				if (_isParallaxEnabled == value)
				{
					return;
				}
				_isParallaxEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("prefetchVideo")] 
		public CBool PrefetchVideo
		{
			get
			{
				if (_prefetchVideo == null)
				{
					_prefetchVideo = (CBool) CR2WTypeManager.Create("Bool", "prefetchVideo", cr2w, this);
				}
				return _prefetchVideo;
			}
			set
			{
				if (_prefetchVideo == value)
				{
					return;
				}
				_prefetchVideo = value;
				PropertySet(this);
			}
		}

		public inkVideoWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
