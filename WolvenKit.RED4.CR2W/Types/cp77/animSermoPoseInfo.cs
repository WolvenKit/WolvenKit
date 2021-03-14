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
			get
			{
				if (_lod == null)
				{
					_lod = (CUInt8) CR2WTypeManager.Create("Uint8", "lod", cr2w, this);
				}
				return _lod;
			}
			set
			{
				if (_lod == value)
				{
					return;
				}
				_lod = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CUInt8 Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CUInt8) CR2WTypeManager.Create("Uint8", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("trackIndex")] 
		public CUInt16 TrackIndex
		{
			get
			{
				if (_trackIndex == null)
				{
					_trackIndex = (CUInt16) CR2WTypeManager.Create("Uint16", "trackIndex", cr2w, this);
				}
				return _trackIndex;
			}
			set
			{
				if (_trackIndex == value)
				{
					return;
				}
				_trackIndex = value;
				PropertySet(this);
			}
		}

		public animSermoPoseInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
