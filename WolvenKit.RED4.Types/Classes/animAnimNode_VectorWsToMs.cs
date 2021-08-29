using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_VectorWsToMs : animAnimNode_VectorValue
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
	}
}
