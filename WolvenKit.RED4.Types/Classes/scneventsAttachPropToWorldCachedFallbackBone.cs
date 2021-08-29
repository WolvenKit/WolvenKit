using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scneventsAttachPropToWorldCachedFallbackBone : RedBaseClass
	{
		private CName _boneName;
		private Transform _modelSpaceTransform;

		[Ordinal(0)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get => GetProperty(ref _boneName);
			set => SetProperty(ref _boneName, value);
		}

		[Ordinal(1)] 
		[RED("modelSpaceTransform")] 
		public Transform ModelSpaceTransform
		{
			get => GetProperty(ref _modelSpaceTransform);
			set => SetProperty(ref _modelSpaceTransform, value);
		}
	}
}
