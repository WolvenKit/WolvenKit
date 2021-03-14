using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinigameProgramData : CVariable
	{
		private TweakDBID _actionID;
		private CName _programName;

		[Ordinal(0)] 
		[RED("actionID")] 
		public TweakDBID ActionID
		{
			get
			{
				if (_actionID == null)
				{
					_actionID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "actionID", cr2w, this);
				}
				return _actionID;
			}
			set
			{
				if (_actionID == value)
				{
					return;
				}
				_actionID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("programName")] 
		public CName ProgramName
		{
			get
			{
				if (_programName == null)
				{
					_programName = (CName) CR2WTypeManager.Create("CName", "programName", cr2w, this);
				}
				return _programName;
			}
			set
			{
				if (_programName == value)
				{
					return;
				}
				_programName = value;
				PropertySet(this);
			}
		}

		public gameuiMinigameProgramData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
