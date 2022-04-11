using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EvaluateVisionModeRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<gameVisionModeType> Mode
		{
			get => GetPropertyValue<CEnum<gameVisionModeType>>();
			set => SetPropertyValue<CEnum<gameVisionModeType>>(value);
		}
	}
}
