using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class ActionWorkSpot : ActionBool
	{
		[Ordinal(39)] 
		[RED("workspotTarget")] 
		public CWeakHandle<gamePuppet> WorkspotTarget
		{
			get => GetPropertyValue<CWeakHandle<gamePuppet>>();
			set => SetPropertyValue<CWeakHandle<gamePuppet>>(value);
		}

		public ActionWorkSpot()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
