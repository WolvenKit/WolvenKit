using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnVehicleMoveOnSpline_Overrides : questIVehicleMoveOnSpline_Overrides
	{
		private CBool _useEntry;
		private CBool _useExit;
		private CFloat _entrySpeed;
		private CFloat _exitSpeed;
		private Transform _entryTransform;
		private Transform _exitTransform;
		private scnMarker _entryMarker;
		private scnMarker _exitMarker;

		[Ordinal(0)] 
		[RED("useEntry")] 
		public CBool UseEntry
		{
			get
			{
				if (_useEntry == null)
				{
					_useEntry = (CBool) CR2WTypeManager.Create("Bool", "useEntry", cr2w, this);
				}
				return _useEntry;
			}
			set
			{
				if (_useEntry == value)
				{
					return;
				}
				_useEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("useExit")] 
		public CBool UseExit
		{
			get
			{
				if (_useExit == null)
				{
					_useExit = (CBool) CR2WTypeManager.Create("Bool", "useExit", cr2w, this);
				}
				return _useExit;
			}
			set
			{
				if (_useExit == value)
				{
					return;
				}
				_useExit = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entrySpeed")] 
		public CFloat EntrySpeed
		{
			get
			{
				if (_entrySpeed == null)
				{
					_entrySpeed = (CFloat) CR2WTypeManager.Create("Float", "entrySpeed", cr2w, this);
				}
				return _entrySpeed;
			}
			set
			{
				if (_entrySpeed == value)
				{
					return;
				}
				_entrySpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("exitSpeed")] 
		public CFloat ExitSpeed
		{
			get
			{
				if (_exitSpeed == null)
				{
					_exitSpeed = (CFloat) CR2WTypeManager.Create("Float", "exitSpeed", cr2w, this);
				}
				return _exitSpeed;
			}
			set
			{
				if (_exitSpeed == value)
				{
					return;
				}
				_exitSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("entryTransform")] 
		public Transform EntryTransform
		{
			get
			{
				if (_entryTransform == null)
				{
					_entryTransform = (Transform) CR2WTypeManager.Create("Transform", "entryTransform", cr2w, this);
				}
				return _entryTransform;
			}
			set
			{
				if (_entryTransform == value)
				{
					return;
				}
				_entryTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("exitTransform")] 
		public Transform ExitTransform
		{
			get
			{
				if (_exitTransform == null)
				{
					_exitTransform = (Transform) CR2WTypeManager.Create("Transform", "exitTransform", cr2w, this);
				}
				return _exitTransform;
			}
			set
			{
				if (_exitTransform == value)
				{
					return;
				}
				_exitTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("entryMarker")] 
		public scnMarker EntryMarker
		{
			get
			{
				if (_entryMarker == null)
				{
					_entryMarker = (scnMarker) CR2WTypeManager.Create("scnMarker", "entryMarker", cr2w, this);
				}
				return _entryMarker;
			}
			set
			{
				if (_entryMarker == value)
				{
					return;
				}
				_entryMarker = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("exitMarker")] 
		public scnMarker ExitMarker
		{
			get
			{
				if (_exitMarker == null)
				{
					_exitMarker = (scnMarker) CR2WTypeManager.Create("scnMarker", "exitMarker", cr2w, this);
				}
				return _exitMarker;
			}
			set
			{
				if (_exitMarker == value)
				{
					return;
				}
				_exitMarker = value;
				PropertySet(this);
			}
		}

		public scnVehicleMoveOnSpline_Overrides(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
