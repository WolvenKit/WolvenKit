using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questInstancedCrowdControlNodeDefinition : questDisableableNodeDefinition
	{
		private CName _crowdVariantTag;
		private CBool _enable;

		[Ordinal(2)] 
		[RED("crowdVariantTag")] 
		public CName CrowdVariantTag
		{
			get => GetProperty(ref _crowdVariantTag);
			set => SetProperty(ref _crowdVariantTag, value);
		}

		[Ordinal(3)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		public questInstancedCrowdControlNodeDefinition()
		{
			_enable = true;
		}
	}
}
