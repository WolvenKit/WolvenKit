using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitIsTheSameTargetPrereq : GenericHitPrereq
	{
		private CBool _isMoving;
		private CString _object;
		private CBool _invert;

		[Ordinal(5)] 
		[RED("isMoving")] 
		public CBool IsMoving
		{
			get
			{
				if (_isMoving == null)
				{
					_isMoving = (CBool) CR2WTypeManager.Create("Bool", "isMoving", cr2w, this);
				}
				return _isMoving;
			}
			set
			{
				if (_isMoving == value)
				{
					return;
				}
				_isMoving = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("object")] 
		public CString Object
		{
			get
			{
				if (_object == null)
				{
					_object = (CString) CR2WTypeManager.Create("String", "object", cr2w, this);
				}
				return _object;
			}
			set
			{
				if (_object == value)
				{
					return;
				}
				_object = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("invert")] 
		public CBool Invert
		{
			get
			{
				if (_invert == null)
				{
					_invert = (CBool) CR2WTypeManager.Create("Bool", "invert", cr2w, this);
				}
				return _invert;
			}
			set
			{
				if (_invert == value)
				{
					return;
				}
				_invert = value;
				PropertySet(this);
			}
		}

		public HitIsTheSameTargetPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
