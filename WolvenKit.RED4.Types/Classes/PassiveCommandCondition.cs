using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PassiveCommandCondition : AIbehaviorexpressionScript
	{
		[Ordinal(0)] 
		[RED("commandName")] 
		public CName CommandName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("useInheritance")] 
		public CBool UseInheritance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("cmdCbId")] 
		public CUInt32 CmdCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public PassiveCommandCondition()
		{
			UseInheritance = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
