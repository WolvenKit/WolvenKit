using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BroadcastEvent : redEvent
	{
		private CEnum<EBroadcasteingType> _broadcastType;
		private CBool _shouldOverride;
		private CFloat _lifetime;
		private CEnum<gamedataStimType> _stimType;
		private stimInvestigateData _stimData;
		private CFloat _radius;
		private CBool _propagationChange;
		private wCHandle<entEntity> _directTarget;
		private CFloat _delay;

		[Ordinal(0)] 
		[RED("broadcastType")] 
		public CEnum<EBroadcasteingType> BroadcastType
		{
			get
			{
				if (_broadcastType == null)
				{
					_broadcastType = (CEnum<EBroadcasteingType>) CR2WTypeManager.Create("EBroadcasteingType", "broadcastType", cr2w, this);
				}
				return _broadcastType;
			}
			set
			{
				if (_broadcastType == value)
				{
					return;
				}
				_broadcastType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("shouldOverride")] 
		public CBool ShouldOverride
		{
			get
			{
				if (_shouldOverride == null)
				{
					_shouldOverride = (CBool) CR2WTypeManager.Create("Bool", "shouldOverride", cr2w, this);
				}
				return _shouldOverride;
			}
			set
			{
				if (_shouldOverride == value)
				{
					return;
				}
				_shouldOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lifetime")] 
		public CFloat Lifetime
		{
			get
			{
				if (_lifetime == null)
				{
					_lifetime = (CFloat) CR2WTypeManager.Create("Float", "lifetime", cr2w, this);
				}
				return _lifetime;
			}
			set
			{
				if (_lifetime == value)
				{
					return;
				}
				_lifetime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get
			{
				if (_stimType == null)
				{
					_stimType = (CEnum<gamedataStimType>) CR2WTypeManager.Create("gamedataStimType", "stimType", cr2w, this);
				}
				return _stimType;
			}
			set
			{
				if (_stimType == value)
				{
					return;
				}
				_stimType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("stimData")] 
		public stimInvestigateData StimData
		{
			get
			{
				if (_stimData == null)
				{
					_stimData = (stimInvestigateData) CR2WTypeManager.Create("stimInvestigateData", "stimData", cr2w, this);
				}
				return _stimData;
			}
			set
			{
				if (_stimData == value)
				{
					return;
				}
				_stimData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("propagationChange")] 
		public CBool PropagationChange
		{
			get
			{
				if (_propagationChange == null)
				{
					_propagationChange = (CBool) CR2WTypeManager.Create("Bool", "propagationChange", cr2w, this);
				}
				return _propagationChange;
			}
			set
			{
				if (_propagationChange == value)
				{
					return;
				}
				_propagationChange = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("directTarget")] 
		public wCHandle<entEntity> DirectTarget
		{
			get
			{
				if (_directTarget == null)
				{
					_directTarget = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "directTarget", cr2w, this);
				}
				return _directTarget;
			}
			set
			{
				if (_directTarget == value)
				{
					return;
				}
				_directTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get
			{
				if (_delay == null)
				{
					_delay = (CFloat) CR2WTypeManager.Create("Float", "delay", cr2w, this);
				}
				return _delay;
			}
			set
			{
				if (_delay == value)
				{
					return;
				}
				_delay = value;
				PropertySet(this);
			}
		}

		public BroadcastEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
