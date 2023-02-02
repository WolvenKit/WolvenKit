using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnscreenplayStore : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lines")] 
		public CArray<scnscreenplayDialogLine> Lines
		{
			get => GetPropertyValue<CArray<scnscreenplayDialogLine>>();
			set => SetPropertyValue<CArray<scnscreenplayDialogLine>>(value);
		}

		[Ordinal(1)] 
		[RED("options")] 
		public CArray<scnscreenplayChoiceOption> Options
		{
			get => GetPropertyValue<CArray<scnscreenplayChoiceOption>>();
			set => SetPropertyValue<CArray<scnscreenplayChoiceOption>>(value);
		}

		public scnscreenplayStore()
		{
			Lines = new();
			Options = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
