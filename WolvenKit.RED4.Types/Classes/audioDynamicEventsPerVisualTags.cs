using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioDynamicEventsPerVisualTags : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("visualTags")] 
		public CArray<CName> VisualTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("grunts")] 
		public CArray<audioDynamicEventsWithInterval> Grunts
		{
			get => GetPropertyValue<CArray<audioDynamicEventsWithInterval>>();
			set => SetPropertyValue<CArray<audioDynamicEventsWithInterval>>(value);
		}

		public audioDynamicEventsPerVisualTags()
		{
			VisualTags = new();
			Grunts = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
