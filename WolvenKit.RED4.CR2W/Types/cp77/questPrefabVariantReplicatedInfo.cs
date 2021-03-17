using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPrefabVariantReplicatedInfo : CVariable
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

		public questPrefabVariantReplicatedInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
