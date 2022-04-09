using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSignalPriorityDefinition : ISerializable
	{
		[Ordinal(0)] 
		[RED("defaultPriority")] 
		public CUInt16 DefaultPriority
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public gameSignalPriorityDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
