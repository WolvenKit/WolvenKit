using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSVisualTagProcessing : CVariable
	{
		private CEnum<gamedataEquipmentArea> _areaType;
		private CBool _showItem;

		[Ordinal(0)] 
		[RED("areaType")] 
		public CEnum<gamedataEquipmentArea> AreaType
		{
			get
			{
				if (_areaType == null)
				{
					_areaType = (CEnum<gamedataEquipmentArea>) CR2WTypeManager.Create("gamedataEquipmentArea", "areaType", cr2w, this);
				}
				return _areaType;
			}
			set
			{
				if (_areaType == value)
				{
					return;
				}
				_areaType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("showItem")] 
		public CBool ShowItem
		{
			get
			{
				if (_showItem == null)
				{
					_showItem = (CBool) CR2WTypeManager.Create("Bool", "showItem", cr2w, this);
				}
				return _showItem;
			}
			set
			{
				if (_showItem == value)
				{
					return;
				}
				_showItem = value;
				PropertySet(this);
			}
		}

		public gameSVisualTagProcessing(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
