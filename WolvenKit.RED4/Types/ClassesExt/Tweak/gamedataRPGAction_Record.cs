
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRPGAction_Record
	{
		[RED("actionName")]
		[REDProperty(IsIgnored = true)]
		public CName ActionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("prereqs")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Prereqs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("reward")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Reward
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("visibilityConeStartAngle")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VisibilityConeStartAngle
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
