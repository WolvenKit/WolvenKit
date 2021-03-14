using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnFindEntityInWorldParams : CVariable
	{
		private gameEntityReference _actorRef;
		private CBool _forceMaxVisibility;

		[Ordinal(0)] 
		[RED("actorRef")] 
		public gameEntityReference ActorRef
		{
			get
			{
				if (_actorRef == null)
				{
					_actorRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "actorRef", cr2w, this);
				}
				return _actorRef;
			}
			set
			{
				if (_actorRef == value)
				{
					return;
				}
				_actorRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("forceMaxVisibility")] 
		public CBool ForceMaxVisibility
		{
			get
			{
				if (_forceMaxVisibility == null)
				{
					_forceMaxVisibility = (CBool) CR2WTypeManager.Create("Bool", "forceMaxVisibility", cr2w, this);
				}
				return _forceMaxVisibility;
			}
			set
			{
				if (_forceMaxVisibility == value)
				{
					return;
				}
				_forceMaxVisibility = value;
				PropertySet(this);
			}
		}

		public scnFindEntityInWorldParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
