using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DamageDigitUserData : IScriptable
	{
		private CInt32 _controllerIndex;

		[Ordinal(0)] 
		[RED("controllerIndex")] 
		public CInt32 ControllerIndex
		{
			get => GetProperty(ref _controllerIndex);
			set => SetProperty(ref _controllerIndex, value);
		}
	}
}
