
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAICooldownCond_Record
	{
		[RED("cooldowns")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Cooldowns
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
