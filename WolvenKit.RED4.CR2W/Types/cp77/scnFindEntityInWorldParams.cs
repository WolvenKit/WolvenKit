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
			get => GetProperty(ref _actorRef);
			set => SetProperty(ref _actorRef, value);
		}

		[Ordinal(1)] 
		[RED("forceMaxVisibility")] 
		public CBool ForceMaxVisibility
		{
			get => GetProperty(ref _forceMaxVisibility);
			set => SetProperty(ref _forceMaxVisibility, value);
		}

		public scnFindEntityInWorldParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
