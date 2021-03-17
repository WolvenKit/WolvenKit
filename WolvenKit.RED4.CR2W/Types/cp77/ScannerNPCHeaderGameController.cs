using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerNPCHeaderGameController : BaseChunkGameController
	{
		private inkTextWidgetReference _nameText;
		private inkWidgetReference _skullIndicator;
		private inkImageWidgetReference _archetypeIcon;
		private CUInt32 _levelCallbackID;
		private CUInt32 _nameCallbackID;
		private CUInt32 _attitudeCallbackID;
		private CUInt32 _archtypeCallbackID;
		private CBool _isValidName;
		private CBool _isValidRarity;
		private CBool _isValidArchetype;

		[Ordinal(5)] 
		[RED("nameText")] 
		public inkTextWidgetReference NameText
		{
			get => GetProperty(ref _nameText);
			set => SetProperty(ref _nameText, value);
		}

		[Ordinal(6)] 
		[RED("skullIndicator")] 
		public inkWidgetReference SkullIndicator
		{
			get => GetProperty(ref _skullIndicator);
			set => SetProperty(ref _skullIndicator, value);
		}

		[Ordinal(7)] 
		[RED("archetypeIcon")] 
		public inkImageWidgetReference ArchetypeIcon
		{
			get => GetProperty(ref _archetypeIcon);
			set => SetProperty(ref _archetypeIcon, value);
		}

		[Ordinal(8)] 
		[RED("levelCallbackID")] 
		public CUInt32 LevelCallbackID
		{
			get => GetProperty(ref _levelCallbackID);
			set => SetProperty(ref _levelCallbackID, value);
		}

		[Ordinal(9)] 
		[RED("nameCallbackID")] 
		public CUInt32 NameCallbackID
		{
			get => GetProperty(ref _nameCallbackID);
			set => SetProperty(ref _nameCallbackID, value);
		}

		[Ordinal(10)] 
		[RED("attitudeCallbackID")] 
		public CUInt32 AttitudeCallbackID
		{
			get => GetProperty(ref _attitudeCallbackID);
			set => SetProperty(ref _attitudeCallbackID, value);
		}

		[Ordinal(11)] 
		[RED("archtypeCallbackID")] 
		public CUInt32 ArchtypeCallbackID
		{
			get => GetProperty(ref _archtypeCallbackID);
			set => SetProperty(ref _archtypeCallbackID, value);
		}

		[Ordinal(12)] 
		[RED("isValidName")] 
		public CBool IsValidName
		{
			get => GetProperty(ref _isValidName);
			set => SetProperty(ref _isValidName, value);
		}

		[Ordinal(13)] 
		[RED("isValidRarity")] 
		public CBool IsValidRarity
		{
			get => GetProperty(ref _isValidRarity);
			set => SetProperty(ref _isValidRarity, value);
		}

		[Ordinal(14)] 
		[RED("isValidArchetype")] 
		public CBool IsValidArchetype
		{
			get => GetProperty(ref _isValidArchetype);
			set => SetProperty(ref _isValidArchetype, value);
		}

		public ScannerNPCHeaderGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
