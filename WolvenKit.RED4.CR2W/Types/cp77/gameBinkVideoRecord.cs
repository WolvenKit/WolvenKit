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
			get
			{
				if (_resourceHash == null)
				{
					_resourceHash = (CUInt64) CR2WTypeManager.Create("Uint64", "resourceHash", cr2w, this);
				}
				return _resourceHash;
			}
			set
			{
				if (_resourceHash == value)
				{
					return;
				}
				_resourceHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("binkDuration")] 
		public CFloat BinkDuration
		{
			get
			{
				if (_binkDuration == null)
				{
					_binkDuration = (CFloat) CR2WTypeManager.Create("Float", "binkDuration", cr2w, this);
				}
				return _binkDuration;
			}
			set
			{
				if (_binkDuration == value)
				{
					return;
				}
				_binkDuration = value;
				PropertySet(this);
			}
		}

		public gameBinkVideoRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
