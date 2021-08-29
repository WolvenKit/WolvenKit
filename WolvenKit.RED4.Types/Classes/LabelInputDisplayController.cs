using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LabelInputDisplayController : inkInputDisplayController
	{
		private inkTextWidgetReference _inputLabel;

		[Ordinal(11)] 
		[RED("inputLabel")] 
		public inkTextWidgetReference InputLabel
		{
			get => GetProperty(ref _inputLabel);
			set => SetProperty(ref _inputLabel, value);
		}
	}
}
