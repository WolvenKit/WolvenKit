using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Reprimand : MorphData
	{
		private ReprimandData _reprimandData;

		[Ordinal(1)] 
		[RED("reprimandData")] 
		public ReprimandData ReprimandData
		{
			get => GetProperty(ref _reprimandData);
			set => SetProperty(ref _reprimandData, value);
		}
	}
}
