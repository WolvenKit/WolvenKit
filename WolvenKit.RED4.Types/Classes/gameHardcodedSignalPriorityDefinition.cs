using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameHardcodedSignalPriorityDefinition : gameSignalPriorityDefinition
	{
		[Ordinal(1)] 
		[RED("signals")] 
		public CArray<CName> Signals
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gameHardcodedSignalPriorityDefinition()
		{
			DefaultPriority = 65535;
			Signals = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
