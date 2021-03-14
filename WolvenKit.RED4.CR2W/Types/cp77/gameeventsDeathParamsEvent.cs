using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsDeathParamsEvent : redEvent
	{
		private CBool _noAnimation;
		private CBool _noRagdoll;

		[Ordinal(0)] 
		[RED("noAnimation")] 
		public CBool NoAnimation
		{
			get
			{
				if (_noAnimation == null)
				{
					_noAnimation = (CBool) CR2WTypeManager.Create("Bool", "noAnimation", cr2w, this);
				}
				return _noAnimation;
			}
			set
			{
				if (_noAnimation == value)
				{
					return;
				}
				_noAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("noRagdoll")] 
		public CBool NoRagdoll
		{
			get
			{
				if (_noRagdoll == null)
				{
					_noRagdoll = (CBool) CR2WTypeManager.Create("Bool", "noRagdoll", cr2w, this);
				}
				return _noRagdoll;
			}
			set
			{
				if (_noRagdoll == value)
				{
					return;
				}
				_noRagdoll = value;
				PropertySet(this);
			}
		}

		public gameeventsDeathParamsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
