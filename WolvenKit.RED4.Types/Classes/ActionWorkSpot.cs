using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionWorkSpot : ActionBool
	{
		[Ordinal(25)] 
		[RED("workspotTarget")] 
		public CWeakHandle<gamePuppet> WorkspotTarget
		{
			get => GetPropertyValue<CWeakHandle<gamePuppet>>();
			set => SetPropertyValue<CWeakHandle<gamePuppet>>(value);
		}
	}
}
