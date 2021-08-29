using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChangeStanceStateAbstract : AIbehaviortaskScript
	{
		private CBool _changeStateOnDeactivate;

		[Ordinal(0)] 
		[RED("changeStateOnDeactivate")] 
		public CBool ChangeStateOnDeactivate
		{
			get => GetProperty(ref _changeStateOnDeactivate);
			set => SetProperty(ref _changeStateOnDeactivate, value);
		}
	}
}
