using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CGradient : CResource
	{
		private CArray<rendGradientEntry> _gradientEntries;

		[Ordinal(1)] 
		[RED("gradientEntries")] 
		public CArray<rendGradientEntry> GradientEntries
		{
			get => GetProperty(ref _gradientEntries);
			set => SetProperty(ref _gradientEntries, value);
		}
	}
}
