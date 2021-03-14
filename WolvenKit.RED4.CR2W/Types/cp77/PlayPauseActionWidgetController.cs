using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayPauseActionWidgetController : NextPreviousActionWidgetController
	{
		private inkWidgetReference _playContainer;
		private CBool _isPlaying;

		[Ordinal(32)] 
		[RED("playContainer")] 
		public inkWidgetReference PlayContainer
		{
			get
			{
				if (_playContainer == null)
				{
					_playContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "playContainer", cr2w, this);
				}
				return _playContainer;
			}
			set
			{
				if (_playContainer == value)
				{
					return;
				}
				_playContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("isPlaying")] 
		public CBool IsPlaying
		{
			get
			{
				if (_isPlaying == null)
				{
					_isPlaying = (CBool) CR2WTypeManager.Create("Bool", "isPlaying", cr2w, this);
				}
				return _isPlaying;
			}
			set
			{
				if (_isPlaying == value)
				{
					return;
				}
				_isPlaying = value;
				PropertySet(this);
			}
		}

		public PlayPauseActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
