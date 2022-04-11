using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectParameter_StringEvaluator_Value : gameIEffectParameter_StringEvaluator
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CString Value
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
