using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitData_Base : gameHitShapeUserData
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
	}
}
