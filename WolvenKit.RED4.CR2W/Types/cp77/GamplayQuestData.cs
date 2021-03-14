using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GamplayQuestData : IScriptable
	{
		private CString _questUniqueID;
		private CArray<CHandle<GemplayObjectiveData>> _objectives;

		[Ordinal(0)] 
		[RED("questUniqueID")] 
		public CString QuestUniqueID
		{
			get
			{
				if (_questUniqueID == null)
				{
					_questUniqueID = (CString) CR2WTypeManager.Create("String", "questUniqueID", cr2w, this);
				}
				return _questUniqueID;
			}
			set
			{
				if (_questUniqueID == value)
				{
					return;
				}
				_questUniqueID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("objectives")] 
		public CArray<CHandle<GemplayObjectiveData>> Objectives
		{
			get
			{
				if (_objectives == null)
				{
					_objectives = (CArray<CHandle<GemplayObjectiveData>>) CR2WTypeManager.Create("array:handle:GemplayObjectiveData", "objectives", cr2w, this);
				}
				return _objectives;
			}
			set
			{
				if (_objectives == value)
				{
					return;
				}
				_objectives = value;
				PropertySet(this);
			}
		}

		public GamplayQuestData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
