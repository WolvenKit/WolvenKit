using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SToggleOperationData : RedBaseClass
	{
		private CInt32 _index;
		private CBool _enable;
		private CEnum<EOperationClassType> _classType;

		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(2)] 
		[RED("classType")] 
		public CEnum<EOperationClassType> ClassType
		{
			get => GetProperty(ref _classType);
			set => SetProperty(ref _classType, value);
		}
	}
}
