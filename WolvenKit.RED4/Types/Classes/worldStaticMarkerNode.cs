using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStaticMarkerNode : worldSocketNode
	{
		[Ordinal(4)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(6)] 
		[RED("data")] 
		public CHandle<worldIMarker> Data
		{
			get => GetPropertyValue<CHandle<worldIMarker>>();
			set => SetPropertyValue<CHandle<worldIMarker>>(value);
		}

		public worldStaticMarkerNode()
		{
			IsEnabled = true;
			Tags = new redTagList { Tags = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
