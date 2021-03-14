using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SafeAction : animAnimFeature
	{
		private CBool _triggerHeld;
		private CBool _inCover;
		private CFloat _safeActionDuration;

		[Ordinal(0)] 
		[RED("triggerHeld")] 
		public CBool TriggerHeld
		{
			get
			{
				if (_triggerHeld == null)
				{
					_triggerHeld = (CBool) CR2WTypeManager.Create("Bool", "triggerHeld", cr2w, this);
				}
				return _triggerHeld;
			}
			set
			{
				if (_triggerHeld == value)
				{
					return;
				}
				_triggerHeld = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("inCover")] 
		public CBool InCover
		{
			get
			{
				if (_inCover == null)
				{
					_inCover = (CBool) CR2WTypeManager.Create("Bool", "inCover", cr2w, this);
				}
				return _inCover;
			}
			set
			{
				if (_inCover == value)
				{
					return;
				}
				_inCover = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("safeActionDuration")] 
		public CFloat SafeActionDuration
		{
			get
			{
				if (_safeActionDuration == null)
				{
					_safeActionDuration = (CFloat) CR2WTypeManager.Create("Float", "safeActionDuration", cr2w, this);
				}
				return _safeActionDuration;
			}
			set
			{
				if (_safeActionDuration == value)
				{
					return;
				}
				_safeActionDuration = value;
				PropertySet(this);
			}
		}

		public AnimFeature_SafeAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
