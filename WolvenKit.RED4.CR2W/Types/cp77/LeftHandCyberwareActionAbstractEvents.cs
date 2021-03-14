using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LeftHandCyberwareActionAbstractEvents : LeftHandCyberwareEventsTransition
	{
		private CBool _projectileReleased;

		[Ordinal(0)] 
		[RED("projectileReleased")] 
		public CBool ProjectileReleased
		{
			get
			{
				if (_projectileReleased == null)
				{
					_projectileReleased = (CBool) CR2WTypeManager.Create("Bool", "projectileReleased", cr2w, this);
				}
				return _projectileReleased;
			}
			set
			{
				if (_projectileReleased == value)
				{
					return;
				}
				_projectileReleased = value;
				PropertySet(this);
			}
		}

		public LeftHandCyberwareActionAbstractEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
