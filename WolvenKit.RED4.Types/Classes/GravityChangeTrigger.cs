using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GravityChangeTrigger : gameObject
	{
		private CEnum<EGravityType> _gravityType;
		private CName _regularStateMachineName;
		private CName _lowGravityStateMachineName;

		[Ordinal(40)] 
		[RED("gravityType")] 
		public CEnum<EGravityType> GravityType
		{
			get => GetProperty(ref _gravityType);
			set => SetProperty(ref _gravityType, value);
		}

		[Ordinal(41)] 
		[RED("regularStateMachineName")] 
		public CName RegularStateMachineName
		{
			get => GetProperty(ref _regularStateMachineName);
			set => SetProperty(ref _regularStateMachineName, value);
		}

		[Ordinal(42)] 
		[RED("lowGravityStateMachineName")] 
		public CName LowGravityStateMachineName
		{
			get => GetProperty(ref _lowGravityStateMachineName);
			set => SetProperty(ref _lowGravityStateMachineName, value);
		}
	}
}
