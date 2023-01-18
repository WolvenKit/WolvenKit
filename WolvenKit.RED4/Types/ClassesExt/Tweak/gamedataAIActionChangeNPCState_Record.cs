
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIActionChangeNPCState_Record
	{
		[RED("defenseMode")]
		[REDProperty(IsIgnored = true)]
		public CName DefenseMode
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("highLevelState")]
		[REDProperty(IsIgnored = true)]
		public CName HighLevelState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("hitReactionMode")]
		[REDProperty(IsIgnored = true)]
		public CName HitReactionMode
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("locomotionMode")]
		[REDProperty(IsIgnored = true)]
		public CName LocomotionMode
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("stanceState")]
		[REDProperty(IsIgnored = true)]
		public CName StanceState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("upperBodyState")]
		[REDProperty(IsIgnored = true)]
		public CName UpperBodyState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
