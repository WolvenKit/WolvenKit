using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SmartHouseConfiguration : RedBaseClass
	{
		private CBool _enableInteraction;
		private CName _factName;

		[Ordinal(0)] 
		[RED("enableInteraction")] 
		public CBool EnableInteraction
		{
			get => GetProperty(ref _enableInteraction);
			set => SetProperty(ref _enableInteraction, value);
		}

		[Ordinal(1)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetProperty(ref _factName);
			set => SetProperty(ref _factName, value);
		}
	}
}
