using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePrereqData : CVariable
	{
		private CBool _bAndValues;
		private CArray<gamePrereqCheckData> _prereqList;

		[Ordinal(0)] 
		[RED("bAndValues")] 
		public CBool BAndValues
		{
			get
			{
				if (_bAndValues == null)
				{
					_bAndValues = (CBool) CR2WTypeManager.Create("Bool", "bAndValues", cr2w, this);
				}
				return _bAndValues;
			}
			set
			{
				if (_bAndValues == value)
				{
					return;
				}
				_bAndValues = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("prereqList")] 
		public CArray<gamePrereqCheckData> PrereqList
		{
			get
			{
				if (_prereqList == null)
				{
					_prereqList = (CArray<gamePrereqCheckData>) CR2WTypeManager.Create("array:gamePrereqCheckData", "prereqList", cr2w, this);
				}
				return _prereqList;
			}
			set
			{
				if (_prereqList == value)
				{
					return;
				}
				_prereqList = value;
				PropertySet(this);
			}
		}

		public gamePrereqData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
