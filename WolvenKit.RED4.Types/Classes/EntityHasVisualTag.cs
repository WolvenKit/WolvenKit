using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EntityHasVisualTag : gameIScriptablePrereq
	{
		private CName _visualTag;
		private CBool _hasTag;

		[Ordinal(0)] 
		[RED("visualTag")] 
		public CName VisualTag
		{
			get => GetProperty(ref _visualTag);
			set => SetProperty(ref _visualTag, value);
		}

		[Ordinal(1)] 
		[RED("hasTag")] 
		public CBool HasTag
		{
			get => GetProperty(ref _hasTag);
			set => SetProperty(ref _hasTag, value);
		}
	}
}
