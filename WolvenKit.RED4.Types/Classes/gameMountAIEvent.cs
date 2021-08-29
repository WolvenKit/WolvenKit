using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMountAIEvent : AIAIEvent
	{
		private CHandle<gameMountEventData> _data;

		[Ordinal(2)] 
		[RED("data")] 
		public CHandle<gameMountEventData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
