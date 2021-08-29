using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TraitDisplayData : BasePerkDisplayData
	{
		private CEnum<gamedataTraitType> _type;

		[Ordinal(10)] 
		[RED("type")] 
		public CEnum<gamedataTraitType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
