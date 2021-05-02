using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitData_Base : gameHitShapeUserData
	{
		private CName _hitShapeTag;
		private CName _bodyPartStatPoolName;
		private CEnum<HitShape_Type> _hitShapeType;

		[Ordinal(0)] 
		[RED("hitShapeTag")] 
		public CName HitShapeTag
		{
			get => GetProperty(ref _hitShapeTag);
			set => SetProperty(ref _hitShapeTag, value);
		}

		[Ordinal(1)] 
		[RED("bodyPartStatPoolName")] 
		public CName BodyPartStatPoolName
		{
			get => GetProperty(ref _bodyPartStatPoolName);
			set => SetProperty(ref _bodyPartStatPoolName, value);
		}

		[Ordinal(2)] 
		[RED("hitShapeType")] 
		public CEnum<HitShape_Type> HitShapeType
		{
			get => GetProperty(ref _hitShapeType);
			set => SetProperty(ref _hitShapeType, value);
		}

		public HitData_Base(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
