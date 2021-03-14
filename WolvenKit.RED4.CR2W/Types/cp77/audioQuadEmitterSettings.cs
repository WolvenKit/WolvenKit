using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioQuadEmitterSettings : CVariable
	{
		private CBool _enabled;
		private CBool _interleaved;
		private CFloat _radius;
		private Vector3 _offset;
		private CFloat _angle;
		private CArrayFixedSize<audioAudEventStruct> _events;

		[Ordinal(0)] 
		[RED("Enabled")] 
		public CBool Enabled
		{
			get
			{
				if (_enabled == null)
				{
					_enabled = (CBool) CR2WTypeManager.Create("Bool", "Enabled", cr2w, this);
				}
				return _enabled;
			}
			set
			{
				if (_enabled == value)
				{
					return;
				}
				_enabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Interleaved")] 
		public CBool Interleaved
		{
			get
			{
				if (_interleaved == null)
				{
					_interleaved = (CBool) CR2WTypeManager.Create("Bool", "Interleaved", cr2w, this);
				}
				return _interleaved;
			}
			set
			{
				if (_interleaved == value)
				{
					return;
				}
				_interleaved = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("Radius")] 
		public CFloat Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CFloat) CR2WTypeManager.Create("Float", "Radius", cr2w, this);
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

		[Ordinal(3)] 
		[RED("Offset")] 
		public Vector3 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Vector3) CR2WTypeManager.Create("Vector3", "Offset", cr2w, this);
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

		[Ordinal(4)] 
		[RED("Angle")] 
		public CFloat Angle
		{
			get
			{
				if (_angle == null)
				{
					_angle = (CFloat) CR2WTypeManager.Create("Float", "Angle", cr2w, this);
				}
				return _angle;
			}
			set
			{
				if (_angle == value)
				{
					return;
				}
				_angle = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("Events", 4)] 
		public CArrayFixedSize<audioAudEventStruct> Events
		{
			get
			{
				if (_events == null)
				{
					_events = (CArrayFixedSize<audioAudEventStruct>) CR2WTypeManager.Create("[4]audioAudEventStruct", "Events", cr2w, this);
				}
				return _events;
			}
			set
			{
				if (_events == value)
				{
					return;
				}
				_events = value;
				PropertySet(this);
			}
		}

		public audioQuadEmitterSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
