using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_OnePoseInput : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("inputLink")] 
		public animPoseLink InputLink
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}
	}
}
