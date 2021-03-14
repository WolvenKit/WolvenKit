using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetAttitudeAnimationController : BasicAnimationController
	{
		private CName _hostileShowAnimation;
		private CName _hostileIdleAnimation;
		private CName _hostileHideAnimation;
		private CEnum<EAIAttitude> _attitude;

		[Ordinal(6)] 
		[RED("hostileShowAnimation")] 
		public CName HostileShowAnimation
		{
			get
			{
				if (_hostileShowAnimation == null)
				{
					_hostileShowAnimation = (CName) CR2WTypeManager.Create("CName", "hostileShowAnimation", cr2w, this);
				}
				return _hostileShowAnimation;
			}
			set
			{
				if (_hostileShowAnimation == value)
				{
					return;
				}
				_hostileShowAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("hostileIdleAnimation")] 
		public CName HostileIdleAnimation
		{
			get
			{
				if (_hostileIdleAnimation == null)
				{
					_hostileIdleAnimation = (CName) CR2WTypeManager.Create("CName", "hostileIdleAnimation", cr2w, this);
				}
				return _hostileIdleAnimation;
			}
			set
			{
				if (_hostileIdleAnimation == value)
				{
					return;
				}
				_hostileIdleAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("hostileHideAnimation")] 
		public CName HostileHideAnimation
		{
			get
			{
				if (_hostileHideAnimation == null)
				{
					_hostileHideAnimation = (CName) CR2WTypeManager.Create("CName", "hostileHideAnimation", cr2w, this);
				}
				return _hostileHideAnimation;
			}
			set
			{
				if (_hostileHideAnimation == value)
				{
					return;
				}
				_hostileHideAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get
			{
				if (_attitude == null)
				{
					_attitude = (CEnum<EAIAttitude>) CR2WTypeManager.Create("EAIAttitude", "attitude", cr2w, this);
				}
				return _attitude;
			}
			set
			{
				if (_attitude == value)
				{
					return;
				}
				_attitude = value;
				PropertySet(this);
			}
		}

		public TargetAttitudeAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
