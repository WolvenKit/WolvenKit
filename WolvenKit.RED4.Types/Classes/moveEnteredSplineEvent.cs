using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class moveEnteredSplineEvent : redEvent
	{
		private CBool _useDoors;

		[Ordinal(0)] 
		[RED("useDoors")] 
		public CBool UseDoors
		{
			get => GetProperty(ref _useDoors);
			set => SetProperty(ref _useDoors, value);
		}
	}
}
