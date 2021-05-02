using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimDataAddress : CVariable
	{
		private CUInt32 _unkIndex;
		private CUInt32 _fsetInBytes;
		private CUInt32 _zeInBytes;

		[Ordinal(0)] 
		[RED("unkIndex")] 
		public CUInt32 UnkIndex
		{
			get => GetProperty(ref _unkIndex);
			set => SetProperty(ref _unkIndex, value);
		}

		[Ordinal(1)] 
		[RED("fsetInBytes")] 
		public CUInt32 FsetInBytes
		{
			get => GetProperty(ref _fsetInBytes);
			set => SetProperty(ref _fsetInBytes, value);
		}

		[Ordinal(2)] 
		[RED("zeInBytes")] 
		public CUInt32 ZeInBytes
		{
			get => GetProperty(ref _zeInBytes);
			set => SetProperty(ref _zeInBytes, value);
		}

		public animAnimDataAddress(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
