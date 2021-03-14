using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questFinalBoardsOpenSpeakerScreen_NodeType : questIUIManagerNodeType
	{
		private CBool _openSpeakerScreen;
		private CString _speakerName;

		[Ordinal(0)] 
		[RED("openSpeakerScreen")] 
		public CBool OpenSpeakerScreen
		{
			get
			{
				if (_openSpeakerScreen == null)
				{
					_openSpeakerScreen = (CBool) CR2WTypeManager.Create("Bool", "openSpeakerScreen", cr2w, this);
				}
				return _openSpeakerScreen;
			}
			set
			{
				if (_openSpeakerScreen == value)
				{
					return;
				}
				_openSpeakerScreen = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("speakerName")] 
		public CString SpeakerName
		{
			get
			{
				if (_speakerName == null)
				{
					_speakerName = (CString) CR2WTypeManager.Create("String", "speakerName", cr2w, this);
				}
				return _speakerName;
			}
			set
			{
				if (_speakerName == value)
				{
					return;
				}
				_speakerName = value;
				PropertySet(this);
			}
		}

		public questFinalBoardsOpenSpeakerScreen_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
