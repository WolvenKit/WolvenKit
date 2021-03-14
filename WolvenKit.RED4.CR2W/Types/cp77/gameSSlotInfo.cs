using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSSlotInfo : CVariable
	{
		private CEnum<gamedataEquipmentArea> _areaType;
		private TweakDBID _equipSlot;
		private CName _visualTag;

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
		[RED("equipSlot")] 
		public TweakDBID EquipSlot
		{
			get
			{
				if (_equipSlot == null)
				{
					_equipSlot = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "equipSlot", cr2w, this);
				}
				return _equipSlot;
			}
			set
			{
				if (_equipSlot == value)
				{
					return;
				}
				_equipSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("visualTag")] 
		public CName VisualTag
		{
			get
			{
				if (_visualTag == null)
				{
					_visualTag = (CName) CR2WTypeManager.Create("CName", "visualTag", cr2w, this);
				}
				return _visualTag;
			}
			set
			{
				if (_visualTag == value)
				{
					return;
				}
				_visualTag = value;
				PropertySet(this);
			}
		}

		public gameSSlotInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
