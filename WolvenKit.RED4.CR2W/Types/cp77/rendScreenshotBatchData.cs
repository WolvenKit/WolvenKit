using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendScreenshotBatchData : CVariable
	{
		private AbsolutePathSerializable _batchPositionsPath;
		private CFloat _delayTime;
		private CUInt32 _numberOfCoordinatesToDump;

		[Ordinal(0)] 
		[RED("batchPositionsPath")] 
		public AbsolutePathSerializable BatchPositionsPath
		{
			get
			{
				if (_batchPositionsPath == null)
				{
					_batchPositionsPath = (AbsolutePathSerializable) CR2WTypeManager.Create("AbsolutePathSerializable", "batchPositionsPath", cr2w, this);
				}
				return _batchPositionsPath;
			}
			set
			{
				if (_batchPositionsPath == value)
				{
					return;
				}
				_batchPositionsPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("delayTime")] 
		public CFloat DelayTime
		{
			get
			{
				if (_delayTime == null)
				{
					_delayTime = (CFloat) CR2WTypeManager.Create("Float", "delayTime", cr2w, this);
				}
				return _delayTime;
			}
			set
			{
				if (_delayTime == value)
				{
					return;
				}
				_delayTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("numberOfCoordinatesToDump")] 
		public CUInt32 NumberOfCoordinatesToDump
		{
			get
			{
				if (_numberOfCoordinatesToDump == null)
				{
					_numberOfCoordinatesToDump = (CUInt32) CR2WTypeManager.Create("Uint32", "numberOfCoordinatesToDump", cr2w, this);
				}
				return _numberOfCoordinatesToDump;
			}
			set
			{
				if (_numberOfCoordinatesToDump == value)
				{
					return;
				}
				_numberOfCoordinatesToDump = value;
				PropertySet(this);
			}
		}

		public rendScreenshotBatchData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
