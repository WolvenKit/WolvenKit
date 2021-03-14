using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestPhase : gameJournalContainerEntry
	{
		private NodeRef _locationPrefabRef;

		[Ordinal(2)] 
		[RED("locationPrefabRef")] 
		public NodeRef LocationPrefabRef
		{
			get
			{
				if (_locationPrefabRef == null)
				{
					_locationPrefabRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "locationPrefabRef", cr2w, this);
				}
				return _locationPrefabRef;
			}
			set
			{
				if (_locationPrefabRef == value)
				{
					return;
				}
				_locationPrefabRef = value;
				PropertySet(this);
			}
		}

		public gameJournalQuestPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
