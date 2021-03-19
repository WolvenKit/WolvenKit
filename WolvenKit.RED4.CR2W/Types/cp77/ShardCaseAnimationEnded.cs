using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardCaseAnimationEnded : redEvent
	{
		private wCHandle<gameObject> _activator;
		private gameItemID _item;
		private CBool _read;

		[Ordinal(0)] 
		[RED("activator")] 
		public wCHandle<gameObject> Activator
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

		public ShardCaseAnimationEnded(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
