using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EngineeringContainer : BaseSkillCheckContainer
	{
		private CHandle<EngineeringSkillCheck> _engineeringCheck;

		[Ordinal(3)] 
		[RED("engineeringCheck")] 
		public CHandle<EngineeringSkillCheck> EngineeringCheck
		{
			get => GetProperty(ref _engineeringCheck);
			set => SetProperty(ref _engineeringCheck, value);
		}
	}
}
