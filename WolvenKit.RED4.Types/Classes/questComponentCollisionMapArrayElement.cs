using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questComponentCollisionMapArrayElement : RedBaseClass
	{
		private CName _componentNameKey;
		private CBool _enableCollision;
		private CBool _enableQueries;

		[Ordinal(0)] 
		[RED("componentNameKey")] 
		public CName ComponentNameKey
		{
			get => GetProperty(ref _componentNameKey);
			set => SetProperty(ref _componentNameKey, value);
		}

		[Ordinal(1)] 
		[RED("enableCollision")] 
		public CBool EnableCollision
		{
			get => GetProperty(ref _enableCollision);
			set => SetProperty(ref _enableCollision, value);
		}

		[Ordinal(2)] 
		[RED("enableQueries")] 
		public CBool EnableQueries
		{
			get => GetProperty(ref _enableQueries);
			set => SetProperty(ref _enableQueries, value);
		}
	}
}
