using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SkAnimSlot : animAnimNode_SkAnim
	{
		[Ordinal(30)] 
		[RED("forFacialIdle")] 
		public CBool ForFacialIdle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
