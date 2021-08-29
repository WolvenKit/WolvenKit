using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckReactionStimType : AIbehaviorconditionScript
	{
		private CEnum<gamedataStimType> _stimToCompare;

		[Ordinal(0)] 
		[RED("stimToCompare")] 
		public CEnum<gamedataStimType> StimToCompare
		{
			get => GetProperty(ref _stimToCompare);
			set => SetProperty(ref _stimToCompare, value);
		}
	}
}
