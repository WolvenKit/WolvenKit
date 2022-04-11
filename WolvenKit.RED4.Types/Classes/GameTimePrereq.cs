using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameTimePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
