using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_AdditionalTransform : animAnimNode_OnePoseInput
	{
		private animAdditionalTransformContainer _additionalTransforms;

		[Ordinal(12)] 
		[RED("additionalTransforms")] 
		public animAdditionalTransformContainer AdditionalTransforms
		{
			get => GetProperty(ref _additionalTransforms);
			set => SetProperty(ref _additionalTransforms, value);
		}
	}
}
