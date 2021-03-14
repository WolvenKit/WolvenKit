using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_NavigationImpact : worldEditorDebugColoringSettings
	{
		private CColor _walkable;
		private CColor _ignored;
		private CColor _blocking;
		private CColor _road;
		private CColor _crowd_walkable;
		private CColor _staris_walkable;
		private CColor _drones;
		private CColor _everythign_else;

		[Ordinal(0)] 
		[RED("walkable")] 
		public CColor Walkable
		{
			get
			{
				if (_walkable == null)
				{
					_walkable = (CColor) CR2WTypeManager.Create("Color", "walkable", cr2w, this);
				}
				return _walkable;
			}
			set
			{
				if (_walkable == value)
				{
					return;
				}
				_walkable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ignored")] 
		public CColor Ignored
		{
			get
			{
				if (_ignored == null)
				{
					_ignored = (CColor) CR2WTypeManager.Create("Color", "ignored", cr2w, this);
				}
				return _ignored;
			}
			set
			{
				if (_ignored == value)
				{
					return;
				}
				_ignored = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("blocking")] 
		public CColor Blocking
		{
			get
			{
				if (_blocking == null)
				{
					_blocking = (CColor) CR2WTypeManager.Create("Color", "blocking", cr2w, this);
				}
				return _blocking;
			}
			set
			{
				if (_blocking == value)
				{
					return;
				}
				_blocking = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("road")] 
		public CColor Road
		{
			get
			{
				if (_road == null)
				{
					_road = (CColor) CR2WTypeManager.Create("Color", "road", cr2w, this);
				}
				return _road;
			}
			set
			{
				if (_road == value)
				{
					return;
				}
				_road = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("crowd walkable")] 
		public CColor Crowd_walkable
		{
			get
			{
				if (_crowd_walkable == null)
				{
					_crowd_walkable = (CColor) CR2WTypeManager.Create("Color", "crowd walkable", cr2w, this);
				}
				return _crowd_walkable;
			}
			set
			{
				if (_crowd_walkable == value)
				{
					return;
				}
				_crowd_walkable = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("staris walkable")] 
		public CColor Staris_walkable
		{
			get
			{
				if (_staris_walkable == null)
				{
					_staris_walkable = (CColor) CR2WTypeManager.Create("Color", "staris walkable", cr2w, this);
				}
				return _staris_walkable;
			}
			set
			{
				if (_staris_walkable == value)
				{
					return;
				}
				_staris_walkable = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("drones")] 
		public CColor Drones
		{
			get
			{
				if (_drones == null)
				{
					_drones = (CColor) CR2WTypeManager.Create("Color", "drones", cr2w, this);
				}
				return _drones;
			}
			set
			{
				if (_drones == value)
				{
					return;
				}
				_drones = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("everythign else")] 
		public CColor Everythign_else
		{
			get
			{
				if (_everythign_else == null)
				{
					_everythign_else = (CColor) CR2WTypeManager.Create("Color", "everythign else", cr2w, this);
				}
				return _everythign_else;
			}
			set
			{
				if (_everythign_else == value)
				{
					return;
				}
				_everythign_else = value;
				PropertySet(this);
			}
		}

		public worldDebugColoring_NavigationImpact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
