using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseVisibleObjectTypeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataSenseObjectType> Type
		{
			get => GetPropertyValue<CEnum<gamedataSenseObjectType>>();
			set => SetPropertyValue<CEnum<gamedataSenseObjectType>>(value);
		}

		public senseVisibleObjectTypeEvent()
		{
			Type = Enums.gamedataSenseObjectType.Undefined;
		}
	}
}
