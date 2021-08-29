using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LifePathBluelinePart : gameinteractionsvisBluelinePart
	{
		private CHandle<gamedataLifePath_Record> _record;

		[Ordinal(2)] 
		[RED("record")] 
		public CHandle<gamedataLifePath_Record> Record
		{
			get => GetProperty(ref _record);
			set => SetProperty(ref _record, value);
		}
	}
}
