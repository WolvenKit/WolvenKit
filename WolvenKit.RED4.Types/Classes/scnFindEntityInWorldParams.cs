using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnFindEntityInWorldParams : RedBaseClass
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
	}
}
