using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTriggerNotifier_Entity : worldITriggerAreaNotifer
	{
		private NodeRef _entityRef;

		[Ordinal(3)] 
		[RED("entityRef")] 
		public NodeRef EntityRef
		{
			get
			{
				if (_entityRef == null)
				{
					_entityRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "entityRef", cr2w, this);
				}
				return _entityRef;
			}
			set
			{
				if (_entityRef == value)
				{
					return;
				}
				_entityRef = value;
				PropertySet(this);
			}
		}

		public entTriggerNotifier_Entity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
