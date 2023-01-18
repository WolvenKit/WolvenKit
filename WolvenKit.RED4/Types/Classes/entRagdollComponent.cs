using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entRagdollComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entRagdollComponent()
		{
			Name = "Component";
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
