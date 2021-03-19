using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_VectorWsToMs : animAnimNode_VectorValue
	{
		private CEnum<animEVectorWsToMsType> _type;
		private animVectorLink _vectorWs;

		[Ordinal(11)] 
		[RED("type")] 
		public CEnum<animEVectorWsToMsType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(12)] 
		[RED("vectorWs")] 
		public animVectorLink VectorWs
		{
			get => GetProperty(ref _vectorWs);
			set => SetProperty(ref _vectorWs, value);
		}

		public animAnimNode_VectorWsToMs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
