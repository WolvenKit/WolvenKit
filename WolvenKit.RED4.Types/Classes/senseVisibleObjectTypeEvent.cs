using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseVisibleObjectTypeEvent : redEvent
	{
		private CEnum<gamedataSenseObjectType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataSenseObjectType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
