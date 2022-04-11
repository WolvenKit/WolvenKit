using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameVisionModePrereq : gameIPrereq
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameVisionModeType> Type
		{
			get => GetPropertyValue<CEnum<gameVisionModeType>>();
			set => SetPropertyValue<CEnum<gameVisionModeType>>(value);
		}
	}
}
