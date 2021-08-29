using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnregisterCommunityRunner : AIbehaviortaskScript
	{
		private CBool _onDeactivation;

		[Ordinal(0)] 
		[RED("onDeactivation")] 
		public CBool OnDeactivation
		{
			get => GetProperty(ref _onDeactivation);
			set => SetProperty(ref _onDeactivation, value);
		}
	}
}
