using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_LocoState : animAnimNode_State
	{
		[Ordinal(17)] 
		[RED("type")] 
		public CEnum<animLocoStateType> Type
		{
			get => GetPropertyValue<CEnum<animLocoStateType>>();
			set => SetPropertyValue<CEnum<animLocoStateType>>(value);
		}

		[Ordinal(18)] 
		[RED("locoTag")] 
		public CName LocoTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimNode_LocoState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
