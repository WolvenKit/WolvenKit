using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticMarkerNode : worldSocketNode
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

		public worldStaticMarkerNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
