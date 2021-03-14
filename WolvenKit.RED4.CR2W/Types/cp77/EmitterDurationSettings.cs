using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EmitterDurationSettings : CVariable
	{
		private CFloat _emitterDuration;
		private CFloat _emitterDurationLow;
		private CBool _useEmitterDurationRange;

		[Ordinal(0)] 
		[RED("emitterDuration")] 
		public CFloat EmitterDuration
		{
			get
			{
				if (_emitterDuration == null)
				{
					_emitterDuration = (CFloat) CR2WTypeManager.Create("Float", "emitterDuration", cr2w, this);
				}
				return _emitterDuration;
			}
			set
			{
				if (_emitterDuration == value)
				{
					return;
				}
				_emitterDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("emitterDurationLow")] 
		public CFloat EmitterDurationLow
		{
			get
			{
				if (_emitterDurationLow == null)
				{
					_emitterDurationLow = (CFloat) CR2WTypeManager.Create("Float", "emitterDurationLow", cr2w, this);
				}
				return _emitterDurationLow;
			}
			set
			{
				if (_emitterDurationLow == value)
				{
					return;
				}
				_emitterDurationLow = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("useEmitterDurationRange")] 
		public CBool UseEmitterDurationRange
		{
			get
			{
				if (_useEmitterDurationRange == null)
				{
					_useEmitterDurationRange = (CBool) CR2WTypeManager.Create("Bool", "useEmitterDurationRange", cr2w, this);
				}
				return _useEmitterDurationRange;
			}
			set
			{
				if (_useEmitterDurationRange == value)
				{
					return;
				}
				_useEmitterDurationRange = value;
				PropertySet(this);
			}
		}

		public EmitterDurationSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
