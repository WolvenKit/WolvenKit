using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetCompressedInputStates : CVariable
	{
		private CBool _usesCompression;
		private CArray<CUInt8> _compressedInputStates;
		private CUInt32 _firstFrameId;
		private netTime _replicationTime;

		[Ordinal(0)] 
		[RED("usesCompression")] 
		public CBool UsesCompression
		{
			get
			{
				if (_usesCompression == null)
				{
					_usesCompression = (CBool) CR2WTypeManager.Create("Bool", "usesCompression", cr2w, this);
				}
				return _usesCompression;
			}
			set
			{
				if (_usesCompression == value)
				{
					return;
				}
				_usesCompression = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("compressedInputStates")] 
		public CArray<CUInt8> CompressedInputStates
		{
			get
			{
				if (_compressedInputStates == null)
				{
					_compressedInputStates = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "compressedInputStates", cr2w, this);
				}
				return _compressedInputStates;
			}
			set
			{
				if (_compressedInputStates == value)
				{
					return;
				}
				_compressedInputStates = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("firstFrameId")] 
		public CUInt32 FirstFrameId
		{
			get
			{
				if (_firstFrameId == null)
				{
					_firstFrameId = (CUInt32) CR2WTypeManager.Create("Uint32", "firstFrameId", cr2w, this);
				}
				return _firstFrameId;
			}
			set
			{
				if (_firstFrameId == value)
				{
					return;
				}
				_firstFrameId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("replicationTime")] 
		public netTime ReplicationTime
		{
			get
			{
				if (_replicationTime == null)
				{
					_replicationTime = (netTime) CR2WTypeManager.Create("netTime", "replicationTime", cr2w, this);
				}
				return _replicationTime;
			}
			set
			{
				if (_replicationTime == value)
				{
					return;
				}
				_replicationTime = value;
				PropertySet(this);
			}
		}

		public gameMuppetCompressedInputStates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
