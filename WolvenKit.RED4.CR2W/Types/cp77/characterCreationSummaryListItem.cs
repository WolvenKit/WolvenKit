using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationSummaryListItem : inkListItemController
	{
		private inkTextWidgetReference _headerLabel;
		private inkTextWidgetReference _descLabel;
		private CHandle<CharacterCreationSummaryListItemData> _data;

		[Ordinal(16)] 
		[RED("headerLabel")] 
		public inkTextWidgetReference HeaderLabel
		{
			get => GetProperty(ref _headerLabel);
			set => SetProperty(ref _headerLabel, value);
		}

		[Ordinal(17)] 
		[RED("descLabel")] 
		public inkTextWidgetReference DescLabel
		{
			get => GetProperty(ref _descLabel);
			set => SetProperty(ref _descLabel, value);
		}

		[Ordinal(18)] 
		[RED("data")] 
		public CHandle<CharacterCreationSummaryListItemData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public characterCreationSummaryListItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
