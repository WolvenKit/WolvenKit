using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSermoPoseInfo : CVariable
	{
		private CUInt8 _lod;
		private CUInt8 _type;
		private CUInt16 _trackIndex;

		[Ordinal(0)] 
		[RED("lod")] 
		public CUInt8 Lod
		{
			get => GetProperty(ref _lod);
			set => SetProperty(ref _lod, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CUInt8 Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(2)] 
		[RED("trackIndex")] 
		public CUInt16 TrackIndex
		{
			get => GetProperty(ref _trackIndex);
			set => SetProperty(ref _trackIndex, value);
		}

		public animSermoPoseInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
