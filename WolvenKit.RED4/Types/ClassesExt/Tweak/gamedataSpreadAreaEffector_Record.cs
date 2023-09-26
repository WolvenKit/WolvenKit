
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSpreadAreaEffector_Record
	{
		[RED("maxTargetNum")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxTargetNum
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("objectActions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ObjectActions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("range")]
		[REDProperty(IsIgnored = true)]
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
