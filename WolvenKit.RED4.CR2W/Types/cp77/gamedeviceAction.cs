using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedeviceAction : redEvent
	{
		private CName _actionName;
		private CInt32 _clearanceLevel;
		private CString _localizedObjectName;

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
		[RED("clearanceLevel")] 
		public CInt32 ClearanceLevel
		{
			get
			{
				if (_clearanceLevel == null)
				{
					_clearanceLevel = (CInt32) CR2WTypeManager.Create("Int32", "clearanceLevel", cr2w, this);
				}
				return _clearanceLevel;
			}
			set
			{
				if (_clearanceLevel == value)
				{
					return;
				}
				_clearanceLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("localizedObjectName")] 
		public CString LocalizedObjectName
		{
			get
			{
				if (_localizedObjectName == null)
				{
					_localizedObjectName = (CString) CR2WTypeManager.Create("String", "localizedObjectName", cr2w, this);
				}
				return _localizedObjectName;
			}
			set
			{
				if (_localizedObjectName == value)
				{
					return;
				}
				_localizedObjectName = value;
				PropertySet(this);
			}
		}

		public gamedeviceAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
