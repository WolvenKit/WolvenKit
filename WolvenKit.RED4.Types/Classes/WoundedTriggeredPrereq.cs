using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WoundedTriggeredPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("currValue")] 
		public CUInt32 CurrValue
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
