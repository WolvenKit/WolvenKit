using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionWorkSpot : ActionBool
	{
		private CWeakHandle<gamePuppet> _workspotTarget;

		[Ordinal(25)] 
		[RED("workspotTarget")] 
		public CWeakHandle<gamePuppet> WorkspotTarget
		{
			get => GetProperty(ref _workspotTarget);
			set => SetProperty(ref _workspotTarget, value);
		}
	}
}
