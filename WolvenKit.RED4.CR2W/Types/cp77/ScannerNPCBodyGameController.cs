using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerNPCBodyGameController : BaseChunkGameController
	{
		private inkTextWidgetReference _factionText;
		private inkWidgetReference _dataBaseWidgetHolder;
		private CUInt32 _factionCallbackID;
		private CUInt32 _rarityCallbackID;
		private CBool _isValidFaction;

		[Ordinal(5)] 
		[RED("factionText")] 
		public inkTextWidgetReference FactionText
		{
			get => GetProperty(ref _factionText);
			set => SetProperty(ref _factionText, value);
		}

		[Ordinal(6)] 
		[RED("dataBaseWidgetHolder")] 
		public inkWidgetReference DataBaseWidgetHolder
		{
			get => GetProperty(ref _dataBaseWidgetHolder);
			set => SetProperty(ref _dataBaseWidgetHolder, value);
		}

		[Ordinal(7)] 
		[RED("factionCallbackID")] 
		public CUInt32 FactionCallbackID
		{
			get => GetProperty(ref _factionCallbackID);
			set => SetProperty(ref _factionCallbackID, value);
		}

		[Ordinal(8)] 
		[RED("rarityCallbackID")] 
		public CUInt32 RarityCallbackID
		{
			get => GetProperty(ref _rarityCallbackID);
			set => SetProperty(ref _rarityCallbackID, value);
		}

		[Ordinal(9)] 
		[RED("isValidFaction")] 
		public CBool IsValidFaction
		{
			get => GetProperty(ref _isValidFaction);
			set => SetProperty(ref _isValidFaction, value);
		}

		public ScannerNPCBodyGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
