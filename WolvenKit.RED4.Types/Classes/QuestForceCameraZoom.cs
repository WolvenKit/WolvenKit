using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestForceCameraZoom : ActionBool
	{
		private CBool _useWorkspot;

		[Ordinal(25)] 
		[RED("useWorkspot")] 
		public CBool UseWorkspot
		{
			get => GetProperty(ref _useWorkspot);
			set => SetProperty(ref _useWorkspot, value);
		}
	}
}
