using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InspectableObjectComponent : gameScriptableComponent
	{
		private CName _factToAdd;
		private CString _itemID;
		private CFloat _offset;
		private CFloat _adsOffset;
		private CFloat _timeToScan;
		private CString _slot;

		[Ordinal(5)] 
		[RED("factToAdd")] 
		public CName FactToAdd
		{
			get => GetProperty(ref _factToAdd);
			set => SetProperty(ref _factToAdd, value);
		}

		[Ordinal(6)] 
		[RED("itemID")] 
		public CString ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(7)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(8)] 
		[RED("adsOffset")] 
		public CFloat AdsOffset
		{
			get => GetProperty(ref _adsOffset);
			set => SetProperty(ref _adsOffset, value);
		}

		[Ordinal(9)] 
		[RED("timeToScan")] 
		public CFloat TimeToScan
		{
			get => GetProperty(ref _timeToScan);
			set => SetProperty(ref _timeToScan, value);
		}

		[Ordinal(10)] 
		[RED("slot")] 
		public CString Slot
		{
			get => GetProperty(ref _slot);
			set => SetProperty(ref _slot, value);
		}

		public InspectableObjectComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
