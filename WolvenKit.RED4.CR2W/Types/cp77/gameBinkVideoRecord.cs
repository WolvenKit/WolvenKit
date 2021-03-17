using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBinkVideoRecord : ISerializable
	{
		private CUInt64 _resourceHash;
		private CFloat _binkDuration;

		[Ordinal(0)] 
		[RED("resourceHash")] 
		public CUInt64 ResourceHash
		{
			get => GetProperty(ref _resourceHash);
			set => SetProperty(ref _resourceHash, value);
		}

		[Ordinal(1)] 
		[RED("binkDuration")] 
		public CFloat BinkDuration
		{
			get => GetProperty(ref _binkDuration);
			set => SetProperty(ref _binkDuration, value);
		}

		public gameBinkVideoRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
