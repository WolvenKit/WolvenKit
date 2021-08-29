using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatCheckPrereq : DevelopmentCheckPrereq
	{
		private CEnum<gamedataStatType> _statToCheck;

		[Ordinal(1)] 
		[RED("statToCheck")] 
		public CEnum<gamedataStatType> StatToCheck
		{
			get => GetProperty(ref _statToCheck);
			set => SetProperty(ref _statToCheck, value);
		}
	}
}
