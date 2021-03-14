using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopTerrainEditToolInfo : CVariable
	{
		private CInt32 _defaultHeightmapMode;
		private CInt32 _defaultEmptyHeightmapWidth;
		private CInt32 _defaultEmptyHeightmapHeight;
		private CFloat _defaultEmptyHeightmapMaskFalloff;
		private CFloat _defaultEmptyHeightmapMaskRoundness;
		private CUInt32 _defaultEmptyHeightmapZeroMaskMargin;
		private CString _defaultHeightmap1;
		private CString _defaultHeightmap2;
		private CString _defaultColormap1;
		private CString _defaultColormap2;
		private CArray<interopTerrainEditToolCreationSlotInfo> _creationSlots;

		[Ordinal(0)] 
		[RED("defaultHeightmapMode")] 
		public CInt32 DefaultHeightmapMode
		{
			get
			{
				if (_defaultHeightmapMode == null)
				{
					_defaultHeightmapMode = (CInt32) CR2WTypeManager.Create("Int32", "defaultHeightmapMode", cr2w, this);
				}
				return _defaultHeightmapMode;
			}
			set
			{
				if (_defaultHeightmapMode == value)
				{
					return;
				}
				_defaultHeightmapMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("defaultEmptyHeightmapWidth")] 
		public CInt32 DefaultEmptyHeightmapWidth
		{
			get
			{
				if (_defaultEmptyHeightmapWidth == null)
				{
					_defaultEmptyHeightmapWidth = (CInt32) CR2WTypeManager.Create("Int32", "defaultEmptyHeightmapWidth", cr2w, this);
				}
				return _defaultEmptyHeightmapWidth;
			}
			set
			{
				if (_defaultEmptyHeightmapWidth == value)
				{
					return;
				}
				_defaultEmptyHeightmapWidth = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("defaultEmptyHeightmapHeight")] 
		public CInt32 DefaultEmptyHeightmapHeight
		{
			get
			{
				if (_defaultEmptyHeightmapHeight == null)
				{
					_defaultEmptyHeightmapHeight = (CInt32) CR2WTypeManager.Create("Int32", "defaultEmptyHeightmapHeight", cr2w, this);
				}
				return _defaultEmptyHeightmapHeight;
			}
			set
			{
				if (_defaultEmptyHeightmapHeight == value)
				{
					return;
				}
				_defaultEmptyHeightmapHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("defaultEmptyHeightmapMaskFalloff")] 
		public CFloat DefaultEmptyHeightmapMaskFalloff
		{
			get
			{
				if (_defaultEmptyHeightmapMaskFalloff == null)
				{
					_defaultEmptyHeightmapMaskFalloff = (CFloat) CR2WTypeManager.Create("Float", "defaultEmptyHeightmapMaskFalloff", cr2w, this);
				}
				return _defaultEmptyHeightmapMaskFalloff;
			}
			set
			{
				if (_defaultEmptyHeightmapMaskFalloff == value)
				{
					return;
				}
				_defaultEmptyHeightmapMaskFalloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("defaultEmptyHeightmapMaskRoundness")] 
		public CFloat DefaultEmptyHeightmapMaskRoundness
		{
			get
			{
				if (_defaultEmptyHeightmapMaskRoundness == null)
				{
					_defaultEmptyHeightmapMaskRoundness = (CFloat) CR2WTypeManager.Create("Float", "defaultEmptyHeightmapMaskRoundness", cr2w, this);
				}
				return _defaultEmptyHeightmapMaskRoundness;
			}
			set
			{
				if (_defaultEmptyHeightmapMaskRoundness == value)
				{
					return;
				}
				_defaultEmptyHeightmapMaskRoundness = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("defaultEmptyHeightmapZeroMaskMargin")] 
		public CUInt32 DefaultEmptyHeightmapZeroMaskMargin
		{
			get
			{
				if (_defaultEmptyHeightmapZeroMaskMargin == null)
				{
					_defaultEmptyHeightmapZeroMaskMargin = (CUInt32) CR2WTypeManager.Create("Uint32", "defaultEmptyHeightmapZeroMaskMargin", cr2w, this);
				}
				return _defaultEmptyHeightmapZeroMaskMargin;
			}
			set
			{
				if (_defaultEmptyHeightmapZeroMaskMargin == value)
				{
					return;
				}
				_defaultEmptyHeightmapZeroMaskMargin = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("defaultHeightmap1")] 
		public CString DefaultHeightmap1
		{
			get
			{
				if (_defaultHeightmap1 == null)
				{
					_defaultHeightmap1 = (CString) CR2WTypeManager.Create("String", "defaultHeightmap1", cr2w, this);
				}
				return _defaultHeightmap1;
			}
			set
			{
				if (_defaultHeightmap1 == value)
				{
					return;
				}
				_defaultHeightmap1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("defaultHeightmap2")] 
		public CString DefaultHeightmap2
		{
			get
			{
				if (_defaultHeightmap2 == null)
				{
					_defaultHeightmap2 = (CString) CR2WTypeManager.Create("String", "defaultHeightmap2", cr2w, this);
				}
				return _defaultHeightmap2;
			}
			set
			{
				if (_defaultHeightmap2 == value)
				{
					return;
				}
				_defaultHeightmap2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("defaultColormap1")] 
		public CString DefaultColormap1
		{
			get
			{
				if (_defaultColormap1 == null)
				{
					_defaultColormap1 = (CString) CR2WTypeManager.Create("String", "defaultColormap1", cr2w, this);
				}
				return _defaultColormap1;
			}
			set
			{
				if (_defaultColormap1 == value)
				{
					return;
				}
				_defaultColormap1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("defaultColormap2")] 
		public CString DefaultColormap2
		{
			get
			{
				if (_defaultColormap2 == null)
				{
					_defaultColormap2 = (CString) CR2WTypeManager.Create("String", "defaultColormap2", cr2w, this);
				}
				return _defaultColormap2;
			}
			set
			{
				if (_defaultColormap2 == value)
				{
					return;
				}
				_defaultColormap2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("creationSlots")] 
		public CArray<interopTerrainEditToolCreationSlotInfo> CreationSlots
		{
			get
			{
				if (_creationSlots == null)
				{
					_creationSlots = (CArray<interopTerrainEditToolCreationSlotInfo>) CR2WTypeManager.Create("array:interopTerrainEditToolCreationSlotInfo", "creationSlots", cr2w, this);
				}
				return _creationSlots;
			}
			set
			{
				if (_creationSlots == value)
				{
					return;
				}
				_creationSlots = value;
				PropertySet(this);
			}
		}

		public interopTerrainEditToolInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
