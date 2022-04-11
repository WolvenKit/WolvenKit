using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StaggerDecisions : ReactionTransition
	{
		[Ordinal(0)] 
		[RED("textLayerId")] 
		public CUInt32 TextLayerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public StaggerDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
