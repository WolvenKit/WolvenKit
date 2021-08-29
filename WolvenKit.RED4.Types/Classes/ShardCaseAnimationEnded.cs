using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ShardCaseAnimationEnded : redEvent
	{
		private CWeakHandle<gameObject> _activator;
		private gameItemID _item;
		private CBool _read;

		[Ordinal(0)] 
		[RED("activator")] 
		public CWeakHandle<gameObject> Activator
		{
			get => GetProperty(ref _activator);
			set => SetProperty(ref _activator, value);
		}

		[Ordinal(1)] 
		[RED("item")] 
		public gameItemID Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}

		[Ordinal(2)] 
		[RED("read")] 
		public CBool Read_
		{
			get => GetProperty(ref _read);
			set => SetProperty(ref _read, value);
		}
	}
}
