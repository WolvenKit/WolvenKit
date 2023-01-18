using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIGateSignalSender : AIbehaviortaskStackScript
	{
		[Ordinal(0)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("flags")] 
		public CArray<CEnum<EAIGateSignalFlags>> Flags
		{
			get => GetPropertyValue<CArray<CEnum<EAIGateSignalFlags>>>();
			set => SetPropertyValue<CArray<CEnum<EAIGateSignalFlags>>>(value);
		}

		[Ordinal(2)] 
		[RED("priority")] 
		public CFloat Priority
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIGateSignalSender()
		{
			Tags = new();
			Flags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
