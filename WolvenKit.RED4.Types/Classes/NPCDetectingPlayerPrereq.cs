using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCDetectingPlayerPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("threshold")] 
		public CFloat Threshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
