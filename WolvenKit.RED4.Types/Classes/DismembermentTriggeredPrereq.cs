using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DismembermentTriggeredPrereq : gameIScriptablePrereq
	{
		private CUInt32 _currValue;

		[Ordinal(0)] 
		[RED("currValue")] 
		public CUInt32 CurrValue
		{
			get => GetProperty(ref _currValue);
			set => SetProperty(ref _currValue, value);
		}
	}
}
