using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveItemPart : gameScriptableSystemRequest
	{
		private wCHandle<gameObject> _obj;
		private gameItemID _baseItem;
		private TweakDBID _slotToEmpty;

		[Ordinal(0)] 
		[RED("obj")] 
		public wCHandle<gameObject> Obj
		{
			get => GetProperty(ref _obj);
			set => SetProperty(ref _obj, value);
		}

		[Ordinal(1)] 
		[RED("baseItem")] 
		public gameItemID BaseItem
		{
			get => GetProperty(ref _baseItem);
			set => SetProperty(ref _baseItem, value);
		}

		[Ordinal(2)] 
		[RED("slotToEmpty")] 
		public TweakDBID SlotToEmpty
		{
			get => GetProperty(ref _slotToEmpty);
			set => SetProperty(ref _slotToEmpty, value);
		}

		public RemoveItemPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
