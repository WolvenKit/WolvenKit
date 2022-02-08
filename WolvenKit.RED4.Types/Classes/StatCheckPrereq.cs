using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatCheckPrereq : DevelopmentCheckPrereq
	{
		[Ordinal(1)] 
		[RED("statToCheck")] 
		public CEnum<gamedataStatType> StatToCheck
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}
	}
}
