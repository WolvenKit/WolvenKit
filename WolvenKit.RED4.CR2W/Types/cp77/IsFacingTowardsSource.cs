using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsFacingTowardsSource : gameEffectObjectSingleFilter_Scripted
	{
		private CBool _applyForPlayer;
		private CBool _applyForNPCs;
		private CBool _invert;
		private CFloat _maxAllowedAngleYaw;
		private CFloat _maxAllowedAnglePitch;

		[Ordinal(0)] 
		[RED("applyForPlayer")] 
		public CBool ApplyForPlayer
		{
			get
			{
				if (_applyForPlayer == null)
				{
					_applyForPlayer = (CBool) CR2WTypeManager.Create("Bool", "applyForPlayer", cr2w, this);
				}
				return _applyForPlayer;
			}
			set
			{
				if (_applyForPlayer == value)
				{
					return;
				}
				_applyForPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("applyForNPCs")] 
		public CBool ApplyForNPCs
		{
			get
			{
				if (_applyForNPCs == null)
				{
					_applyForNPCs = (CBool) CR2WTypeManager.Create("Bool", "applyForNPCs", cr2w, this);
				}
				return _applyForNPCs;
			}
			set
			{
				if (_applyForNPCs == value)
				{
					return;
				}
				_applyForNPCs = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("maxAllowedAngleYaw")] 
		public CFloat MaxAllowedAngleYaw
		{
			get
			{
				if (_maxAllowedAngleYaw == null)
				{
					_maxAllowedAngleYaw = (CFloat) CR2WTypeManager.Create("Float", "maxAllowedAngleYaw", cr2w, this);
				}
				return _maxAllowedAngleYaw;
			}
			set
			{
				if (_maxAllowedAngleYaw == value)
				{
					return;
				}
				_maxAllowedAngleYaw = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maxAllowedAnglePitch")] 
		public CFloat MaxAllowedAnglePitch
		{
			get
			{
				if (_maxAllowedAnglePitch == null)
				{
					_maxAllowedAnglePitch = (CFloat) CR2WTypeManager.Create("Float", "maxAllowedAnglePitch", cr2w, this);
				}
				return _maxAllowedAnglePitch;
			}
			set
			{
				if (_maxAllowedAnglePitch == value)
				{
					return;
				}
				_maxAllowedAnglePitch = value;
				PropertySet(this);
			}
		}

		public IsFacingTowardsSource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
