using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MonitorMeleeCombo : AIActionHelperTask
	{
		[Ordinal(5)] 
		[RED("ExitComboBoolArgumentRef")] 
		public CName ExitComboBoolArgumentRef
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("PreviousReactionIntArgumentRef")] 
		public CName PreviousReactionIntArgumentRef
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("CurrentAttackIntArgumentRef")] 
		public CName CurrentAttackIntArgumentRef
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("ComboCountIntArgumentRef")] 
		public CName ComboCountIntArgumentRef
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("ComboToIdleBoolArgumentRef")] 
		public CName ComboToIdleBoolArgumentRef
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public MonitorMeleeCombo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
