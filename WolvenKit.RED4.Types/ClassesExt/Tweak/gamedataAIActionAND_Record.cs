
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIActionAND_Record
	{
		[RED("AND")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> AND
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
