using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPlayHUDEntryAnimation_NodeType : questIUIManagerNodeType
	{
		private CName _hudEntryName;
		private CName _animationName;
		private CBool _dependsOnTimeDilation;

		[Ordinal(0)] 
		[RED("hudEntryName")] 
		public CName HudEntryName
		{
			get => GetProperty(ref _hudEntryName);
			set => SetProperty(ref _hudEntryName, value);
		}

		[Ordinal(1)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(2)] 
		[RED("dependsOnTimeDilation")] 
		public CBool DependsOnTimeDilation
		{
			get => GetProperty(ref _dependsOnTimeDilation);
			set => SetProperty(ref _dependsOnTimeDilation, value);
		}

		public questPlayHUDEntryAnimation_NodeType()
		{
			_dependsOnTimeDilation = true;
		}
	}
}
