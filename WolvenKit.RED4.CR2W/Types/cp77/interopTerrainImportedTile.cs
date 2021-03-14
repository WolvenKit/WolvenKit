using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopTerrainImportedTile : CVariable
	{
		private CString _heightMapAbsolutePath;
		private CString _controlMapAbsolutePath;
		private CString _colorMapAbsolutePath;
		private Point _position;

		[Ordinal(0)] 
		[RED("heightMapAbsolutePath")] 
		public CString HeightMapAbsolutePath
		{
			get
			{
				if (_heightMapAbsolutePath == null)
				{
					_heightMapAbsolutePath = (CString) CR2WTypeManager.Create("String", "heightMapAbsolutePath", cr2w, this);
				}
				return _heightMapAbsolutePath;
			}
			set
			{
				if (_heightMapAbsolutePath == value)
				{
					return;
				}
				_heightMapAbsolutePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("controlMapAbsolutePath")] 
		public CString ControlMapAbsolutePath
		{
			get
			{
				if (_controlMapAbsolutePath == null)
				{
					_controlMapAbsolutePath = (CString) CR2WTypeManager.Create("String", "controlMapAbsolutePath", cr2w, this);
				}
				return _controlMapAbsolutePath;
			}
			set
			{
				if (_controlMapAbsolutePath == value)
				{
					return;
				}
				_controlMapAbsolutePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("colorMapAbsolutePath")] 
		public CString ColorMapAbsolutePath
		{
			get
			{
				if (_colorMapAbsolutePath == null)
				{
					_colorMapAbsolutePath = (CString) CR2WTypeManager.Create("String", "colorMapAbsolutePath", cr2w, this);
				}
				return _colorMapAbsolutePath;
			}
			set
			{
				if (_colorMapAbsolutePath == value)
				{
					return;
				}
				_colorMapAbsolutePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("position")] 
		public Point Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Point) CR2WTypeManager.Create("Point", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		public interopTerrainImportedTile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
