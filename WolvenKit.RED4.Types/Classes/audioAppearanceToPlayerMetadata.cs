using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAppearanceToPlayerMetadata : RedBaseClass
	{
		private CArray<CName> _appearances;
		private CName _foleyPlayerMetadata;
		private CEnum<audioFoleyItemPriority> _priority;

		[Ordinal(0)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get => GetProperty(ref _appearances);
			set => SetProperty(ref _appearances, value);
		}

		[Ordinal(1)] 
		[RED("foleyPlayerMetadata")] 
		public CName FoleyPlayerMetadata
		{
			get => GetProperty(ref _foleyPlayerMetadata);
			set => SetProperty(ref _foleyPlayerMetadata, value);
		}

		[Ordinal(2)] 
		[RED("priority")] 
		public CEnum<audioFoleyItemPriority> Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}
	}
}
