
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAINodeMapField_Record
	{
		[RED("forLOD")]
		[REDProperty(IsIgnored = true)]
		public CInt32 ForLOD
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("isOverriddenBy")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID IsOverriddenBy
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("node")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Node
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
