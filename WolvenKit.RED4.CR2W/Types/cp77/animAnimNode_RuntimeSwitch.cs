using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_RuntimeSwitch : animAnimNode_Base
	{
		private CHandle<animIRuntimeCondition> _condition;
		private animPoseLink _true;
		private animPoseLink _false;

		[Ordinal(11)] 
		[RED("condition")] 
		public CHandle<animIRuntimeCondition> Condition
		{
			get => GetProperty(ref _condition);
			set => SetProperty(ref _condition, value);
		}

		[Ordinal(12)] 
		[RED("True")] 
		public animPoseLink True
		{
			get => GetProperty(ref _true);
			set => SetProperty(ref _true, value);
		}

		[Ordinal(13)] 
		[RED("False")] 
		public animPoseLink False
		{
			get => GetProperty(ref _false);
			set => SetProperty(ref _false, value);
		}

		public animAnimNode_RuntimeSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
