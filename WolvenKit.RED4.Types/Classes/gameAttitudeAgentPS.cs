using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAttitudeAgentPS : gameComponentPS
	{
		private CName _currentAttitudeGroup;

		[Ordinal(0)] 
		[RED("currentAttitudeGroup")] 
		public CName CurrentAttitudeGroup
		{
			get => GetProperty(ref _currentAttitudeGroup);
			set => SetProperty(ref _currentAttitudeGroup, value);
		}
	}
}
