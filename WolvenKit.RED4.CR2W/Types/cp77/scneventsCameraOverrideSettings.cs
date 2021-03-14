using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsCameraOverrideSettings : CVariable
	{
		private CBool _overrideFov;
		private CBool _overrideDof;
		private CBool _resetFov;
		private CBool _resetDof;

		[Ordinal(0)] 
		[RED("overrideFov")] 
		public CBool OverrideFov
		{
			get
			{
				if (_overrideFov == null)
				{
					_overrideFov = (CBool) CR2WTypeManager.Create("Bool", "overrideFov", cr2w, this);
				}
				return _overrideFov;
			}
			set
			{
				if (_overrideFov == value)
				{
					return;
				}
				_overrideFov = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("overrideDof")] 
		public CBool OverrideDof
		{
			get
			{
				if (_overrideDof == null)
				{
					_overrideDof = (CBool) CR2WTypeManager.Create("Bool", "overrideDof", cr2w, this);
				}
				return _overrideDof;
			}
			set
			{
				if (_overrideDof == value)
				{
					return;
				}
				_overrideDof = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("resetFov")] 
		public CBool ResetFov
		{
			get
			{
				if (_resetFov == null)
				{
					_resetFov = (CBool) CR2WTypeManager.Create("Bool", "resetFov", cr2w, this);
				}
				return _resetFov;
			}
			set
			{
				if (_resetFov == value)
				{
					return;
				}
				_resetFov = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("resetDof")] 
		public CBool ResetDof
		{
			get
			{
				if (_resetDof == null)
				{
					_resetDof = (CBool) CR2WTypeManager.Create("Bool", "resetDof", cr2w, this);
				}
				return _resetDof;
			}
			set
			{
				if (_resetDof == value)
				{
					return;
				}
				_resetDof = value;
				PropertySet(this);
			}
		}

		public scneventsCameraOverrideSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
