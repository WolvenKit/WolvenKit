using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLastHitData : CVariable
	{
		private entEntityID _targetEntityId;
		private CUInt32 _hitType;
		private CArray<CName> _hitShapes;

		[Ordinal(0)] 
		[RED("targetEntityId")] 
		public entEntityID TargetEntityId
		{
			get => GetProperty(ref _targetEntityId);
			set => SetProperty(ref _targetEntityId, value);
		}

		[Ordinal(1)] 
		[RED("hitType")] 
		public CUInt32 HitType
		{
			get => GetProperty(ref _hitType);
			set => SetProperty(ref _hitType, value);
		}

		[Ordinal(2)] 
		[RED("hitShapes")] 
		public CArray<CName> HitShapes
		{
			get => GetProperty(ref _hitShapes);
			set => SetProperty(ref _hitShapes, value);
		}

		public gameLastHitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
