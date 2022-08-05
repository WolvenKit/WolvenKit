
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAILookAtCond_Record
	{
		[RED("rightArmLookAtActive")]
		[REDProperty(IsIgnored = true)]
		public CInt32 RightArmLookAtActive
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
