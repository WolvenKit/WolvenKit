using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameItemID : CVariable
	{
		private TweakDBID _id;
		private CUInt32 _rngSeed;
		private CUInt16 _uniqueCounter;

		[Ordinal(0)] 
		[RED("id")] 
		public TweakDBID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("rngSeed")] 
		public CUInt32 RngSeed
		{
			get => GetProperty(ref _rngSeed);
			set => SetProperty(ref _rngSeed, value);
		}

		[Ordinal(2)] 
		[RED("uniqueCounter")] 
		public CUInt16 UniqueCounter
		{
			get => GetProperty(ref _uniqueCounter);
			set => SetProperty(ref _uniqueCounter, value);
		}

		public gameItemID(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
