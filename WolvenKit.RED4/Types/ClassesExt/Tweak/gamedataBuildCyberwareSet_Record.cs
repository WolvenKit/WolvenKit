
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBuildCyberwareSet_Record
	{
		[RED("cyberware")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Cyberware
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("programs")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Programs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
