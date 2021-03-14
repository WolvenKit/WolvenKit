using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_RagdollState : animAnimFeature
	{
		private CBool _isActive;
		private CFloat _hipsPolePitch;
		private CFloat _speed;

		[Ordinal(0)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hipsPolePitch")] 
		public CFloat HipsPolePitch
		{
			get
			{
				if (_hipsPolePitch == null)
				{
					_hipsPolePitch = (CFloat) CR2WTypeManager.Create("Float", "hipsPolePitch", cr2w, this);
				}
				return _hipsPolePitch;
			}
			set
			{
				if (_hipsPolePitch == value)
				{
					return;
				}
				_hipsPolePitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (CFloat) CR2WTypeManager.Create("Float", "speed", cr2w, this);
				}
				return _speed;
			}
			set
			{
				if (_speed == value)
				{
					return;
				}
				_speed = value;
				PropertySet(this);
			}
		}

		public AnimFeature_RagdollState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
