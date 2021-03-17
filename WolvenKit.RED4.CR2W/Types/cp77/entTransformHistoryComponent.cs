using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTransformHistoryComponent : entIComponent
	{
		private CFloat _historyLength;
		private CUInt32 _samplesAmount;

		[Ordinal(3)] 
		[RED("historyLength")] 
		public CFloat HistoryLength
		{
			get => GetProperty(ref _historyLength);
			set => SetProperty(ref _historyLength, value);
		}

		[Ordinal(4)] 
		[RED("samplesAmount")] 
		public CUInt32 SamplesAmount
		{
			get => GetProperty(ref _samplesAmount);
			set => SetProperty(ref _samplesAmount, value);
		}

		public entTransformHistoryComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
