using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SecurityTurretData : animAnimFeature
	{
		private CBool _shoot;
		private CBool _isRippedOff;
		private CBool _ripOffSide;
		private CBool _isOverriden;

		[Ordinal(0)] 
		[RED("Shoot")] 
		public CBool Shoot
		{
			get
			{
				if (_shoot == null)
				{
					_shoot = (CBool) CR2WTypeManager.Create("Bool", "Shoot", cr2w, this);
				}
				return _shoot;
			}
			set
			{
				if (_shoot == value)
				{
					return;
				}
				_shoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isRippedOff")] 
		public CBool IsRippedOff
		{
			get
			{
				if (_isRippedOff == null)
				{
					_isRippedOff = (CBool) CR2WTypeManager.Create("Bool", "isRippedOff", cr2w, this);
				}
				return _isRippedOff;
			}
			set
			{
				if (_isRippedOff == value)
				{
					return;
				}
				_isRippedOff = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ripOffSide")] 
		public CBool RipOffSide
		{
			get
			{
				if (_ripOffSide == null)
				{
					_ripOffSide = (CBool) CR2WTypeManager.Create("Bool", "ripOffSide", cr2w, this);
				}
				return _ripOffSide;
			}
			set
			{
				if (_ripOffSide == value)
				{
					return;
				}
				_ripOffSide = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isOverriden")] 
		public CBool IsOverriden
		{
			get
			{
				if (_isOverriden == null)
				{
					_isOverriden = (CBool) CR2WTypeManager.Create("Bool", "isOverriden", cr2w, this);
				}
				return _isOverriden;
			}
			set
			{
				if (_isOverriden == value)
				{
					return;
				}
				_isOverriden = value;
				PropertySet(this);
			}
		}

		public AnimFeature_SecurityTurretData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
