using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftItemRequest : gamePlayerScriptableSystemRequest
	{
		private wCHandle<gameObject> _target;
		private CHandle<gamedataItem_Record> _itemRecord;
		private CInt32 _amount;

		[Ordinal(1)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("itemRecord")] 
		public CHandle<gamedataItem_Record> ItemRecord
		{
			get => GetProperty(ref _itemRecord);
			set => SetProperty(ref _itemRecord, value);
		}

		[Ordinal(3)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}

		public CraftItemRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
