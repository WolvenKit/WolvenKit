using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendEmitterDelaySettings : CVariable
	{
		private CFloat _emitterDelay;
		private CFloat _emitterDelayLow;
		private CBool _useEmitterDelayRange;
		private CBool _useEmitterDelayOnce;

		[Ordinal(0)] 
		[RED("emitterDelay")] 
		public CFloat EmitterDelay
		{
			get
			{
				if (_emitterDelay == null)
				{
					_emitterDelay = (CFloat) CR2WTypeManager.Create("Float", "emitterDelay", cr2w, this);
				}
				return _emitterDelay;
			}
			set
			{
				if (_emitterDelay == value)
				{
					return;
				}
				_emitterDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("emitterDelayLow")] 
		public CFloat EmitterDelayLow
		{
			get
			{
				if (_emitterDelayLow == null)
				{
					_emitterDelayLow = (CFloat) CR2WTypeManager.Create("Float", "emitterDelayLow", cr2w, this);
				}
				return _emitterDelayLow;
			}
			set
			{
				if (_emitterDelayLow == value)
				{
					return;
				}
				_emitterDelayLow = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("useEmitterDelayRange")] 
		public CBool UseEmitterDelayRange
		{
			get
			{
				if (_useEmitterDelayRange == null)
				{
					_useEmitterDelayRange = (CBool) CR2WTypeManager.Create("Bool", "useEmitterDelayRange", cr2w, this);
				}
				return _useEmitterDelayRange;
			}
			set
			{
				if (_useEmitterDelayRange == value)
				{
					return;
				}
				_useEmitterDelayRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("useEmitterDelayOnce")] 
		public CBool UseEmitterDelayOnce
		{
			get
			{
				if (_useEmitterDelayOnce == null)
				{
					_useEmitterDelayOnce = (CBool) CR2WTypeManager.Create("Bool", "useEmitterDelayOnce", cr2w, this);
				}
				return _useEmitterDelayOnce;
			}
			set
			{
				if (_useEmitterDelayOnce == value)
				{
					return;
				}
				_useEmitterDelayOnce = value;
				PropertySet(this);
			}
		}

		public rendEmitterDelaySettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
