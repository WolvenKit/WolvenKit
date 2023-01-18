using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AlertedRoleHandler : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("pathParamsModified")] 
		public CBool PathParamsModified
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AlertedRoleHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
