using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnGameplayTransitionEvent : scnSceneEvent
	{
		private scnPerformerId _performer;
		private CEnum<scnPuppetVehicleState> _vehState;

		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetProperty(ref _performer);
			set => SetProperty(ref _performer, value);
		}

		[Ordinal(7)] 
		[RED("vehState")] 
		public CEnum<scnPuppetVehicleState> VehState
		{
			get => GetProperty(ref _vehState);
			set => SetProperty(ref _vehState, value);
		}

		public scnGameplayTransitionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
