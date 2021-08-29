using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPrefabVariantReplicatedInfo : RedBaseClass
	{
		private CName _variantNameKey;
		private CBool _show;

		[Ordinal(0)] 
		[RED("variantNameKey")] 
		public CName VariantNameKey
		{
			get => GetProperty(ref _variantNameKey);
			set => SetProperty(ref _variantNameKey, value);
		}

		[Ordinal(1)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetProperty(ref _show);
			set => SetProperty(ref _show, value);
		}
	}
}
