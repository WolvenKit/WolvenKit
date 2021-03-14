using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioSpatialSoundLimitMetadata : audioAudioMetadata
	{
		private CArray<CName> _eventNames;
		private CArray<CName> _writeOnlyEventNames;
		private CArray<CName> _readOnlyEventNames;
		private CFloat _radius;

		[Ordinal(1)] 
		[RED("eventNames")] 
		public CArray<CName> EventNames
		{
			get
			{
				if (_eventNames == null)
				{
					_eventNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "eventNames", cr2w, this);
				}
				return _eventNames;
			}
			set
			{
				if (_eventNames == value)
				{
					return;
				}
				_eventNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("writeOnlyEventNames")] 
		public CArray<CName> WriteOnlyEventNames
		{
			get
			{
				if (_writeOnlyEventNames == null)
				{
					_writeOnlyEventNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "writeOnlyEventNames", cr2w, this);
				}
				return _writeOnlyEventNames;
			}
			set
			{
				if (_writeOnlyEventNames == value)
				{
					return;
				}
				_writeOnlyEventNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("readOnlyEventNames")] 
		public CArray<CName> ReadOnlyEventNames
		{
			get
			{
				if (_readOnlyEventNames == null)
				{
					_readOnlyEventNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "readOnlyEventNames", cr2w, this);
				}
				return _readOnlyEventNames;
			}
			set
			{
				if (_readOnlyEventNames == value)
				{
					return;
				}
				_readOnlyEventNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CFloat) CR2WTypeManager.Create("Float", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		public audioSpatialSoundLimitMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
