using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBinkVideoEvent : redEvent
	{
		private CString _videoPath;
		private CEnum<gameBinkVideoAction> _action;

		[Ordinal(0)] 
		[RED("videoPath")] 
		public CString VideoPath
		{
			get
			{
				if (_videoPath == null)
				{
					_videoPath = (CString) CR2WTypeManager.Create("String", "videoPath", cr2w, this);
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
		[RED("action")] 
		public CEnum<gameBinkVideoAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<gameBinkVideoAction>) CR2WTypeManager.Create("gameBinkVideoAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		public gameBinkVideoEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
