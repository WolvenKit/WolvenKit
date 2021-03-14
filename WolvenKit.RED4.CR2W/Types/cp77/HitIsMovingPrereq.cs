using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitIsMovingPrereq : GenericHitPrereq
	{
		private CBool _isMoving;
		private CString _object;

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

		public HitIsMovingPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
