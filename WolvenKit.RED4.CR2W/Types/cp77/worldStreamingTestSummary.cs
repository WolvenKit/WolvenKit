using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStreamingTestSummary : ISerializable
	{
		private CString _gameDefinition;
		private CBool _noCrowds;
		private CFloat _testDurationSeconds;
		private CUInt64 _initialBytesRead;
		private CUInt64 _bytesReadDuringTest;
		private CUInt64 _bytesReadDuringDriving;
		private CUInt64 _bytesReadDuringCooldown;
		private CUInt64 _totalSeeksBytes;

		[Ordinal(0)] 
		[RED("gameDefinition")] 
		public CString GameDefinition
		{
			get => GetProperty(ref _gameDefinition);
			set => SetProperty(ref _gameDefinition, value);
		}

		[Ordinal(1)] 
		[RED("noCrowds")] 
		public CBool NoCrowds
		{
			get => GetProperty(ref _noCrowds);
			set => SetProperty(ref _noCrowds, value);
		}

		[Ordinal(2)] 
		[RED("testDurationSeconds")] 
		public CFloat TestDurationSeconds
		{
			get => GetProperty(ref _testDurationSeconds);
			set => SetProperty(ref _testDurationSeconds, value);
		}

		[Ordinal(3)] 
		[RED("initialBytesRead")] 
		public CUInt64 InitialBytesRead
		{
			get => GetProperty(ref _initialBytesRead);
			set => SetProperty(ref _initialBytesRead, value);
		}

		[Ordinal(4)] 
		[RED("bytesReadDuringTest")] 
		public CUInt64 BytesReadDuringTest
		{
			get => GetProperty(ref _bytesReadDuringTest);
			set => SetProperty(ref _bytesReadDuringTest, value);
		}

		[Ordinal(5)] 
		[RED("bytesReadDuringDriving")] 
		public CUInt64 BytesReadDuringDriving
		{
			get => GetProperty(ref _bytesReadDuringDriving);
			set => SetProperty(ref _bytesReadDuringDriving, value);
		}

		[Ordinal(6)] 
		[RED("bytesReadDuringCooldown")] 
		public CUInt64 BytesReadDuringCooldown
		{
			get => GetProperty(ref _bytesReadDuringCooldown);
			set => SetProperty(ref _bytesReadDuringCooldown, value);
		}

		[Ordinal(7)] 
		[RED("totalSeeksBytes")] 
		public CUInt64 TotalSeeksBytes
		{
			get => GetProperty(ref _totalSeeksBytes);
			set => SetProperty(ref _totalSeeksBytes, value);
		}

		public worldStreamingTestSummary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
