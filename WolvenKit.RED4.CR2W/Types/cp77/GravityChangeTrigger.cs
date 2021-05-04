using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GravityChangeTrigger : gameObject
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

		public GravityChangeTrigger(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
