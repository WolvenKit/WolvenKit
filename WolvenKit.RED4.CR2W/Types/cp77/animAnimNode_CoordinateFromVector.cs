using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_CoordinateFromVector : animAnimNode_FloatValue
	{
		private CEnum<animVectorCoordinateType> _vectorCoodrinateType;
		private animVectorLink _input;

		[Ordinal(11)] 
		[RED("vectorCoodrinateType")] 
		public CEnum<animVectorCoordinateType> VectorCoodrinateType
		{
			get => GetProperty(ref _vectorCoodrinateType);
			set => SetProperty(ref _vectorCoodrinateType, value);
		}

		[Ordinal(12)] 
		[RED("input")] 
		public animVectorLink Input
		{
			get => GetProperty(ref _input);
			set => SetProperty(ref _input, value);
		}

		public animAnimNode_CoordinateFromVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
