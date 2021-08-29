using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePersistentID : RedBaseClass
	{
		private CUInt64 _entityHash;
		private CName _componentName;

		[Ordinal(0)] 
		[RED("entityHash")] 
		public CUInt64 EntityHash
		{
			get => GetProperty(ref _entityHash);
			set => SetProperty(ref _entityHash, value);
		}

		[Ordinal(1)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}
	}
}
