using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDestruction_ConditionType : questIObjectConditionType
	{
		private gameEntityReference _objectRef;
		private CFloat _threshold;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("threshold")] 
		public CFloat Threshold
		{
			get => GetProperty(ref _threshold);
			set => SetProperty(ref _threshold, value);
		}

		public questDestruction_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
