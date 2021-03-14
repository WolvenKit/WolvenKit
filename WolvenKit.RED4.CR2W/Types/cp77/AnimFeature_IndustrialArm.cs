using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_IndustrialArm : animAnimFeature
	{
		private CInt32 _idleAnimNumber;
		private CBool _isRotate;
		private CBool _isDistraction;
		private CBool _isPoke;

		[Ordinal(0)] 
		[RED("idleAnimNumber")] 
		public CInt32 IdleAnimNumber
		{
			get
			{
				if (_idleAnimNumber == null)
				{
					_idleAnimNumber = (CInt32) CR2WTypeManager.Create("Int32", "idleAnimNumber", cr2w, this);
				}
				return _idleAnimNumber;
			}
			set
			{
				if (_idleAnimNumber == value)
				{
					return;
				}
				_idleAnimNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isRotate")] 
		public CBool IsRotate
		{
			get
			{
				if (_isRotate == null)
				{
					_isRotate = (CBool) CR2WTypeManager.Create("Bool", "isRotate", cr2w, this);
				}
				return _isRotate;
			}
			set
			{
				if (_isRotate == value)
				{
					return;
				}
				_isRotate = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isDistraction")] 
		public CBool IsDistraction
		{
			get
			{
				if (_isDistraction == null)
				{
					_isDistraction = (CBool) CR2WTypeManager.Create("Bool", "isDistraction", cr2w, this);
				}
				return _isDistraction;
			}
			set
			{
				if (_isDistraction == value)
				{
					return;
				}
				_isDistraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isPoke")] 
		public CBool IsPoke
		{
			get
			{
				if (_isPoke == null)
				{
					_isPoke = (CBool) CR2WTypeManager.Create("Bool", "isPoke", cr2w, this);
				}
				return _isPoke;
			}
			set
			{
				if (_isPoke == value)
				{
					return;
				}
				_isPoke = value;
				PropertySet(this);
			}
		}

		public AnimFeature_IndustrialArm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
