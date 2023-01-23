
namespace WolvenKit.RED4.Types
{
	public partial class gamedataProgram_Record
	{
		[RED("charactersChain")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> CharactersChain
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("program")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Program
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("programName")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper ProgramName
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
	}
}
