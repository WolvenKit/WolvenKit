using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questOverrideLoadingScreen_NodeType : questIUIManagerNodeType
	{
		private raRef<Bink> _video;
		private CArray<raRef<Bink>> _videos;
		private CUInt32 _minimumPlayCount;
		private CBool _forceVideoFrameRate;
		private CArray<CString> _tooltips;
		private CFloat _tooltipDuration;
		private CFloat _glitchEffectTime;
		private CBool _keepLoadingScreenWhileVideoIsPlaying;

		[Ordinal(0)] 
		[RED("video")] 
		public raRef<Bink> Video
		{
			get
			{
				if (_video == null)
				{
					_video = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "video", cr2w, this);
				}
				return _video;
			}
			set
			{
				if (_video == value)
				{
					return;
				}
				_video = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("videos")] 
		public CArray<raRef<Bink>> Videos
		{
			get
			{
				if (_videos == null)
				{
					_videos = (CArray<raRef<Bink>>) CR2WTypeManager.Create("array:raRef:Bink", "videos", cr2w, this);
				}
				return _videos;
			}
			set
			{
				if (_videos == value)
				{
					return;
				}
				_videos = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("minimumPlayCount")] 
		public CUInt32 MinimumPlayCount
		{
			get
			{
				if (_minimumPlayCount == null)
				{
					_minimumPlayCount = (CUInt32) CR2WTypeManager.Create("Uint32", "minimumPlayCount", cr2w, this);
				}
				return _minimumPlayCount;
			}
			set
			{
				if (_minimumPlayCount == value)
				{
					return;
				}
				_minimumPlayCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("forceVideoFrameRate")] 
		public CBool ForceVideoFrameRate
		{
			get
			{
				if (_forceVideoFrameRate == null)
				{
					_forceVideoFrameRate = (CBool) CR2WTypeManager.Create("Bool", "forceVideoFrameRate", cr2w, this);
				}
				return _forceVideoFrameRate;
			}
			set
			{
				if (_forceVideoFrameRate == value)
				{
					return;
				}
				_forceVideoFrameRate = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("tooltips")] 
		public CArray<CString> Tooltips
		{
			get
			{
				if (_tooltips == null)
				{
					_tooltips = (CArray<CString>) CR2WTypeManager.Create("array:String", "tooltips", cr2w, this);
				}
				return _tooltips;
			}
			set
			{
				if (_tooltips == value)
				{
					return;
				}
				_tooltips = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("tooltipDuration")] 
		public CFloat TooltipDuration
		{
			get
			{
				if (_tooltipDuration == null)
				{
					_tooltipDuration = (CFloat) CR2WTypeManager.Create("Float", "tooltipDuration", cr2w, this);
				}
				return _tooltipDuration;
			}
			set
			{
				if (_tooltipDuration == value)
				{
					return;
				}
				_tooltipDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("glitchEffectTime")] 
		public CFloat GlitchEffectTime
		{
			get
			{
				if (_glitchEffectTime == null)
				{
					_glitchEffectTime = (CFloat) CR2WTypeManager.Create("Float", "glitchEffectTime", cr2w, this);
				}
				return _glitchEffectTime;
			}
			set
			{
				if (_glitchEffectTime == value)
				{
					return;
				}
				_glitchEffectTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("keepLoadingScreenWhileVideoIsPlaying")] 
		public CBool KeepLoadingScreenWhileVideoIsPlaying
		{
			get
			{
				if (_keepLoadingScreenWhileVideoIsPlaying == null)
				{
					_keepLoadingScreenWhileVideoIsPlaying = (CBool) CR2WTypeManager.Create("Bool", "keepLoadingScreenWhileVideoIsPlaying", cr2w, this);
				}
				return _keepLoadingScreenWhileVideoIsPlaying;
			}
			set
			{
				if (_keepLoadingScreenWhileVideoIsPlaying == value)
				{
					return;
				}
				_keepLoadingScreenWhileVideoIsPlaying = value;
				PropertySet(this);
			}
		}

		public questOverrideLoadingScreen_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
