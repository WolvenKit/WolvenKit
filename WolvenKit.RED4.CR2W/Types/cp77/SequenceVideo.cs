using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SequenceVideo : CVariable
	{
		private redResourceReferenceScriptToken _videoPath;
		private CName _audioEvent;
		private CBool _looped;

		[Ordinal(0)] 
		[RED("videoPath")] 
		public redResourceReferenceScriptToken VideoPath
		{
			get
			{
				if (_videoPath == null)
				{
					_videoPath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "videoPath", cr2w, this);
				}
				return _videoPath;
			}
			set
			{
				if (_videoPath == value)
				{
					return;
				}
				_videoPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("looped")] 
		public CBool Looped
		{
			get
			{
				if (_looped == null)
				{
					_looped = (CBool) CR2WTypeManager.Create("Bool", "looped", cr2w, this);
				}
				return _looped;
			}
			set
			{
				if (_looped == value)
				{
					return;
				}
				_looped = value;
				PropertySet(this);
			}
		}

		public SequenceVideo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
