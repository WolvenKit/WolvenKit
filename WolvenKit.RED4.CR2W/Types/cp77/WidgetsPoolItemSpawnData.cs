using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WidgetsPoolItemSpawnData : IScriptable
	{
		private CInt32 _index;
		private CInt32 _requestVersion;

		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(1)] 
		[RED("requestVersion")] 
		public CInt32 RequestVersion
		{
			get => GetProperty(ref _requestVersion);
			set => SetProperty(ref _requestVersion, value);
		}

		public WidgetsPoolItemSpawnData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
