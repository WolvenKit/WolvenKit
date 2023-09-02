using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICommand : IScriptable
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<AICommandState> State
		{
			get => GetPropertyValue<CEnum<AICommandState>>();
			set => SetPropertyValue<CEnum<AICommandState>>(value);
		}

		[Ordinal(2)] 
		[RED("questBlockId")] 
		public CUInt64 QuestBlockId
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(3)] 
		[RED("category")] 
		public CName Category
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public AICommand()
		{
			Id = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
