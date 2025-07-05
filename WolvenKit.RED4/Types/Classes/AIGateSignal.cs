using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIGateSignal : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("tags", 4)] 
		public CStatic<CName> Tags
		{
			get => GetPropertyValue<CStatic<CName>>();
			set => SetPropertyValue<CStatic<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("flags")] 
		public CEnum<AISignalFlags> Flags
		{
			get => GetPropertyValue<CEnum<AISignalFlags>>();
			set => SetPropertyValue<CEnum<AISignalFlags>>(value);
		}

		[Ordinal(2)] 
		[RED("priority")] 
		public CFloat Priority
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("lifeTime")] 
		public CFloat LifeTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIGateSignal()
		{
			Tags = new(0);
			Priority = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
