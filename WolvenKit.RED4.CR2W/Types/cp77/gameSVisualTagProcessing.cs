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
			get => GetProperty(ref _areaType);
			set => SetProperty(ref _areaType, value);
		}

		[Ordinal(1)] 
		[RED("showItem")] 
		public CBool ShowItem
		{
			get => GetProperty(ref _showItem);
			set => SetProperty(ref _showItem, value);
		}

		public gameSVisualTagProcessing(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
