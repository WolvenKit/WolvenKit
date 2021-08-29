using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DemolitionContainer : BaseSkillCheckContainer
	{
		private CHandle<DemolitionSkillCheck> _demolitionCheck;

		[Ordinal(3)] 
		[RED("demolitionCheck")] 
		public CHandle<DemolitionSkillCheck> DemolitionCheck
		{
			get => GetProperty(ref _demolitionCheck);
			set => SetProperty(ref _demolitionCheck, value);
		}
	}
}
