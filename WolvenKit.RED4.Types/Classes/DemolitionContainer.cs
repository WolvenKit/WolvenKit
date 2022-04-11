using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DemolitionContainer : BaseSkillCheckContainer
	{
		[Ordinal(3)] 
		[RED("demolitionCheck")] 
		public CHandle<DemolitionSkillCheck> DemolitionCheck
		{
			get => GetPropertyValue<CHandle<DemolitionSkillCheck>>();
			set => SetPropertyValue<CHandle<DemolitionSkillCheck>>(value);
		}
	}
}
