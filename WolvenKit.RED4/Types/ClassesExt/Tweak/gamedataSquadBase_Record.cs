
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSquadBase_Record
	{
		[RED("defensiveBackyard")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DefensiveBackyard
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("defensiveLeftFence")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DefensiveLeftFence
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("defensiveRightFence")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DefensiveRightFence
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("hasActiveAlley")]
		[REDProperty(IsIgnored = true)]
		public CBool HasActiveAlley
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("offensiveBackyard")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID OffensiveBackyard
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("offensiveLeftFence")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID OffensiveLeftFence
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("offensiveRightFence")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID OffensiveRightFence
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("scriptHandler")]
		[REDProperty(IsIgnored = true)]
		public CName ScriptHandler
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("squadParams")]
		[REDProperty(IsIgnored = true)]
		public CName SquadParams
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
