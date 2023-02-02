using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MountCommandHandlerTask : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("command")] 
		public CHandle<AIArgumentMapping> Command
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("mountEventData")] 
		public CHandle<AIArgumentMapping> MountEventData
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("callbackName")] 
		public CName CallbackName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public MountCommandHandlerTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
