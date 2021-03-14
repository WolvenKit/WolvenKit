using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GridUserData : IScriptable
	{
		private CEnum<gamedataEquipmentArea> _equipArea;
		private CEnum<inkEHorizontalAlign> _align;

		[Ordinal(0)] 
		[RED("equipArea")] 
		public CEnum<gamedataEquipmentArea> EquipArea
		{
			get
			{
				if (_equipArea == null)
				{
					_equipArea = (CEnum<gamedataEquipmentArea>) CR2WTypeManager.Create("gamedataEquipmentArea", "equipArea", cr2w, this);
				}
				return _equipArea;
			}
			set
			{
				if (_equipArea == value)
				{
					return;
				}
				_equipArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("align")] 
		public CEnum<inkEHorizontalAlign> Align
		{
			get
			{
				if (_align == null)
				{
					_align = (CEnum<inkEHorizontalAlign>) CR2WTypeManager.Create("inkEHorizontalAlign", "align", cr2w, this);
				}
				return _align;
			}
			set
			{
				if (_align == value)
				{
					return;
				}
				_align = value;
				PropertySet(this);
			}
		}

		public GridUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
