using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioDynamicEventsPerVisualTags : RedBaseClass
	{
		private CArray<CName> _visualTags;
		private CArray<audioDynamicEventsWithInterval> _grunts;

		[Ordinal(0)] 
		[RED("visualTags")] 
		public CArray<CName> VisualTags
		{
			get => GetProperty(ref _visualTags);
			set => SetProperty(ref _visualTags, value);
		}

		[Ordinal(1)] 
		[RED("grunts")] 
		public CArray<audioDynamicEventsWithInterval> Grunts
		{
			get => GetProperty(ref _grunts);
			set => SetProperty(ref _grunts, value);
		}
	}
}
