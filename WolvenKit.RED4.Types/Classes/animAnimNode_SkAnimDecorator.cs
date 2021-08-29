using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SkAnimDecorator : animAnimNode_SkAnim
	{
		private animPoseLink _fallback;

		[Ordinal(30)] 
		[RED("Fallback")] 
		public animPoseLink Fallback
		{
			get => GetProperty(ref _fallback);
			set => SetProperty(ref _fallback, value);
		}
	}
}
