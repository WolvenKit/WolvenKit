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
			get
			{
				if (_unkIndex == null)
				{
					_unkIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "unkIndex", cr2w, this);
				}
				return _unkIndex;
			}
			set
			{
				if (_unkIndex == value)
				{
					return;
				}
				_unkIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("fsetInBytes")] 
		public CUInt32 FsetInBytes
		{
			get
			{
				if (_fsetInBytes == null)
				{
					_fsetInBytes = (CUInt32) CR2WTypeManager.Create("Uint32", "fsetInBytes", cr2w, this);
				}
				return _fsetInBytes;
			}
			set
			{
				if (_fsetInBytes == value)
				{
					return;
				}
				_fsetInBytes = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("zeInBytes")] 
		public CUInt32 ZeInBytes
		{
			get
			{
				if (_zeInBytes == null)
				{
					_zeInBytes = (CUInt32) CR2WTypeManager.Create("Uint32", "zeInBytes", cr2w, this);
				}
				return _zeInBytes;
			}
			set
			{
				if (_zeInBytes == value)
				{
					return;
				}
				_zeInBytes = value;
				PropertySet(this);
			}
		}

		public animAnimDataAddress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
