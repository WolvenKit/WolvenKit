using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsCustomFilterData : ISerializable
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
	}
}
