using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LoadListItem : AnimatedListItemController
	{
		private inkImageWidgetReference _imageReplacement;
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _labelDate;
		private inkTextWidgetReference _type;
		private inkTextWidgetReference _quest;
		private inkTextWidgetReference _level;
		private inkImageWidgetReference _lifepath;
		private inkTextWidgetReference _playTime;
		private inkTextWidgetReference _characterLevel;
		private inkTextWidgetReference _characterLevelLabel;
		private inkWidgetReference _emptySlotWrapper;
		private inkWidgetReference _wrapper;
		private CInt32 _index;
		private CBool _emptySlot;
		private CBool _validSlot;
		private CUInt64 _initialLoadingID;

		[Ordinal(30)] 
		[RED("imageReplacement")] 
		public inkImageWidgetReference ImageReplacement
		{
			get => GetProperty(ref _imageReplacement);
			set => SetProperty(ref _imageReplacement, value);
		}

		[Ordinal(31)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(32)] 
		[RED("labelDate")] 
		public inkTextWidgetReference LabelDate
		{
			get => GetProperty(ref _labelDate);
			set => SetProperty(ref _labelDate, value);
		}

		[Ordinal(33)] 
		[RED("type")] 
		public inkTextWidgetReference Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(34)] 
		[RED("quest")] 
		public inkTextWidgetReference Quest
		{
			get => GetProperty(ref _quest);
			set => SetProperty(ref _quest, value);
		}

		[Ordinal(35)] 
		[RED("level")] 
		public inkTextWidgetReference Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		[Ordinal(36)] 
		[RED("lifepath")] 
		public inkImageWidgetReference Lifepath
		{
			get => GetProperty(ref _lifepath);
			set => SetProperty(ref _lifepath, value);
		}

		[Ordinal(37)] 
		[RED("playTime")] 
		public inkTextWidgetReference PlayTime
		{
			get => GetProperty(ref _playTime);
			set => SetProperty(ref _playTime, value);
		}

		[Ordinal(38)] 
		[RED("characterLevel")] 
		public inkTextWidgetReference CharacterLevel
		{
			get => GetProperty(ref _characterLevel);
			set => SetProperty(ref _characterLevel, value);
		}

		[Ordinal(39)] 
		[RED("characterLevelLabel")] 
		public inkTextWidgetReference CharacterLevelLabel
		{
			get => GetProperty(ref _characterLevelLabel);
			set => SetProperty(ref _characterLevelLabel, value);
		}

		[Ordinal(40)] 
		[RED("emptySlotWrapper")] 
		public inkWidgetReference EmptySlotWrapper
		{
			get => GetProperty(ref _emptySlotWrapper);
			set => SetProperty(ref _emptySlotWrapper, value);
		}

		[Ordinal(41)] 
		[RED("wrapper")] 
		public inkWidgetReference Wrapper
		{
			get => GetProperty(ref _wrapper);
			set => SetProperty(ref _wrapper, value);
		}

		[Ordinal(42)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(43)] 
		[RED("emptySlot")] 
		public CBool EmptySlot
		{
			get => GetProperty(ref _emptySlot);
			set => SetProperty(ref _emptySlot, value);
		}

		[Ordinal(44)] 
		[RED("validSlot")] 
		public CBool ValidSlot
		{
			get => GetProperty(ref _validSlot);
			set => SetProperty(ref _validSlot, value);
		}

		[Ordinal(45)] 
		[RED("initialLoadingID")] 
		public CUInt64 InitialLoadingID
		{
			get => GetProperty(ref _initialLoadingID);
			set => SetProperty(ref _initialLoadingID, value);
		}

		public LoadListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
