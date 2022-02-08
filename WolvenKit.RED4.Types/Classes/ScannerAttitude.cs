using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerAttitude : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get => GetPropertyValue<CEnum<EAIAttitude>>();
			set => SetPropertyValue<CEnum<EAIAttitude>>(value);
		}
	}
}
