using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questOpenPhotoMode_NodeType : questIUIManagerNodeType
	{
		private CString _factName;
		private CBool _forceFppMode;
		private CBool _alwaysAllowTPP;
		private CBool _lockExitUntilScreenshot;

		[Ordinal(0)] 
		[RED("factName")] 
		public CString FactName
		{
			get
			{
				if (_factName == null)
				{
					_factName = (CString) CR2WTypeManager.Create("String", "factName", cr2w, this);
				}
				return _factName;
			}
			set
			{
				if (_factName == value)
				{
					return;
				}
				_factName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("forceFppMode")] 
		public CBool ForceFppMode
		{
			get
			{
				if (_forceFppMode == null)
				{
					_forceFppMode = (CBool) CR2WTypeManager.Create("Bool", "forceFppMode", cr2w, this);
				}
				return _forceFppMode;
			}
			set
			{
				if (_forceFppMode == value)
				{
					return;
				}
				_forceFppMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("alwaysAllowTPP")] 
		public CBool AlwaysAllowTPP
		{
			get
			{
				if (_alwaysAllowTPP == null)
				{
					_alwaysAllowTPP = (CBool) CR2WTypeManager.Create("Bool", "alwaysAllowTPP", cr2w, this);
				}
				return _alwaysAllowTPP;
			}
			set
			{
				if (_alwaysAllowTPP == value)
				{
					return;
				}
				_alwaysAllowTPP = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lockExitUntilScreenshot")] 
		public CBool LockExitUntilScreenshot
		{
			get
			{
				if (_lockExitUntilScreenshot == null)
				{
					_lockExitUntilScreenshot = (CBool) CR2WTypeManager.Create("Bool", "lockExitUntilScreenshot", cr2w, this);
				}
				return _lockExitUntilScreenshot;
			}
			set
			{
				if (_lockExitUntilScreenshot == value)
				{
					return;
				}
				_lockExitUntilScreenshot = value;
				PropertySet(this);
			}
		}

		public questOpenPhotoMode_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
