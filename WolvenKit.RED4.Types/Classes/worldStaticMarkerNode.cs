using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldStaticMarkerNode : worldSocketNode
	{
		private CBool _isEnabled;
		private redTagList _tags;
		private CHandle<worldIMarker> _data;

		[Ordinal(4)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(5)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(6)] 
		[RED("data")] 
		public CHandle<worldIMarker> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public worldStaticMarkerNode()
		{
			_isEnabled = true;
		}
	}
}
