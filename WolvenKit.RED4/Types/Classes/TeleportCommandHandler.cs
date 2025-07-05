using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TeleportCommandHandler : AICommandHandlerBase
	{
		[Ordinal(1)] 
		[RED("position")] 
		public CHandle<AIArgumentMapping> Position
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("rotation")] 
		public CHandle<AIArgumentMapping> Rotation
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("doNavTest")] 
		public CHandle<AIArgumentMapping> DoNavTest
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public TeleportCommandHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
