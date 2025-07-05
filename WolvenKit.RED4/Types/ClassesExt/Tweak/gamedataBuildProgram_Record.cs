
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBuildProgram_Record
	{
		[RED("program")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Program
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
