
namespace WolvenKit.RED4.Types
{
	public partial class gamedataObjectActionPrereq_Record
	{
		[RED("failureConditionPrereq")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> FailureConditionPrereq
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("failureExplanation")]
		[REDProperty(IsIgnored = true)]
		public CString FailureExplanation
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
