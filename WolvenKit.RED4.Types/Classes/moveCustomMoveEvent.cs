using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class moveCustomMoveEvent : gameActionEvent
	{
		private CInt32 _test;

		[Ordinal(4)] 
		[RED("test")] 
		public CInt32 Test
		{
			get => GetProperty(ref _test);
			set => SetProperty(ref _test, value);
		}

		public moveCustomMoveEvent()
		{
			_test = 666;
		}
	}
}
