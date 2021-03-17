using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SwapItemPart : gameScriptableSystemRequest
	{
		private wCHandle<gameObject> _obj;
		private gameItemID _baseItem;
		private gameItemID _partToInstall;
		private TweakDBID _slotID;

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
		[RED("partToInstall")] 
		public gameItemID PartToInstall
		{
			get => GetProperty(ref _partToInstall);
			set => SetProperty(ref _partToInstall, value);
		}

		[Ordinal(3)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		public SwapItemPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
