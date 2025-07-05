
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRangedAttack_Record
	{
		[RED("NPCAttack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID NPCAttack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("NPCTimeDilated")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID NPCTimeDilated
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("playerAttack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PlayerAttack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("playerTimeDilated")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PlayerTimeDilated
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("secondaryPlayerAttack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID SecondaryPlayerAttack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("secondaryPlayerTimeDilated")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID SecondaryPlayerTimeDilated
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
