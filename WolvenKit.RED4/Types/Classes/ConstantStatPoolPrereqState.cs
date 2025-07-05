using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ConstantStatPoolPrereqState : StatPoolPrereqState
	{
		[Ordinal(4)] 
		[RED("listenConstantly")] 
		public CBool ListenConstantly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ConstantStatPoolPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
