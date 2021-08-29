using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExperiencePointsEvent : redEvent
	{
		private CInt32 _amount;
		private CEnum<gamedataProficiencyType> _type;
		private CBool _isDebug;

		[Ordinal(0)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gamedataProficiencyType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(2)] 
		[RED("isDebug")] 
		public CBool IsDebug
		{
			get => GetProperty(ref _isDebug);
			set => SetProperty(ref _isDebug, value);
		}
	}
}
