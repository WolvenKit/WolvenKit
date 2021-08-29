using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckDistractedReturnConditionParams : RedBaseClass
	{
		private CBool _distracted;
		private CEnum<scnDistractedConditionTarget> _target;

		[Ordinal(0)] 
		[RED("distracted")] 
		public CBool Distracted
		{
			get => GetProperty(ref _distracted);
			set => SetProperty(ref _distracted, value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public CEnum<scnDistractedConditionTarget> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}
	}
}
