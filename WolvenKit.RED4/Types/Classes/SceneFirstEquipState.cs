using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SceneFirstEquipState : redEvent
	{
		[Ordinal(0)] 
		[RED("prevented")] 
		public CBool Prevented
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SceneFirstEquipState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
