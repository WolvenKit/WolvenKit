using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SkDurationAnim : animAnimNode_SkAnim
	{
		private animFloatLink _duration;

		[Ordinal(30)] 
		[RED("Duration")] 
		public animFloatLink Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}
	}
}
