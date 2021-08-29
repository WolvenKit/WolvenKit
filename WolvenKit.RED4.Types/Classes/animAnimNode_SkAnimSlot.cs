using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SkAnimSlot : animAnimNode_SkAnim
	{
		private CBool _forFacialIdle;

		[Ordinal(30)] 
		[RED("forFacialIdle")] 
		public CBool ForFacialIdle
		{
			get => GetProperty(ref _forFacialIdle);
			set => SetProperty(ref _forFacialIdle, value);
		}
	}
}
