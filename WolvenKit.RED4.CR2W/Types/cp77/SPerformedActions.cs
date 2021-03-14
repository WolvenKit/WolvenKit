using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SPerformedActions : CVariable
	{
		private CName _iD;
		private CArray<CEnum<EActionContext>> _actionContext;

		[Ordinal(0)] 
		[RED("ID")] 
		public CName ID
		{
			get
			{
				if (_iD == null)
				{
					_iD = (CName) CR2WTypeManager.Create("CName", "ID", cr2w, this);
				}
				return _iD;
			}
			set
			{
				if (_iD == value)
				{
					return;
				}
				_iD = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ActionContext")] 
		public CArray<CEnum<EActionContext>> ActionContext
		{
			get
			{
				if (_actionContext == null)
				{
					_actionContext = (CArray<CEnum<EActionContext>>) CR2WTypeManager.Create("array:EActionContext", "ActionContext", cr2w, this);
				}
				return _actionContext;
			}
			set
			{
				if (_actionContext == value)
				{
					return;
				}
				_actionContext = value;
				PropertySet(this);
			}
		}

		public SPerformedActions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
