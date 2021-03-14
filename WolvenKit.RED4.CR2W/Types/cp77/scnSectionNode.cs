using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSectionNode : scnSceneGraphNode
	{
		private CArray<CHandle<scnSceneEvent>> _events;
		private scnSceneTime _sectionDuration;
		private CArray<scnSectionInternalsActorBehavior> _actorBehaviors;
		private CBool _isFocusClue;

		[Ordinal(3)] 
		[RED("events")] 
		public CArray<CHandle<scnSceneEvent>> Events
		{
			get
			{
				if (_events == null)
				{
					_events = (CArray<CHandle<scnSceneEvent>>) CR2WTypeManager.Create("array:handle:scnSceneEvent", "events", cr2w, this);
				}
				return _events;
			}
			set
			{
				if (_events == value)
				{
					return;
				}
				_events = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("sectionDuration")] 
		public scnSceneTime SectionDuration
		{
			get
			{
				if (_sectionDuration == null)
				{
					_sectionDuration = (scnSceneTime) CR2WTypeManager.Create("scnSceneTime", "sectionDuration", cr2w, this);
				}
				return _sectionDuration;
			}
			set
			{
				if (_sectionDuration == value)
				{
					return;
				}
				_sectionDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("actorBehaviors")] 
		public CArray<scnSectionInternalsActorBehavior> ActorBehaviors
		{
			get
			{
				if (_actorBehaviors == null)
				{
					_actorBehaviors = (CArray<scnSectionInternalsActorBehavior>) CR2WTypeManager.Create("array:scnSectionInternalsActorBehavior", "actorBehaviors", cr2w, this);
				}
				return _actorBehaviors;
			}
			set
			{
				if (_actorBehaviors == value)
				{
					return;
				}
				_actorBehaviors = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isFocusClue")] 
		public CBool IsFocusClue
		{
			get
			{
				if (_isFocusClue == null)
				{
					_isFocusClue = (CBool) CR2WTypeManager.Create("Bool", "isFocusClue", cr2w, this);
				}
				return _isFocusClue;
			}
			set
			{
				if (_isFocusClue == value)
				{
					return;
				}
				_isFocusClue = value;
				PropertySet(this);
			}
		}

		public scnSectionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
