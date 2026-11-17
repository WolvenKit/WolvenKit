using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStaticMarkerNode : worldSocketNode
	{
		[Ordinal(2)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CHandle<worldIMarker> Data
		{
			get => GetPropertyValue<CHandle<worldIMarker>>();
			set => SetPropertyValue<CHandle<worldIMarker>>(value);
		}

		public worldStaticMarkerNode()
		{
			IsEnabled = true;
			Tags = new redTagList();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
