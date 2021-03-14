using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldMapGangItemController : inkWidgetLogicController
	{
		private inkTextWidgetReference _factionNameText;
		private inkImageWidgetReference _factionIconImage;

		[Ordinal(1)] 
		[RED("factionNameText")] 
		public inkTextWidgetReference FactionNameText
		{
			get
			{
				if (_factionNameText == null)
				{
					_factionNameText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "factionNameText", cr2w, this);
				}
				return _factionNameText;
			}
			set
			{
				if (_factionNameText == value)
				{
					return;
				}
				_factionNameText = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("factionIconImage")] 
		public inkImageWidgetReference FactionIconImage
		{
			get
			{
				if (_factionIconImage == null)
				{
					_factionIconImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "factionIconImage", cr2w, this);
				}
				return _factionIconImage;
			}
			set
			{
				if (_factionIconImage == value)
				{
					return;
				}
				_factionIconImage = value;
				PropertySet(this);
			}
		}

		public WorldMapGangItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
