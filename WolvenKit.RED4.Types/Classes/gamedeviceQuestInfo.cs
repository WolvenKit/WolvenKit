using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedeviceQuestInfo : RedBaseClass
	{
		private CBool _isHighlighted;
		private CName _factName;

		[Ordinal(0)] 
		[RED("isHighlighted")] 
		public CBool IsHighlighted
		{
			get => GetProperty(ref _isHighlighted);
			set => SetProperty(ref _isHighlighted, value);
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
