using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class moveCustomMoveEvent : gameActionEvent
	{
		[Ordinal(4)] 
		[RED("test")] 
		public CInt32 Test
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public moveCustomMoveEvent()
		{
			Test = 666;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
