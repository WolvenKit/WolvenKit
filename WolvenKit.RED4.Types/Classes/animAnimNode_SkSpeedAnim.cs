using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SkSpeedAnim : animAnimNode_SkAnim
	{
		[Ordinal(30)] 
		[RED("Speed")] 
		public animFloatLink Speed
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_SkSpeedAnim()
		{
			Speed = new();
		}
	}
}
