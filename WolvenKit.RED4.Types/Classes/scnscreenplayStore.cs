using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnscreenplayStore : RedBaseClass
	{
		private CArray<scnscreenplayDialogLine> _lines;
		private CArray<scnscreenplayChoiceOption> _options;

		[Ordinal(0)] 
		[RED("lines")] 
		public CArray<scnscreenplayDialogLine> Lines
		{
			get => GetProperty(ref _lines);
			set => SetProperty(ref _lines, value);
		}

		[Ordinal(1)] 
		[RED("options")] 
		public CArray<scnscreenplayChoiceOption> Options
		{
			get => GetProperty(ref _options);
			set => SetProperty(ref _options, value);
		}
	}
}
