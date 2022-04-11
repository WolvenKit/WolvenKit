using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_SceneSystemCarrying : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("carrying")] 
		public CBool Carrying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
