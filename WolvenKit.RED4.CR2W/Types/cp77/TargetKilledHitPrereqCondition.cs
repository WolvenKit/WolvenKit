using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetKilledHitPrereqCondition : BaseHitPrereqCondition
	{
		private wCHandle<gameObject> _lastTarget;

		[Ordinal(1)] 
		[RED("lastTarget")] 
		public wCHandle<gameObject> LastTarget
		{
			get
			{
				if (_lastTarget == null)
				{
					_lastTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "lastTarget", cr2w, this);
				}
				return _lastTarget;
			}
			set
			{
				if (_lastTarget == value)
				{
					return;
				}
				_lastTarget = value;
				PropertySet(this);
			}
		}

		public TargetKilledHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
