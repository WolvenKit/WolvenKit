using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RefreshInteractionTaskData : gameScriptTaskData
	{
		private CEnum<gamedeviceRequestType> _requestType;
		private wCHandle<gameObject> _executor;

		[Ordinal(0)] 
		[RED("requestType")] 
		public CEnum<gamedeviceRequestType> RequestType
		{
			get => GetProperty(ref _requestType);
			set => SetProperty(ref _requestType, value);
		}

		[Ordinal(1)] 
		[RED("executor")] 
		public wCHandle<gameObject> Executor
		{
			get => GetProperty(ref _executor);
			set => SetProperty(ref _executor, value);
		}

		public RefreshInteractionTaskData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
