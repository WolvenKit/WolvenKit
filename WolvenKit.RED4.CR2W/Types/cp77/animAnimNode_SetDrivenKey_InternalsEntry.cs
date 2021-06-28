using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetDrivenKey_InternalsEntry : CVariable
	{
		private curveData<CFloat> _curve;
		private CName _inChannelName;
		private CName _outChannelName;
		private CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType> _inChanelType;
		private CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType> _outChanelType;

		[Ordinal(0)] 
		[RED("curve")] 
		public curveData<CFloat> Curve
		{
			get => GetProperty(ref _curve);
			set => SetProperty(ref _curve, value);
		}

		[Ordinal(1)] 
		[RED("inChannelName")] 
		public CName InChannelName
		{
			get => GetProperty(ref _inChannelName);
			set => SetProperty(ref _inChannelName, value);
		}

		[Ordinal(2)] 
		[RED("outChannelName")] 
		public CName OutChannelName
		{
			get => GetProperty(ref _outChannelName);
			set => SetProperty(ref _outChannelName, value);
		}

		[Ordinal(3)] 
		[RED("inChanelType")] 
		public CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType> InChanelType
		{
			get => GetProperty(ref _inChanelType);
			set => SetProperty(ref _inChanelType, value);
		}

		[Ordinal(4)] 
		[RED("outChanelType")] 
		public CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType> OutChanelType
		{
			get => GetProperty(ref _outChanelType);
			set => SetProperty(ref _outChanelType, value);
		}

		public animAnimNode_SetDrivenKey_InternalsEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
