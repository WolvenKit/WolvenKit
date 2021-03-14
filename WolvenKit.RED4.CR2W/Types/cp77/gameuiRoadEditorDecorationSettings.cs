using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoadEditorDecorationSettings : CVariable
	{
		private CName _libraryName;
		private CFloat _offset;
		private CUInt32 _repeatPatternDensity;
		private CUInt32 _repeatPatternStartOffset;

		[Ordinal(0)] 
		[RED("libraryName")] 
		public CName LibraryName
		{
			get
			{
				if (_libraryName == null)
				{
					_libraryName = (CName) CR2WTypeManager.Create("CName", "libraryName", cr2w, this);
				}
				return _libraryName;
			}
			set
			{
				if (_libraryName == value)
				{
					return;
				}
				_libraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (CFloat) CR2WTypeManager.Create("Float", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("repeatPatternDensity")] 
		public CUInt32 RepeatPatternDensity
		{
			get
			{
				if (_repeatPatternDensity == null)
				{
					_repeatPatternDensity = (CUInt32) CR2WTypeManager.Create("Uint32", "repeatPatternDensity", cr2w, this);
				}
				return _repeatPatternDensity;
			}
			set
			{
				if (_repeatPatternDensity == value)
				{
					return;
				}
				_repeatPatternDensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("repeatPatternStartOffset")] 
		public CUInt32 RepeatPatternStartOffset
		{
			get
			{
				if (_repeatPatternStartOffset == null)
				{
					_repeatPatternStartOffset = (CUInt32) CR2WTypeManager.Create("Uint32", "repeatPatternStartOffset", cr2w, this);
				}
				return _repeatPatternStartOffset;
			}
			set
			{
				if (_repeatPatternStartOffset == value)
				{
					return;
				}
				_repeatPatternStartOffset = value;
				PropertySet(this);
			}
		}

		public gameuiRoadEditorDecorationSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
