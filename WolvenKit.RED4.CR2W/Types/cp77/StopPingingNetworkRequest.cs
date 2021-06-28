using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StopPingingNetworkRequest : gameScriptableSystemRequest
	{
		private wCHandle<gameObject> _source;
		private CHandle<PingCachedData> _pingData;

		[Ordinal(0)] 
		[RED("source")] 
		public wCHandle<gameObject> Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(1)] 
		[RED("pingData")] 
		public CHandle<PingCachedData> PingData
		{
			get => GetProperty(ref _pingData);
			set => SetProperty(ref _pingData, value);
		}

		public StopPingingNetworkRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
