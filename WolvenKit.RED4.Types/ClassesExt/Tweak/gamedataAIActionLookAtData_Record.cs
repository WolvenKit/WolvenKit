
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIActionLookAtData_Record
	{
		[RED("activationCondition")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ActivationCondition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("offset")]
		[REDProperty(IsIgnored = true)]
		public Vector3 Offset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("preset")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Preset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("timeDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat TimeDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
