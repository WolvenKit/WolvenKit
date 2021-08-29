using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetIgnoreAutoDoorCloseEvent : redEvent
	{
		private CBool _set;

		[Ordinal(0)] 
		[RED("set")] 
		public CBool Set
		{
			get => GetProperty(ref _set);
			set => SetProperty(ref _set, value);
		}
	}
}
