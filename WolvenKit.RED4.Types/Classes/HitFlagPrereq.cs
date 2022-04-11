using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitFlagPrereq : GenericHitPrereq
	{
		[Ordinal(5)] 
		[RED("flag")] 
		public CEnum<hitFlag> Flag
		{
			get => GetPropertyValue<CEnum<hitFlag>>();
			set => SetPropertyValue<CEnum<hitFlag>>(value);
		}
	}
}
