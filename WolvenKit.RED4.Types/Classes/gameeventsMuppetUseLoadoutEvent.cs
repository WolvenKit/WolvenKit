using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsMuppetUseLoadoutEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("adout")] 
		public CHandle<gamedataCPOLoadoutBase_Record> Adout
		{
			get => GetPropertyValue<CHandle<gamedataCPOLoadoutBase_Record>>();
			set => SetPropertyValue<CHandle<gamedataCPOLoadoutBase_Record>>(value);
		}
	}
}
