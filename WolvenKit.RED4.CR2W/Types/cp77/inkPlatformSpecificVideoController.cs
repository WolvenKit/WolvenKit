using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkPlatformSpecificVideoController : inkWidgetLogicController
	{
		private CBool _isLooped;
		private raRef<Bink> _video;
		private raRef<Bink> _video_PS4;
		private raRef<Bink> _video_XB1;

		[Ordinal(1)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get
			{
				if (_isLooped == null)
				{
					_isLooped = (CBool) CR2WTypeManager.Create("Bool", "isLooped", cr2w, this);
				}
				return _isLooped;
			}
			set
			{
				if (_isLooped == value)
				{
					return;
				}
				_isLooped = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("video_PS4")] 
		public raRef<Bink> Video_PS4
		{
			get
			{
				if (_video_PS4 == null)
				{
					_video_PS4 = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "video_PS4", cr2w, this);
				}
				return _video_PS4;
			}
			set
			{
				if (_video_PS4 == value)
				{
					return;
				}
				_video_PS4 = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("video_XB1")] 
		public raRef<Bink> Video_XB1
		{
			get
			{
				if (_video_XB1 == null)
				{
					_video_XB1 = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "video_XB1", cr2w, this);
				}
				return _video_XB1;
			}
			set
			{
				if (_video_XB1 == value)
				{
					return;
				}
				_video_XB1 = value;
				PropertySet(this);
			}
		}

		public inkPlatformSpecificVideoController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
