using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexSystem : gameScriptableSystem
	{
		private CArray<SCodexRecord> _codex;
		private wCHandle<gameIBlackboard> _blackboard;

		[Ordinal(0)] 
		[RED("codex")] 
		public CArray<SCodexRecord> Codex
		{
			get
			{
				if (_codex == null)
				{
					_codex = (CArray<SCodexRecord>) CR2WTypeManager.Create("array:SCodexRecord", "codex", cr2w, this);
				}
				return _codex;
			}
			set
			{
				if (_codex == value)
				{
					return;
				}
				_codex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		public CodexSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
