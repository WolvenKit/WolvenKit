using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animVisualTagCondition : animIStaticCondition
	{
		private CName _visualTag;

		[Ordinal(0)] 
		[RED("visualTag")] 
		public CName VisualTag
		{
			get => GetProperty(ref _visualTag);
			set => SetProperty(ref _visualTag, value);
		}
	}
}
