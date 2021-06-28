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
			get => GetProperty(ref _areaType);
			set => SetProperty(ref _areaType, value);
		}

		[Ordinal(1)] 
		[RED("equipSlot")] 
		public TweakDBID EquipSlot
		{
			get => GetProperty(ref _equipSlot);
			set => SetProperty(ref _equipSlot, value);
		}

		[Ordinal(2)] 
		[RED("visualTag")] 
		public CName VisualTag
		{
			get => GetProperty(ref _visualTag);
			set => SetProperty(ref _visualTag, value);
		}

		public gameSSlotInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
