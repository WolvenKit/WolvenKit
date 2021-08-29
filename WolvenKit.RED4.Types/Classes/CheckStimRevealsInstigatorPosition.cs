using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckStimRevealsInstigatorPosition : AIbehaviorconditionScript
	{
		private CBool _checkStimType;
		private CEnum<gamedataStimType> _stimType;

		[Ordinal(0)] 
		[RED("checkStimType")] 
		public CBool CheckStimType
		{
			get => GetProperty(ref _checkStimType);
			set => SetProperty(ref _checkStimType, value);
		}

		[Ordinal(1)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get => GetProperty(ref _stimType);
			set => SetProperty(ref _stimType, value);
		}
	}
}
