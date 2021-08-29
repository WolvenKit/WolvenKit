using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questRadioTrack_ConditionType : questISystemConditionType
	{
		private CName _radioTrack;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("radioTrack")] 
		public CName RadioTrack
		{
			get => GetProperty(ref _radioTrack);
			set => SetProperty(ref _radioTrack, value);
		}

		[Ordinal(1)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}
	}
}
