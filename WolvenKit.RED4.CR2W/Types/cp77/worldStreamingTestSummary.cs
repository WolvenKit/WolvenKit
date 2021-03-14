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
			get
			{
				if (_gameDefinition == null)
				{
					_gameDefinition = (CString) CR2WTypeManager.Create("String", "gameDefinition", cr2w, this);
				}
				return _gameDefinition;
			}
			set
			{
				if (_gameDefinition == value)
				{
					return;
				}
				_gameDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("noCrowds")] 
		public CBool NoCrowds
		{
			get
			{
				if (_noCrowds == null)
				{
					_noCrowds = (CBool) CR2WTypeManager.Create("Bool", "noCrowds", cr2w, this);
				}
				return _noCrowds;
			}
			set
			{
				if (_noCrowds == value)
				{
					return;
				}
				_noCrowds = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("testDurationSeconds")] 
		public CFloat TestDurationSeconds
		{
			get
			{
				if (_testDurationSeconds == null)
				{
					_testDurationSeconds = (CFloat) CR2WTypeManager.Create("Float", "testDurationSeconds", cr2w, this);
				}
				return _testDurationSeconds;
			}
			set
			{
				if (_testDurationSeconds == value)
				{
					return;
				}
				_testDurationSeconds = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("initialBytesRead")] 
		public CUInt64 InitialBytesRead
		{
			get
			{
				if (_initialBytesRead == null)
				{
					_initialBytesRead = (CUInt64) CR2WTypeManager.Create("Uint64", "initialBytesRead", cr2w, this);
				}
				return _initialBytesRead;
			}
			set
			{
				if (_initialBytesRead == value)
				{
					return;
				}
				_initialBytesRead = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("bytesReadDuringTest")] 
		public CUInt64 BytesReadDuringTest
		{
			get
			{
				if (_bytesReadDuringTest == null)
				{
					_bytesReadDuringTest = (CUInt64) CR2WTypeManager.Create("Uint64", "bytesReadDuringTest", cr2w, this);
				}
				return _bytesReadDuringTest;
			}
			set
			{
				if (_bytesReadDuringTest == value)
				{
					return;
				}
				_bytesReadDuringTest = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("bytesReadDuringDriving")] 
		public CUInt64 BytesReadDuringDriving
		{
			get
			{
				if (_bytesReadDuringDriving == null)
				{
					_bytesReadDuringDriving = (CUInt64) CR2WTypeManager.Create("Uint64", "bytesReadDuringDriving", cr2w, this);
				}
				return _bytesReadDuringDriving;
			}
			set
			{
				if (_bytesReadDuringDriving == value)
				{
					return;
				}
				_bytesReadDuringDriving = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("bytesReadDuringCooldown")] 
		public CUInt64 BytesReadDuringCooldown
		{
			get
			{
				if (_bytesReadDuringCooldown == null)
				{
					_bytesReadDuringCooldown = (CUInt64) CR2WTypeManager.Create("Uint64", "bytesReadDuringCooldown", cr2w, this);
				}
				return _bytesReadDuringCooldown;
			}
			set
			{
				if (_bytesReadDuringCooldown == value)
				{
					return;
				}
				_bytesReadDuringCooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("totalSeeksBytes")] 
		public CUInt64 TotalSeeksBytes
		{
			get
			{
				if (_totalSeeksBytes == null)
				{
					_totalSeeksBytes = (CUInt64) CR2WTypeManager.Create("Uint64", "totalSeeksBytes", cr2w, this);
				}
				return _totalSeeksBytes;
			}
			set
			{
				if (_totalSeeksBytes == value)
				{
					return;
				}
				_totalSeeksBytes = value;
				PropertySet(this);
			}
		}

		public worldStreamingTestSummary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
