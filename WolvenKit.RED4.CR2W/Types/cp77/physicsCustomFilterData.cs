using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsCustomFilterData : ISerializable
	{
		private CArray<CName> _collisionType;
		private CArray<CName> _collideWith;
		private CArray<CName> _queryDetect;

		[Ordinal(0)] 
		[RED("collisionType")] 
		public CArray<CName> CollisionType
		{
			get => GetProperty(ref _collisionType);
			set => SetProperty(ref _collisionType, value);
		}

		[Ordinal(1)] 
		[RED("collideWith")] 
		public CArray<CName> CollideWith
		{
			get => GetProperty(ref _collideWith);
			set => SetProperty(ref _collideWith, value);
		}

		[Ordinal(2)] 
		[RED("queryDetect")] 
		public CArray<CName> QueryDetect
		{
			get => GetProperty(ref _queryDetect);
			set => SetProperty(ref _queryDetect, value);
		}

		public physicsCustomFilterData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
