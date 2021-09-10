using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LifePathBluelinePart : gameinteractionsvisBluelinePart
	{
		[Ordinal(2)] 
		[RED("record")] 
		public CHandle<gamedataLifePath_Record> Record
		{
			get => GetPropertyValue<CHandle<gamedataLifePath_Record>>();
			set => SetPropertyValue<CHandle<gamedataLifePath_Record>>(value);
		}
	}
}
