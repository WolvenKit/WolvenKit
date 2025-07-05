
namespace WolvenKit.RED4.Types
{
	public partial class gamedataNPCTypePrereq_Record
	{
		[RED("allowedTypes")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> AllowedTypes
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("invert")]
		[REDProperty(IsIgnored = true)]
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
