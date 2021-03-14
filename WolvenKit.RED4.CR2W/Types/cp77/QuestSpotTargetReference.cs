using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestSpotTargetReference : ActionEntityReference
	{
		private entEntityID _forcedTarget;

		[Ordinal(25)] 
		[RED("ForcedTarget")] 
		public entEntityID ForcedTarget
		{
			get
			{
				if (_forcedTarget == null)
				{
					_forcedTarget = (entEntityID) CR2WTypeManager.Create("entEntityID", "ForcedTarget", cr2w, this);
				}
				return _forcedTarget;
			}
			set
			{
				if (_forcedTarget == value)
				{
					return;
				}
				_forcedTarget = value;
				PropertySet(this);
			}
		}

		public QuestSpotTargetReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
