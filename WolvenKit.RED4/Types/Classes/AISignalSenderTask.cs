using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class AISignalSenderTask : AIbehaviortaskScript
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

		[Ordinal(3)] 
		[RED("signalId")] 
		public CUInt32 SignalId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public AISignalSenderTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
