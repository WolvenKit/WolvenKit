using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMinigameNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CBool _start;
		private CBool _skipSummaryScreen;
		private gameEntityReference _networkRef;

		[Ordinal(2)] 
		[RED("start")] 
		public CBool Start
		{
			get
			{
				if (_start == null)
				{
					_start = (CBool) CR2WTypeManager.Create("Bool", "start", cr2w, this);
				}
				return _start;
			}
			set
			{
				if (_start == value)
				{
					return;
				}
				_start = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("skipSummaryScreen")] 
		public CBool SkipSummaryScreen
		{
			get
			{
				if (_skipSummaryScreen == null)
				{
					_skipSummaryScreen = (CBool) CR2WTypeManager.Create("Bool", "skipSummaryScreen", cr2w, this);
				}
				return _skipSummaryScreen;
			}
			set
			{
				if (_skipSummaryScreen == value)
				{
					return;
				}
				_skipSummaryScreen = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("networkRef")] 
		public gameEntityReference NetworkRef
		{
			get
			{
				if (_networkRef == null)
				{
					_networkRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "networkRef", cr2w, this);
				}
				return _networkRef;
			}
			set
			{
				if (_networkRef == value)
				{
					return;
				}
				_networkRef = value;
				PropertySet(this);
			}
		}

		public questMinigameNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
