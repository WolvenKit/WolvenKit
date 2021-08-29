using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsMuppetUseLoadoutEvent : redEvent
	{
		private CHandle<gamedataCPOLoadoutBase_Record> _adout;

		[Ordinal(0)] 
		[RED("adout")] 
		public CHandle<gamedataCPOLoadoutBase_Record> Adout
		{
			get => GetProperty(ref _adout);
			set => SetProperty(ref _adout, value);
		}
	}
}
