using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionPrereqs : CVariable
	{
		private CName _actionName;
		private CArray<CHandle<gameIPrereq>> _prereqs;

		[Ordinal(0)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get
			{
				if (_actionName == null)
				{
					_actionName = (CName) CR2WTypeManager.Create("CName", "actionName", cr2w, this);
				}
				return _actionName;
			}
			set
			{
				if (_actionName == value)
				{
					return;
				}
				_actionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("prereqs")] 
		public CArray<CHandle<gameIPrereq>> Prereqs
		{
			get
			{
				if (_prereqs == null)
				{
					_prereqs = (CArray<CHandle<gameIPrereq>>) CR2WTypeManager.Create("array:handle:gameIPrereq", "prereqs", cr2w, this);
				}
				return _prereqs;
			}
			set
			{
				if (_prereqs == value)
				{
					return;
				}
				_prereqs = value;
				PropertySet(this);
			}
		}

		public gameActionPrereqs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
