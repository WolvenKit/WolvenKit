using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BackdoorDataStreamController : BackdoorInkGameController
	{
		private inkWidgetReference _idleGroup;
		private inkWidgetReference _idleVPanelC1;
		private inkWidgetReference _idleVPanelC2;
		private inkWidgetReference _idleVPanelC3;
		private inkWidgetReference _idleVPanelC4;
		private inkWidgetReference _hackedGroup;
		private inkWidgetReference _idleCanvas1;
		private inkWidgetReference _idleCanvas2;
		private inkWidgetReference _idleCanvas3;
		private inkWidgetReference _idleCanvas4;
		private inkWidgetReference _canvasC1;
		private inkWidgetReference _canvasC2;
		private inkWidgetReference _canvasC3;
		private inkWidgetReference _canvasC4;

		[Ordinal(28)] 
		[RED("idleGroup")] 
		public inkWidgetReference IdleGroup_280
		{
			get
			{
				if (_idleGroup == null)
				{
					_idleGroup = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "idleGroup", cr2w, this);
				}
				return _idleGroup;
			}
			set
			{
				if (_idleGroup == value)
				{
					return;
				}
				_idleGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("idleVPanelC1")] 
		public inkWidgetReference IdleVPanelC1
		{
			get
			{
				if (_idleVPanelC1 == null)
				{
					_idleVPanelC1 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "idleVPanelC1", cr2w, this);
				}
				return _idleVPanelC1;
			}
			set
			{
				if (_idleVPanelC1 == value)
				{
					return;
				}
				_idleVPanelC1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("idleVPanelC2")] 
		public inkWidgetReference IdleVPanelC2
		{
			get
			{
				if (_idleVPanelC2 == null)
				{
					_idleVPanelC2 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "idleVPanelC2", cr2w, this);
				}
				return _idleVPanelC2;
			}
			set
			{
				if (_idleVPanelC2 == value)
				{
					return;
				}
				_idleVPanelC2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("idleVPanelC3")] 
		public inkWidgetReference IdleVPanelC3
		{
			get
			{
				if (_idleVPanelC3 == null)
				{
					_idleVPanelC3 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "idleVPanelC3", cr2w, this);
				}
				return _idleVPanelC3;
			}
			set
			{
				if (_idleVPanelC3 == value)
				{
					return;
				}
				_idleVPanelC3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("idleVPanelC4")] 
		public inkWidgetReference IdleVPanelC4
		{
			get
			{
				if (_idleVPanelC4 == null)
				{
					_idleVPanelC4 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "idleVPanelC4", cr2w, this);
				}
				return _idleVPanelC4;
			}
			set
			{
				if (_idleVPanelC4 == value)
				{
					return;
				}
				_idleVPanelC4 = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("hackedGroup")] 
		public inkWidgetReference HackedGroup
		{
			get
			{
				if (_hackedGroup == null)
				{
					_hackedGroup = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "hackedGroup", cr2w, this);
				}
				return _hackedGroup;
			}
			set
			{
				if (_hackedGroup == value)
				{
					return;
				}
				_hackedGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("idleCanvas1")] 
		public inkWidgetReference IdleCanvas1
		{
			get
			{
				if (_idleCanvas1 == null)
				{
					_idleCanvas1 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "idleCanvas1", cr2w, this);
				}
				return _idleCanvas1;
			}
			set
			{
				if (_idleCanvas1 == value)
				{
					return;
				}
				_idleCanvas1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("idleCanvas2")] 
		public inkWidgetReference IdleCanvas2
		{
			get
			{
				if (_idleCanvas2 == null)
				{
					_idleCanvas2 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "idleCanvas2", cr2w, this);
				}
				return _idleCanvas2;
			}
			set
			{
				if (_idleCanvas2 == value)
				{
					return;
				}
				_idleCanvas2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("idleCanvas3")] 
		public inkWidgetReference IdleCanvas3
		{
			get
			{
				if (_idleCanvas3 == null)
				{
					_idleCanvas3 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "idleCanvas3", cr2w, this);
				}
				return _idleCanvas3;
			}
			set
			{
				if (_idleCanvas3 == value)
				{
					return;
				}
				_idleCanvas3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("idleCanvas4")] 
		public inkWidgetReference IdleCanvas4
		{
			get
			{
				if (_idleCanvas4 == null)
				{
					_idleCanvas4 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "idleCanvas4", cr2w, this);
				}
				return _idleCanvas4;
			}
			set
			{
				if (_idleCanvas4 == value)
				{
					return;
				}
				_idleCanvas4 = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("canvasC1")] 
		public inkWidgetReference CanvasC1
		{
			get
			{
				if (_canvasC1 == null)
				{
					_canvasC1 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "canvasC1", cr2w, this);
				}
				return _canvasC1;
			}
			set
			{
				if (_canvasC1 == value)
				{
					return;
				}
				_canvasC1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("canvasC2")] 
		public inkWidgetReference CanvasC2
		{
			get
			{
				if (_canvasC2 == null)
				{
					_canvasC2 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "canvasC2", cr2w, this);
				}
				return _canvasC2;
			}
			set
			{
				if (_canvasC2 == value)
				{
					return;
				}
				_canvasC2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("canvasC3")] 
		public inkWidgetReference CanvasC3
		{
			get
			{
				if (_canvasC3 == null)
				{
					_canvasC3 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "canvasC3", cr2w, this);
				}
				return _canvasC3;
			}
			set
			{
				if (_canvasC3 == value)
				{
					return;
				}
				_canvasC3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("canvasC4")] 
		public inkWidgetReference CanvasC4
		{
			get
			{
				if (_canvasC4 == null)
				{
					_canvasC4 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "canvasC4", cr2w, this);
				}
				return _canvasC4;
			}
			set
			{
				if (_canvasC4 == value)
				{
					return;
				}
				_canvasC4 = value;
				PropertySet(this);
			}
		}

		public BackdoorDataStreamController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
