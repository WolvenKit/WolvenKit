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
			get
			{
				if (_headerLabel == null)
				{
					_headerLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "headerLabel", cr2w, this);
				}
				return _headerLabel;
			}
			set
			{
				if (_headerLabel == value)
				{
					return;
				}
				_headerLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("descLabel")] 
		public inkTextWidgetReference DescLabel
		{
			get
			{
				if (_descLabel == null)
				{
					_descLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "descLabel", cr2w, this);
				}
				return _descLabel;
			}
			set
			{
				if (_descLabel == value)
				{
					return;
				}
				_descLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("data")] 
		public CHandle<CharacterCreationSummaryListItemData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<CharacterCreationSummaryListItemData>) CR2WTypeManager.Create("handle:CharacterCreationSummaryListItemData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public characterCreationSummaryListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
