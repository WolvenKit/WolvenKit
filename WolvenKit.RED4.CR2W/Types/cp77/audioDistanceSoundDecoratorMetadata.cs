using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDistanceSoundDecoratorMetadata : audioEmitterMetadata
	{
		private CName _onEnter;
		private CName _onLeave;
		private CFloat _triggerDistance;
		private CBool _stopOnlyVirtualSounds;

		[Ordinal(1)] 
		[RED("onEnter")] 
		public CName OnEnter
		{
			get
			{
				if (_onEnter == null)
				{
					_onEnter = (CName) CR2WTypeManager.Create("CName", "onEnter", cr2w, this);
				}
				return _onEnter;
			}
			set
			{
				if (_onEnter == value)
				{
					return;
				}
				_onEnter = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("onLeave")] 
		public CName OnLeave
		{
			get
			{
				if (_onLeave == null)
				{
					_onLeave = (CName) CR2WTypeManager.Create("CName", "onLeave", cr2w, this);
				}
				return _onLeave;
			}
			set
			{
				if (_onLeave == value)
				{
					return;
				}
				_onLeave = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("triggerDistance")] 
		public CFloat TriggerDistance
		{
			get
			{
				if (_triggerDistance == null)
				{
					_triggerDistance = (CFloat) CR2WTypeManager.Create("Float", "triggerDistance", cr2w, this);
				}
				return _triggerDistance;
			}
			set
			{
				if (_triggerDistance == value)
				{
					return;
				}
				_triggerDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("stopOnlyVirtualSounds")] 
		public CBool StopOnlyVirtualSounds
		{
			get
			{
				if (_stopOnlyVirtualSounds == null)
				{
					_stopOnlyVirtualSounds = (CBool) CR2WTypeManager.Create("Bool", "stopOnlyVirtualSounds", cr2w, this);
				}
				return _stopOnlyVirtualSounds;
			}
			set
			{
				if (_stopOnlyVirtualSounds == value)
				{
					return;
				}
				_stopOnlyVirtualSounds = value;
				PropertySet(this);
			}
		}

		public audioDistanceSoundDecoratorMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
