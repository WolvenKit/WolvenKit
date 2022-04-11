using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TraitDisplayData : BasePerkDisplayData
	{
		[Ordinal(10)] 
		[RED("type")] 
		public CEnum<gamedataTraitType> Type
		{
			get => GetPropertyValue<CEnum<gamedataTraitType>>();
			set => SetPropertyValue<CEnum<gamedataTraitType>>(value);
		}
	}
}
