using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyDiodeLightPresetEvent : redEvent
	{
		private DiodeLightPreset _preset;
		private CFloat _delay;
		private CFloat _duration;
		private CBool _force;

		[Ordinal(0)] 
		[RED("preset")] 
		public DiodeLightPreset Preset
		{
			get
			{
				if (_preset == null)
				{
					_preset = (DiodeLightPreset) CR2WTypeManager.Create("DiodeLightPreset", "preset", cr2w, this);
				}
				return _preset;
			}
			set
			{
				if (_preset == value)
				{
					return;
				}
				_preset = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("force")] 
		public CBool Force
		{
			get
			{
				if (_force == null)
				{
					_force = (CBool) CR2WTypeManager.Create("Bool", "force", cr2w, this);
				}
				return _force;
			}
			set
			{
				if (_force == value)
				{
					return;
				}
				_force = value;
				PropertySet(this);
			}
		}

		public ApplyDiodeLightPresetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
