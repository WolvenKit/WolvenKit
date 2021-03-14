using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyStatPoolValueEffector : gameEffector
	{
		private CArray<wCHandle<gamedataStatPoolUpdate_Record>> _statPoolUpdates;
		private CBool _usePercent;
		private CString _applicationTarget;

		[Ordinal(0)] 
		[RED("statPoolUpdates")] 
		public CArray<wCHandle<gamedataStatPoolUpdate_Record>> StatPoolUpdates
		{
			get
			{
				if (_statPoolUpdates == null)
				{
					_statPoolUpdates = (CArray<wCHandle<gamedataStatPoolUpdate_Record>>) CR2WTypeManager.Create("array:whandle:gamedataStatPoolUpdate_Record", "statPoolUpdates", cr2w, this);
				}
				return _statPoolUpdates;
			}
			set
			{
				if (_statPoolUpdates == value)
				{
					return;
				}
				_statPoolUpdates = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("usePercent")] 
		public CBool UsePercent
		{
			get
			{
				if (_usePercent == null)
				{
					_usePercent = (CBool) CR2WTypeManager.Create("Bool", "usePercent", cr2w, this);
				}
				return _usePercent;
			}
			set
			{
				if (_usePercent == value)
				{
					return;
				}
				_usePercent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("applicationTarget")] 
		public CString ApplicationTarget
		{
			get
			{
				if (_applicationTarget == null)
				{
					_applicationTarget = (CString) CR2WTypeManager.Create("String", "applicationTarget", cr2w, this);
				}
				return _applicationTarget;
			}
			set
			{
				if (_applicationTarget == value)
				{
					return;
				}
				_applicationTarget = value;
				PropertySet(this);
			}
		}

		public ModifyStatPoolValueEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
