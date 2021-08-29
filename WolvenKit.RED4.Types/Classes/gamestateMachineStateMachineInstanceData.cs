using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineStateMachineInstanceData : RedBaseClass
	{
		private CName _referenceName;
		private CUInt32 _priority;
		private CHandle<IScriptable> _initData;

		[Ordinal(0)] 
		[RED("referenceName")] 
		public CName ReferenceName
		{
			get => GetProperty(ref _referenceName);
			set => SetProperty(ref _referenceName, value);
		}

		[Ordinal(1)] 
		[RED("priority")] 
		public CUInt32 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(2)] 
		[RED("initData")] 
		public CHandle<IScriptable> InitData
		{
			get => GetProperty(ref _initData);
			set => SetProperty(ref _initData, value);
		}
	}
}
