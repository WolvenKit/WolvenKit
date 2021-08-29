using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SkSpeedAnim : animAnimNode_SkAnim
	{
		private animFloatLink _speed;

		[Ordinal(30)] 
		[RED("Speed")] 
		public animFloatLink Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}
	}
}
